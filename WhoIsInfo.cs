using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhoisScraper
{
   class WhoIsInfo
   {
      string domain;
      string info;
      string emails;

      public string Domain
      {
         get
         {
            return domain;
         }
         set
         {
            domain = value;
         }
      }

      public string Info
      {
         get
         {
            return info;
         }
         set
         {
            info = value;
         }
      }

      public string Emails
      {
         get
         {
            return emails;
         }
         set
         {
            emails = value;
         }
      }

      override public String ToString()
      {
         return domain;
      }
   }
}
