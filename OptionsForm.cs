using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WhoisScraper.Properties;

namespace WhoisScraper
{
   public partial class OptionsForm : Form
   {
      public OptionsForm()
      {
         InitializeComponent();
         InitializeValues();
      }

      private void InitializeValues()
      {
         checkBoxProxy.Checked = Settings.Default.isProxyEnabled;
         checkBoxAuth.Checked = Settings.Default.isProxyAuthEnabled;
         checkBoxProxy_CheckedChanged(this, new EventArgs());
         textBoxHost.Text = Settings.Default.host;
         textBoxPort.Text = Settings.Default.port;
         textBoxUsername.Text = Settings.Default.username;
         textBoxPassword.Text = Settings.Default.password;
      }

      private void checkBoxProxy_CheckedChanged(object sender, EventArgs e)
      {
         if(checkBoxProxy.Checked)
         {
            setHostPortEnabled(true);
            if(checkBoxAuth.Checked)
            {
               setUserPaswordEnabled(true);
            }
         }
         else
         {
            setHostPortEnabled(false);
            setUserPaswordEnabled(false);
         }
      }

      private void checkBoxAuth_CheckedChanged(object sender, EventArgs e)
      {
         setUserPaswordEnabled(checkBoxAuth.Checked);
      }

      private void setHostPortEnabled(bool state)
      {
         labelHost.Enabled = state;
         labelPort.Enabled = state;
         textBoxHost.Enabled = state;
         textBoxPort.Enabled = state;
         checkBoxAuth.Enabled = state;
      }

      private void setUserPaswordEnabled(bool state)
      {
         labelUsername.Enabled = state;
         labelPassword.Enabled = state;
         textBoxUsername.Enabled = state;
         textBoxPassword.Enabled = state;
      }

      private void buttonOk_Click(object sender, EventArgs e)
      {
         Settings.Default.isProxyEnabled = checkBoxProxy.Checked;
         Settings.Default.isProxyAuthEnabled = checkBoxAuth.Checked;
         Settings.Default.host = textBoxHost.Text;
         Settings.Default.port = textBoxPort.Text;
         Settings.Default.username = textBoxUsername.Text;
         Settings.Default.password = textBoxPassword.Text;

         Settings.Default.Save();
      }
   }
}
