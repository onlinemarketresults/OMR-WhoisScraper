using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Diagnostics;
using WhoisScraper.Properties;

namespace WhoisScraper
{
   public partial class MainForm : Form
   {
      Connection connection = new Connection();
      Results results = new Results();
      List<string> inputs = new List<string>();

      public delegate void StringParamDelegate(string arg);

      public MainForm()
      {
         InitializeComponent();
      }

      private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         OptionsForm form = new OptionsForm();
         form.StartPosition = FormStartPosition.CenterParent;
         form.ShowDialog(this);
      }

      private void openToolStripMenuItem_Click(object sender, EventArgs e)
      {
         selectInputFile();
      }

      void selectInputFile()
      {
         OpenFileDialog dlg = new OpenFileDialog();

         if(dlg.ShowDialog(this) == DialogResult.OK)
         {
            updateStatus(Path.GetFileName(dlg.FileName) + " was open");
            textBoxFile.Text = dlg.FileName;
            enableStartControls();
         }
      }

      void enableStartControls()
      {
         buttonStart.Enabled = true;
         startToolStripMenuItem.Enabled = true;
      }

      void disableStartControls()
      {
         buttonStart.Enabled = false;
         startToolStripMenuItem.Enabled = false;
      }

      void ThreadJob()
      {
         const string whoIsUrl = "http://www.whois.net/whois/";

         bool isError = false;
         int cnt = 0;
         foreach(string domain in inputs)
         {
           updateStatus("whois: " + domain + " ...");

            string page = "";
            try
            {
               page = connection.GetWebPage(whoIsUrl + domain);
            }
            catch(Exception ex)
            {
               updateStatus(ex.Message);
               isError = true;
               break;
            }

            WhoIsInfo info = Utils.GetDomainInfo(domain, page);

            results.AddDomain(info);
            string[] items = { info.Domain, info.Emails};
            ListViewItem lvi = new ListViewItem(items);
            lvi.Tag = info;
            listViewResults.Items.Add(lvi);

            if(cnt == 0)
               listViewResults.Items[0].Selected = true;

            cnt++;
         }

         if (!isError)
         {
             StringBuilder sbResult = new StringBuilder();
             sbResult.Append("Completed: ");
             sbResult.Append(results.GetDomainsCount()).Append(" domains processed");
             updateStatus(sbResult.ToString());
             saveAsToolStripMenuItem.Enabled = true;
             saveEmailsToolStripMenuItem.Enabled = true;
         }
      }

      void updateStatus(string value)
      {
         if(InvokeRequired)
         {
            // We're not in the UI thread, so we need to call BeginInvoke
            BeginInvoke(new StringParamDelegate(updateStatus), new object[] { value });
            return;
         }
         // Must be on the UI thread if we've got this far
         toolStripStatusLabelUrl.Text = value;
      }

      private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         saveReport();
      }

      private void saveReport()
      {
         SaveFileDialog dlg = new SaveFileDialog();
         dlg.Filter = "Html Files (*.html)|*.html";
         dlg.Title = "Save Results As";
         dlg.FileName = "whois_report";

         if(dlg.ShowDialog() == DialogResult.OK)
         {
            TextWriter tw = new StreamWriter(dlg.FileName);
            tw.Write(results.ResultsToString());
            tw.Close();
         }
      }

      private void listViewResults_KeyDown(object sender, KeyEventArgs e)
      {
         ListView lv = (ListView)sender;

         if(e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
         {
            ListView.SelectedListViewItemCollection items = lv.SelectedItems;
            foreach(ListViewItem item in items)
            {
               WhoIsInfo info = (WhoIsInfo)item.Tag;
               string str = info.Domain + " " + info.Emails;

               try
               {
                  Clipboard.SetDataObject(str, true);
               }
               catch(System.Runtime.InteropServices.ExternalException ex)
               {
                  MessageBox.Show(ex.Message);
               }
            }
         }
      }

      private void listBoxDomains_SelectedIndexChanged(object sender, EventArgs e)
      {
         ListBox lb = (ListBox)sender;
         WhoIsInfo info = (WhoIsInfo)lb.Items[lb.SelectedIndex];
         richTextBoxInfo.Text = info.Info;
      }

      private void listBoxDomains_KeyDown(object sender, KeyEventArgs e)
      {
         if(e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
         {
            try
            {
               Clipboard.SetDataObject(richTextBoxInfo.Text, true);
            }
            catch(System.Runtime.InteropServices.ExternalException ex)
            {
               MessageBox.Show(ex.Message);
            }
         }
      }

      private void richTextBoxInfo_LinkClicked(object sender, LinkClickedEventArgs e)
      {
         Process.Start(e.LinkText);
      }

      private void buttonSelect_Click(object sender, EventArgs e)
      {
         selectInputFile();
      }

      private void buttonStart_Click(object sender, EventArgs e)
      {
         start();
      }

      private void startToolStripMenuItem_Click(object sender, EventArgs e)
      {
         start();
      }

      void start()
      {
         if(textBoxFile.Text != "")
         {
            FileInfo file = new FileInfo(textBoxFile.Text);
            inputs = Utils.ReadFileInputs(textBoxFile.Text);
         }

         if(richTextBoxDomains.Text != "")
         {
            List<string> userDomains = Utils.ReadUserInputs(richTextBoxDomains.Text);
            inputs.AddRange(userDomains);
         }

         richTextBoxInfo.Clear();
         listViewResults.Items.Clear();
         results.Clear();

         tabControl.SelectedIndex = 1;
         Thread t = new Thread(new ThreadStart(ThreadJob));
         t.IsBackground = true;
         t.Start();
      }

      private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
      {
         AboutForm form = new AboutForm();
         form.StartPosition = FormStartPosition.CenterParent;
         form.ShowDialog(this);
      }

      private void listViewResults_SelectedIndexChanged(object sender, EventArgs e)
      {
         ListView.SelectedListViewItemCollection items = listViewResults.SelectedItems;
         if(items.Count == 1)
         {
            ListViewItem item = items[0];
            WhoIsInfo info = (WhoIsInfo) item.Tag;
            richTextBoxInfo.Text = info.Info;
         }
      }

      private void richTextBoxDomains_TextChanged(object sender, EventArgs e)
      {
         if(textBoxFile.Text == "")
         {
            if(richTextBoxDomains.Text == "")
            {
               disableStartControls();
            }
            else
            {
               enableStartControls();
            }
         }
      }

      private void textBoxFile_TextChanged(object sender, EventArgs e)
      {
         if(richTextBoxDomains.Text == "")
         {
            if(textBoxFile.Text == "")
            {
               disableStartControls();
            }
            else
            {
               enableStartControls();
            }
         }
      }

      private void saveEmailsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         SaveFileDialog dlg = new SaveFileDialog();
         dlg.Filter = "Text Files (*.txt)|*.txt";
         dlg.Title = "Save Emails As";
         dlg.FileName = "whois_emails";

         if(dlg.ShowDialog() == DialogResult.OK)
         {
            TextWriter tw = new StreamWriter(dlg.FileName);
            tw.Write(results.EmailsToString());
            tw.Close();
         }
      }
   }
}
