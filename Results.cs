using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhoisScraper
{
    class Results
    {
       List<WhoIsInfo> domains = new List<WhoIsInfo>();

       public void AddDomain(WhoIsInfo info)
       {
          domains.Add(info);
       }

       public int GetDomainsCount()
        {
           return domains.Count;
        }

        public void Clear()
        {
           domains.Clear();
        }

        public string ResultsToString()
        {
           const string head = 
"<!DOCTYPE html PUBLIC  \"-//W3C//DTD XHTML 1.0 Transitional//EN \"  \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd \">\n" +
"<html xmlns= \"http://www.w3.org/1999/xhtml \">\n" +
"<head>\n" +
"<meta http-equiv= \"Content-Type \" content= \"text/html; charset=utf-8 \" />\n" +
"<title>Whois Scraper report</title>\n" +
"<style type= \"text/css \">\n" +
"<!--\n" +
"body {\n" +
"	font: 100% Verdana, Arial, Helvetica, sans-serif;\n" +
"	background: #666666;\n" +
"	margin: 0; /* it's good practice to zero the margin and padding of the body element to account for differing browser defaults */\n" +
"	padding: 0;\n" +
"	text-align: center; /* this centers the container in IE 5* browsers. The text is then set to the left aligned default in the #container selector */\n" +
"	color: #000000;\n" +
"}\n" +
".oneColElsCtr #container {\n" +
"	width: 46em;\n" +
"	background: #FFFFFF;\n" +
"	margin: 0 auto; /* the auto margins (in conjunction with a width) center the page */\n" +
"	border: 1px solid #000000;\n" +
"	text-align: left; /* this overrides the text-align: center on the body element. */\n" +
"}\n" +
".oneColElsCtr #mainContent {\n" +
"	padding: 0 20px; /* remember that padding is the space inside the div box and margin is the space outside the div box */\n" +
"}\n" +
"-->\n" +
"</style></head>\n" +
"<body class=\"oneColElsCtr\">\n" +
"<div id=\"container\">\n" +
"  <div id=\"mainContent\">\n" +
"    <h1>Whois Scraper report</h1>\n" +
"    <ul>\n";

           const string end =
"<!-- end #mainContent --></div>\n" +
"<!-- end #container --></div>\n" +
"</body>\n" +
"</html>\n";


           StringBuilder sb = new StringBuilder();
           sb.Append(head);
           sb.AppendLine();

           foreach(WhoIsInfo domain in domains)
           {
              sb.Append("    <li><a href=\"#");
              sb.Append(domain.Domain);
              sb.Append("\">");
              sb.Append(domain.Domain);
              sb.Append("</a></li>");
              sb.AppendLine();
           }
           sb.Append("    </ul>");
           sb.AppendLine();

           foreach(WhoIsInfo domain in domains)
           {
              sb.Append("    <h2 id=\"");
              sb.Append(domain.Domain);
              sb.Append("\">");
              sb.Append(domain.Domain);
              sb.Append("</h2>\n");
              sb.Append("    <p>\n");
              string info = domain.Info.Replace("\n", "<br>\n");
              sb.Append(info);
              sb.AppendLine();
              sb.Append("</p>\n\n");
           }           

           sb.Append(end);

           return sb.ToString();
        }

        public string EmailsToString()
        {
           StringBuilder sb = new StringBuilder();

           foreach(WhoIsInfo domain in domains)
           {
              sb.Append(domain.Domain);
              sb.Append(" ");
              sb.Append(domain.Emails);
              sb.AppendLine();
           }

           return sb.ToString();
        }
    }
}
