using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WhoisScraper
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         MainForm form = new MainForm();
         form.StartPosition = FormStartPosition.CenterScreen;
         Application.Run(form);
      }
   }
}
