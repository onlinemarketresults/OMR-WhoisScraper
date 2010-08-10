using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using WhoisScraper.Properties;

namespace WhoisScraper
{
   public class Connection
   {
      private static WebProxy proxy;

      public Connection()
      {
         proxy = new WebProxy();
      }

      public string GetWebPage(string url)
      {
         // get io stream of the web page
         Stream webStream = GetWebPageStream(url);

         // create reader object
         StreamReader reader = new StreamReader(webStream);

         // read the entire stream content:
         string pageContent = reader.ReadToEnd();

         // cleanup
         reader.Close();
         webStream.Close();

         return pageContent;
      }

      public Stream GetWebPageStream(string url)
      {
         // open a connection
         HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(url);
         //webRequest.PreAuthenticate = true;
         webRequest.Method = "GET";
         webRequest.ContentType = "text/xml";
         webRequest.KeepAlive = true;
         webRequest.ContentLength = 0;
         webRequest.AllowWriteStreamBuffering = true;

         // specify additional header values
         webRequest.AllowAutoRedirect = true;
         webRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.0.1) Gecko/2008070206 Firefox/3.0.1";
         webRequest.MaximumAutomaticRedirections = 5;

         // specify http proxy to use
         if(Settings.Default.isProxyEnabled)
         {
            string address = "";
            string host = Settings.Default.host;
            if(host.StartsWith("http") == false)
            {
               address = "http://";
            }

            address += Settings.Default.host + ":" + Settings.Default.port;
            proxy.Address = new Uri(address);

            if(Settings.Default.isProxyAuthEnabled)
            {
               proxy.Credentials = new NetworkCredential(
                  Settings.Default.username, Settings.Default.password);
                proxy.UseDefaultCredentials = false;
            }
            else
            {
               proxy.UseDefaultCredentials = true;
               proxy.Credentials = new NetworkCredential();
            }

            webRequest.Proxy = proxy;

         }

         // request response
         HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
         // open data stream
         Stream webStream = response.GetResponseStream();

         return webStream;
      }
   }
}
