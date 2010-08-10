namespace WhoisScraper
{
   partial class OptionsForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if(disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
         this.checkBoxProxy = new System.Windows.Forms.CheckBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.textBoxPassword = new System.Windows.Forms.TextBox();
         this.labelPassword = new System.Windows.Forms.Label();
         this.textBoxUsername = new System.Windows.Forms.TextBox();
         this.labelUsername = new System.Windows.Forms.Label();
         this.checkBoxAuth = new System.Windows.Forms.CheckBox();
         this.textBoxPort = new System.Windows.Forms.TextBox();
         this.labelPort = new System.Windows.Forms.Label();
         this.labelHost = new System.Windows.Forms.Label();
         this.textBoxHost = new System.Windows.Forms.TextBox();
         this.buttonOk = new System.Windows.Forms.Button();
         this.buttonCancel = new System.Windows.Forms.Button();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // checkBoxProxy
         // 
         this.checkBoxProxy.AutoSize = true;
         this.checkBoxProxy.Location = new System.Drawing.Point(6, 19);
         this.checkBoxProxy.Name = "checkBoxProxy";
         this.checkBoxProxy.Size = new System.Drawing.Size(105, 17);
         this.checkBoxProxy.TabIndex = 0;
         this.checkBoxProxy.Text = "Use proxy server";
         this.checkBoxProxy.UseVisualStyleBackColor = true;
         this.checkBoxProxy.CheckedChanged += new System.EventHandler(this.checkBoxProxy_CheckedChanged);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.textBoxPassword);
         this.groupBox1.Controls.Add(this.labelPassword);
         this.groupBox1.Controls.Add(this.textBoxUsername);
         this.groupBox1.Controls.Add(this.labelUsername);
         this.groupBox1.Controls.Add(this.checkBoxAuth);
         this.groupBox1.Controls.Add(this.textBoxPort);
         this.groupBox1.Controls.Add(this.labelPort);
         this.groupBox1.Controls.Add(this.labelHost);
         this.groupBox1.Controls.Add(this.textBoxHost);
         this.groupBox1.Controls.Add(this.checkBoxProxy);
         this.groupBox1.Location = new System.Drawing.Point(12, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(331, 158);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Proxy configuration";
         // 
         // textBoxPassword
         // 
         this.textBoxPassword.Enabled = false;
         this.textBoxPassword.Location = new System.Drawing.Point(88, 121);
         this.textBoxPassword.Name = "textBoxPassword";
         this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
         this.textBoxPassword.TabIndex = 9;
         this.textBoxPassword.UseSystemPasswordChar = true;
         // 
         // labelPassword
         // 
         this.labelPassword.AutoSize = true;
         this.labelPassword.Enabled = false;
         this.labelPassword.Location = new System.Drawing.Point(27, 124);
         this.labelPassword.Name = "labelPassword";
         this.labelPassword.Size = new System.Drawing.Size(56, 13);
         this.labelPassword.TabIndex = 8;
         this.labelPassword.Text = "Password:";
         // 
         // textBoxUsername
         // 
         this.textBoxUsername.Enabled = false;
         this.textBoxUsername.Location = new System.Drawing.Point(88, 95);
         this.textBoxUsername.Name = "textBoxUsername";
         this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
         this.textBoxUsername.TabIndex = 7;
         // 
         // labelUsername
         // 
         this.labelUsername.AutoSize = true;
         this.labelUsername.Enabled = false;
         this.labelUsername.Location = new System.Drawing.Point(24, 98);
         this.labelUsername.Name = "labelUsername";
         this.labelUsername.Size = new System.Drawing.Size(58, 13);
         this.labelUsername.TabIndex = 6;
         this.labelUsername.Text = "Username:";
         // 
         // checkBoxAuth
         // 
         this.checkBoxAuth.AutoSize = true;
         this.checkBoxAuth.Enabled = false;
         this.checkBoxAuth.Location = new System.Drawing.Point(27, 68);
         this.checkBoxAuth.Name = "checkBoxAuth";
         this.checkBoxAuth.Size = new System.Drawing.Size(134, 17);
         this.checkBoxAuth.TabIndex = 5;
         this.checkBoxAuth.Text = "Enable authentification";
         this.checkBoxAuth.UseVisualStyleBackColor = true;
         this.checkBoxAuth.CheckedChanged += new System.EventHandler(this.checkBoxAuth_CheckedChanged);
         // 
         // textBoxPort
         // 
         this.textBoxPort.Enabled = false;
         this.textBoxPort.Location = new System.Drawing.Point(229, 42);
         this.textBoxPort.Name = "textBoxPort";
         this.textBoxPort.Size = new System.Drawing.Size(50, 20);
         this.textBoxPort.TabIndex = 4;
         // 
         // labelPort
         // 
         this.labelPort.AutoSize = true;
         this.labelPort.Enabled = false;
         this.labelPort.Location = new System.Drawing.Point(194, 45);
         this.labelPort.Name = "labelPort";
         this.labelPort.Size = new System.Drawing.Size(29, 13);
         this.labelPort.TabIndex = 3;
         this.labelPort.Text = "Port:";
         // 
         // labelHost
         // 
         this.labelHost.AutoSize = true;
         this.labelHost.Enabled = false;
         this.labelHost.Location = new System.Drawing.Point(24, 45);
         this.labelHost.Name = "labelHost";
         this.labelHost.Size = new System.Drawing.Size(32, 13);
         this.labelHost.TabIndex = 2;
         this.labelHost.Text = "Host:";
         // 
         // textBoxHost
         // 
         this.textBoxHost.Enabled = false;
         this.textBoxHost.Location = new System.Drawing.Point(62, 42);
         this.textBoxHost.Name = "textBoxHost";
         this.textBoxHost.Size = new System.Drawing.Size(126, 20);
         this.textBoxHost.TabIndex = 1;
         // 
         // buttonOk
         // 
         this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.buttonOk.Location = new System.Drawing.Point(188, 176);
         this.buttonOk.Name = "buttonOk";
         this.buttonOk.Size = new System.Drawing.Size(75, 23);
         this.buttonOk.TabIndex = 2;
         this.buttonOk.Text = "OK";
         this.buttonOk.UseVisualStyleBackColor = true;
         this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
         // 
         // buttonCancel
         // 
         this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.buttonCancel.Location = new System.Drawing.Point(269, 176);
         this.buttonCancel.Name = "buttonCancel";
         this.buttonCancel.Size = new System.Drawing.Size(75, 23);
         this.buttonCancel.TabIndex = 3;
         this.buttonCancel.Text = "Cancel";
         this.buttonCancel.UseVisualStyleBackColor = true;
         // 
         // OptionsForm
         // 
         this.AcceptButton = this.buttonOk;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.buttonCancel;
         this.ClientSize = new System.Drawing.Size(355, 207);
         this.Controls.Add(this.buttonCancel);
         this.Controls.Add(this.buttonOk);
         this.Controls.Add(this.groupBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "OptionsForm";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.Text = "Options";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.CheckBox checkBoxProxy;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label labelHost;
      private System.Windows.Forms.TextBox textBoxHost;
      private System.Windows.Forms.Label labelPort;
      private System.Windows.Forms.TextBox textBoxPort;
      private System.Windows.Forms.CheckBox checkBoxAuth;
      private System.Windows.Forms.Label labelUsername;
      private System.Windows.Forms.TextBox textBoxUsername;
      private System.Windows.Forms.TextBox textBoxPassword;
      private System.Windows.Forms.Label labelPassword;
      private System.Windows.Forms.Button buttonOk;
      private System.Windows.Forms.Button buttonCancel;
   }
}