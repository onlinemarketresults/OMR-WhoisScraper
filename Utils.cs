using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WhoisScraper.Properties;
using System.IO;

namespace WhoisScraper
{
   class Utils
   {
      // Reads domains from input file
      public static List<string> ReadFileInputs(string filePath)
      {
         List<string> inputs = new List<string>();

         TextReader tr = new StreamReader(filePath);

         // Read file line by line
         string input = null;
         while((input = tr.ReadLine()) != null)
         {
            input = input.Trim();
            if(input == "")
               continue;

            inputs.Add(input);
         }

         return inputs;
      }

      public static List<string> ReadUserInputs(string text)
      {
         List<string> inputs = new List<string>();

         char[] seps = { ',', '\n','\r', '\t', ' '};
         String[] domains = text.Split(seps);

         foreach(string domain in domains)
         {
            string url = domain.Trim();
            if(url != "")
               inputs.Add(url);
         }

         return inputs;
      }

      public static WhoIsInfo GetDomainInfo(string domain, string page)
      {
         const string tag = "<pre>";

         WhoIsInfo info = new WhoIsInfo();
         info.Domain = domain;
         info.Info = "Unable to get whois information";

         int fromPos = page.IndexOf(tag);
         if(fromPos != -1)
         {
            int tillPos = page.IndexOf(tag, fromPos + 1);

            if(tillPos != -1)
            {
               fromPos += tag.Length;
               info.Info = page.Substring(fromPos, tillPos - fromPos);

               info.Emails = "";
               string[] emails = ExtractEmails(info.Info);

               if(emails.Length != 0)
               {
                  for(int i = 0; i < emails.Length - 1; i++)
                  {
                     info.Emails += emails[i];
                     info.Emails += ", ";
                  }
                  info.Emails += emails[emails.Length -1];
               }
            }
         }

         return info;
      }

      public static string[] ExtractEmails(string str)
      {
         string RegexPattern = @"\b[A-Z0-9._-]+@[A-Z0-9][A-Z0-9.-]{0,61}[A-Z0-9]\.[A-Z.]{2,6}\b";

         // Find matches
         System.Text.RegularExpressions.MatchCollection matches
            = System.Text.RegularExpressions.Regex.Matches(str, RegexPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

         string[] matchList = new string[matches.Count];

         // add each match
         int c = 0;
         foreach (System.Text.RegularExpressions.Match match in matches)
         {
            matchList[c] = match.ToString();
            c++;
         }

         return RemoveDuplicates(matchList);
      }

      public static string[] RemoveDuplicates(string[] sa)
      {
         if(sa == null)
            return null;
         if(sa.Length < 2)
            return sa;
         return sa.Distinct().ToArray();
      } 
   }
}
