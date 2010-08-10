namespace WhoisScraper
{
   partial class MainForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
         this.menuStrip = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveEmailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.statusStrip = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabelUrl = new System.Windows.Forms.ToolStripStatusLabel();
         this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
         this.tabControl = new System.Windows.Forms.TabControl();
         this.tabPageInputs = new System.Windows.Forms.TabPage();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
         this.labelFile = new System.Windows.Forms.Label();
         this.textBoxFile = new System.Windows.Forms.TextBox();
         this.buttonSelect = new System.Windows.Forms.Button();
         this.labelDomains = new System.Windows.Forms.Label();
         this.richTextBoxDomains = new System.Windows.Forms.RichTextBox();
         this.buttonStart = new System.Windows.Forms.Button();
         this.tabPageResults = new System.Windows.Forms.TabPage();
         this.splitContainer = new System.Windows.Forms.SplitContainer();
         this.listViewResults = new System.Windows.Forms.ListView();
         this.chDomain = new System.Windows.Forms.ColumnHeader();
         this.chEmails = new System.Windows.Forms.ColumnHeader();
         this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
         this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
         this.labelDetails = new System.Windows.Forms.Label();
         this.menuStrip.SuspendLayout();
         this.statusStrip.SuspendLayout();
         this.tableLayoutPanel.SuspendLayout();
         this.tabControl.SuspendLayout();
         this.tabPageInputs.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         this.tableLayoutPanel2.SuspendLayout();
         this.tableLayoutPanel3.SuspendLayout();
         this.tabPageResults.SuspendLayout();
         this.splitContainer.Panel1.SuspendLayout();
         this.splitContainer.Panel2.SuspendLayout();
         this.splitContainer.SuspendLayout();
         this.tableLayoutPanel4.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip
         // 
         this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.startToolStripMenuItem,
            this.aboutToolStripMenuItem});
         this.menuStrip.Location = new System.Drawing.Point(0, 0);
         this.menuStrip.Name = "menuStrip";
         this.menuStrip.Size = new System.Drawing.Size(609, 24);
         this.menuStrip.TabIndex = 0;
         this.menuStrip.Text = "menuStrip";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveEmailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
         this.fileToolStripMenuItem.Text = "&File";
         // 
         // openToolStripMenuItem
         // 
         this.openToolStripMenuItem.Name = "openToolStripMenuItem";
         this.openToolStripMenuItem.ShortcutKeyDisplayString = "";
         this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
         this.openToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
         this.openToolStripMenuItem.Text = "&Open...";
         this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
         // 
         // saveAsToolStripMenuItem
         // 
         this.saveAsToolStripMenuItem.Enabled = false;
         this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
         this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
         this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
         this.saveAsToolStripMenuItem.Text = "&Save Report...";
         this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
         // 
         // saveEmailsToolStripMenuItem
         // 
         this.saveEmailsToolStripMenuItem.Enabled = false;
         this.saveEmailsToolStripMenuItem.Name = "saveEmailsToolStripMenuItem";
         this.saveEmailsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
         this.saveEmailsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
         this.saveEmailsToolStripMenuItem.Text = "Save &Emails...";
         this.saveEmailsToolStripMenuItem.Click += new System.EventHandler(this.saveEmailsToolStripMenuItem_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
         // 
         // optionsToolStripMenuItem
         // 
         this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
         this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
         this.optionsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
         this.optionsToolStripMenuItem.Text = "O&ptions";
         this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
         this.exitToolStripMenuItem.Text = "E&xit";
         // 
         // startToolStripMenuItem
         // 
         this.startToolStripMenuItem.Enabled = false;
         this.startToolStripMenuItem.Name = "startToolStripMenuItem";
         this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
         this.startToolStripMenuItem.Text = "Start";
         this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
         // 
         // aboutToolStripMenuItem
         // 
         this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
         this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
         this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
         this.aboutToolStripMenuItem.Text = "&About";
         this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
         // 
         // statusStrip
         // 
         this.statusStrip.GripMargin = new System.Windows.Forms.Padding(1);
         this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUrl});
         this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
         this.statusStrip.Location = new System.Drawing.Point(0, 392);
         this.statusStrip.Name = "statusStrip";
         this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
         this.statusStrip.Size = new System.Drawing.Size(609, 19);
         this.statusStrip.SizingGrip = false;
         this.statusStrip.TabIndex = 1;
         this.statusStrip.Text = "statusStrip1";
         // 
         // toolStripStatusLabelUrl
         // 
         this.toolStripStatusLabelUrl.Name = "toolStripStatusLabelUrl";
         this.toolStripStatusLabelUrl.Size = new System.Drawing.Size(178, 13);
         this.toolStripStatusLabelUrl.Spring = true;
         this.toolStripStatusLabelUrl.Text = "Select input or add domains to start";
         // 
         // tableLayoutPanel
         // 
         this.tableLayoutPanel.AutoSize = true;
         this.tableLayoutPanel.ColumnCount = 1;
         this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel.Controls.Add(this.tabControl, 0, 0);
         this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
         this.tableLayoutPanel.Name = "tableLayoutPanel";
         this.tableLayoutPanel.RowCount = 1;
         this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.14085F));
         this.tableLayoutPanel.Size = new System.Drawing.Size(609, 368);
         this.tableLayoutPanel.TabIndex = 5;
         // 
         // tabControl
         // 
         this.tabControl.Controls.Add(this.tabPageInputs);
         this.tabControl.Controls.Add(this.tabPageResults);
         this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControl.Location = new System.Drawing.Point(3, 3);
         this.tabControl.Name = "tabControl";
         this.tabControl.SelectedIndex = 0;
         this.tabControl.Size = new System.Drawing.Size(603, 362);
         this.tabControl.TabIndex = 0;
         // 
         // tabPageInputs
         // 
         this.tabPageInputs.Controls.Add(this.tableLayoutPanel1);
         this.tabPageInputs.Location = new System.Drawing.Point(4, 22);
         this.tabPageInputs.Name = "tabPageInputs";
         this.tabPageInputs.Padding = new System.Windows.Forms.Padding(3);
         this.tabPageInputs.Size = new System.Drawing.Size(595, 336);
         this.tabPageInputs.TabIndex = 0;
         this.tabPageInputs.Text = "Inputs";
         this.tabPageInputs.UseVisualStyleBackColor = true;
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 2;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
         this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.buttonStart, 1, 0);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 1;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 330);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // tableLayoutPanel2
         // 
         this.tableLayoutPanel2.ColumnCount = 1;
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
         this.tableLayoutPanel2.Controls.Add(this.labelDomains, 0, 1);
         this.tableLayoutPanel2.Controls.Add(this.richTextBoxDomains, 0, 2);
         this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
         this.tableLayoutPanel2.Name = "tableLayoutPanel2";
         this.tableLayoutPanel2.RowCount = 3;
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
         this.tableLayoutPanel2.Size = new System.Drawing.Size(483, 324);
         this.tableLayoutPanel2.TabIndex = 0;
         // 
         // tableLayoutPanel3
         // 
         this.tableLayoutPanel3.ColumnCount = 3;
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel3.Controls.Add(this.labelFile, 0, 0);
         this.tableLayoutPanel3.Controls.Add(this.textBoxFile, 1, 0);
         this.tableLayoutPanel3.Controls.Add(this.buttonSelect, 2, 0);
         this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
         this.tableLayoutPanel3.Name = "tableLayoutPanel3";
         this.tableLayoutPanel3.RowCount = 1;
         this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel3.Size = new System.Drawing.Size(477, 34);
         this.tableLayoutPanel3.TabIndex = 0;
         // 
         // labelFile
         // 
         this.labelFile.AutoSize = true;
         this.labelFile.Location = new System.Drawing.Point(3, 8);
         this.labelFile.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
         this.labelFile.Name = "labelFile";
         this.labelFile.Size = new System.Drawing.Size(26, 13);
         this.labelFile.TabIndex = 0;
         this.labelFile.Text = "File:";
         // 
         // textBoxFile
         // 
         this.textBoxFile.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textBoxFile.Location = new System.Drawing.Point(36, 6);
         this.textBoxFile.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
         this.textBoxFile.Name = "textBoxFile";
         this.textBoxFile.Size = new System.Drawing.Size(408, 20);
         this.textBoxFile.TabIndex = 1;
         this.textBoxFile.TextChanged += new System.EventHandler(this.textBoxFile_TextChanged);
         // 
         // buttonSelect
         // 
         this.buttonSelect.Location = new System.Drawing.Point(450, 4);
         this.buttonSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
         this.buttonSelect.Name = "buttonSelect";
         this.buttonSelect.Size = new System.Drawing.Size(24, 23);
         this.buttonSelect.TabIndex = 2;
         this.buttonSelect.Text = "...";
         this.buttonSelect.UseVisualStyleBackColor = true;
         this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
         // 
         // labelDomains
         // 
         this.labelDomains.AutoSize = true;
         this.labelDomains.Location = new System.Drawing.Point(7, 48);
         this.labelDomains.Margin = new System.Windows.Forms.Padding(7, 8, 3, 0);
         this.labelDomains.Name = "labelDomains";
         this.labelDomains.Size = new System.Drawing.Size(98, 13);
         this.labelDomains.TabIndex = 1;
         this.labelDomains.Text = "Additional domains:";
         // 
         // richTextBoxDomains
         // 
         this.richTextBoxDomains.Dock = System.Windows.Forms.DockStyle.Fill;
         this.richTextBoxDomains.Location = new System.Drawing.Point(39, 73);
         this.richTextBoxDomains.Margin = new System.Windows.Forms.Padding(39, 3, 36, 3);
         this.richTextBoxDomains.Name = "richTextBoxDomains";
         this.richTextBoxDomains.Size = new System.Drawing.Size(408, 248);
         this.richTextBoxDomains.TabIndex = 3;
         this.richTextBoxDomains.Text = "";
         this.richTextBoxDomains.TextChanged += new System.EventHandler(this.richTextBoxDomains_TextChanged);
         // 
         // buttonStart
         // 
         this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.buttonStart.Enabled = false;
         this.buttonStart.Location = new System.Drawing.Point(511, 10);
         this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
         this.buttonStart.Name = "buttonStart";
         this.buttonStart.Size = new System.Drawing.Size(75, 23);
         this.buttonStart.TabIndex = 4;
         this.buttonStart.Text = "&Start";
         this.buttonStart.UseVisualStyleBackColor = true;
         this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
         // 
         // tabPageResults
         // 
         this.tabPageResults.Controls.Add(this.splitContainer);
         this.tabPageResults.Location = new System.Drawing.Point(4, 22);
         this.tabPageResults.Name = "tabPageResults";
         this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
         this.tabPageResults.Size = new System.Drawing.Size(595, 337);
         this.tabPageResults.TabIndex = 1;
         this.tabPageResults.Text = "Results";
         this.tabPageResults.UseVisualStyleBackColor = true;
         // 
         // splitContainer
         // 
         this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer.Location = new System.Drawing.Point(3, 3);
         this.splitContainer.Name = "splitContainer";
         // 
         // splitContainer.Panel1
         // 
         this.splitContainer.Panel1.Controls.Add(this.listViewResults);
         // 
         // splitContainer.Panel2
         // 
         this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanel4);
         this.splitContainer.Size = new System.Drawing.Size(589, 331);
         this.splitContainer.SplitterDistance = 249;
         this.splitContainer.SplitterWidth = 3;
         this.splitContainer.TabIndex = 1;
         // 
         // listViewResults
         // 
         this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDomain,
            this.chEmails});
         this.listViewResults.Dock = System.Windows.Forms.DockStyle.Fill;
         this.listViewResults.FullRowSelect = true;
         this.listViewResults.GridLines = true;
         this.listViewResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
         this.listViewResults.HideSelection = false;
         this.listViewResults.Location = new System.Drawing.Point(0, 0);
         this.listViewResults.MultiSelect = false;
         this.listViewResults.Name = "listViewResults";
         this.listViewResults.Size = new System.Drawing.Size(249, 331);
         this.listViewResults.TabIndex = 0;
         this.listViewResults.UseCompatibleStateImageBehavior = false;
         this.listViewResults.View = System.Windows.Forms.View.Details;
         this.listViewResults.SelectedIndexChanged += new System.EventHandler(this.listViewResults_SelectedIndexChanged);
         this.listViewResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewResults_KeyDown);
         // 
         // chDomain
         // 
         this.chDomain.Text = "Domain";
         this.chDomain.Width = 83;
         // 
         // chEmails
         // 
         this.chEmails.Text = "Emails";
         this.chEmails.Width = 156;
         // 
         // tableLayoutPanel4
         // 
         this.tableLayoutPanel4.ColumnCount = 1;
         this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel4.Controls.Add(this.richTextBoxInfo, 0, 1);
         this.tableLayoutPanel4.Controls.Add(this.labelDetails, 0, 0);
         this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel4.Name = "tableLayoutPanel4";
         this.tableLayoutPanel4.RowCount = 2;
         this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
         this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel4.Size = new System.Drawing.Size(337, 331);
         this.tableLayoutPanel4.TabIndex = 0;
         // 
         // richTextBoxInfo
         // 
         this.richTextBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
         this.richTextBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.richTextBoxInfo.Location = new System.Drawing.Point(3, 19);
         this.richTextBoxInfo.Name = "richTextBoxInfo";
         this.richTextBoxInfo.Size = new System.Drawing.Size(331, 309);
         this.richTextBoxInfo.TabIndex = 1;
         this.richTextBoxInfo.Text = "";
         // 
         // labelDetails
         // 
         this.labelDetails.AutoSize = true;
         this.labelDetails.Location = new System.Drawing.Point(3, 4);
         this.labelDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
         this.labelDetails.Name = "labelDetails";
         this.labelDetails.Size = new System.Drawing.Size(42, 12);
         this.labelDetails.TabIndex = 2;
         this.labelDetails.Text = "Details:";
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(609, 411);
         this.Controls.Add(this.tableLayoutPanel);
         this.Controls.Add(this.statusStrip);
         this.Controls.Add(this.menuStrip);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MinimumSize = new System.Drawing.Size(320, 240);
         this.Name = "MainForm";
         this.Text = "Whois Scraper";
         this.menuStrip.ResumeLayout(false);
         this.menuStrip.PerformLayout();
         this.statusStrip.ResumeLayout(false);
         this.statusStrip.PerformLayout();
         this.tableLayoutPanel.ResumeLayout(false);
         this.tabControl.ResumeLayout(false);
         this.tabPageInputs.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel2.ResumeLayout(false);
         this.tableLayoutPanel2.PerformLayout();
         this.tableLayoutPanel3.ResumeLayout(false);
         this.tableLayoutPanel3.PerformLayout();
         this.tabPageResults.ResumeLayout(false);
         this.splitContainer.Panel1.ResumeLayout(false);
         this.splitContainer.Panel2.ResumeLayout(false);
         this.splitContainer.ResumeLayout(false);
         this.tableLayoutPanel4.ResumeLayout(false);
         this.tableLayoutPanel4.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.StatusStrip statusStrip;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUrl;
      private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
      private System.Windows.Forms.TabControl tabControl;
      private System.Windows.Forms.TabPage tabPageInputs;
      private System.Windows.Forms.TabPage tabPageResults;
      private System.Windows.Forms.SplitContainer splitContainer;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
      private System.Windows.Forms.Label labelFile;
      private System.Windows.Forms.TextBox textBoxFile;
      private System.Windows.Forms.Button buttonSelect;
      private System.Windows.Forms.Button buttonStart;
      private System.Windows.Forms.Label labelDomains;
      private System.Windows.Forms.RichTextBox richTextBoxDomains;
      private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
      private System.Windows.Forms.ListView listViewResults;
      private System.Windows.Forms.ColumnHeader chDomain;
      private System.Windows.Forms.ColumnHeader chEmails;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
      private System.Windows.Forms.RichTextBox richTextBoxInfo;
      private System.Windows.Forms.Label labelDetails;
      private System.Windows.Forms.ToolStripMenuItem saveEmailsToolStripMenuItem;
   }
}

