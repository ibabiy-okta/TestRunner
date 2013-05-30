namespace TestRunner
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
            if (disposing && (components != null))
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.browserComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.OSComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.runSauseLabsBtn = new System.Windows.Forms.ToolStripButton();
            this.createOverrideFileBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.testName = new System.Windows.Forms.ToolStripTextBox();
            this.runTestBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SettingsBtn = new System.Windows.Forms.ToolStripButton();
            this.clearConsoleBtn = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1302, 458);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(3, 517);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1302, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1308, 564);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.browserComboBox,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.OSComboBox,
            this.toolStripSeparator4,
            this.runSauseLabsBtn,
            this.createOverrideFileBtn,
            this.toolStripSeparator2,
            this.toolStripLabel5,
            this.testName,
            this.runTestBtn,
            this.toolStripSeparator3,
            this.SettingsBtn,
            this.clearConsoleBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1308, 50);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 47);
            this.toolStripLabel1.Text = "Browser";
            // 
            // browserComboBox
            // 
            this.browserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.browserComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.browserComboBox.Items.AddRange(new object[] {
            "IE7",
            "IE8",
            "IE9",
            "FireFox19",
            "Chrome"});
            this.browserComboBox.Name = "browserComboBox";
            this.browserComboBox.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.browserComboBox.Size = new System.Drawing.Size(121, 50);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(22, 47);
            this.toolStripLabel3.Text = "OS";
            // 
            // OSComboBox
            // 
            this.OSComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OSComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.OSComboBox.Items.AddRange(new object[] {
            "Windows 2003",
            "Windows 2008",
            "Windows XP",
            "Windows 7"});
            this.OSComboBox.MergeIndex = 0;
            this.OSComboBox.Name = "OSComboBox";
            this.OSComboBox.Size = new System.Drawing.Size(121, 50);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 50);
            // 
            // runSauseLabsBtn
            // 
            this.runSauseLabsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runSauseLabsBtn.Image = global::TestRunner.Properties.Resources.gnome_session_logout_8338;
            this.runSauseLabsBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.runSauseLabsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runSauseLabsBtn.Name = "runSauseLabsBtn";
            this.runSauseLabsBtn.Size = new System.Drawing.Size(36, 47);
            this.runSauseLabsBtn.Text = "Run SauseLabs";
            // 
            // createOverrideFileBtn
            // 
            this.createOverrideFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createOverrideFileBtn.Image = global::TestRunner.Properties.Resources.edit_paste_8724;
            this.createOverrideFileBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.createOverrideFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createOverrideFileBtn.Name = "createOverrideFileBtn";
            this.createOverrideFileBtn.Size = new System.Drawing.Size(36, 47);
            this.createOverrideFileBtn.Text = "Create override file";
            this.createOverrideFileBtn.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(62, 47);
            this.toolStripLabel5.Text = "Test name";
            // 
            // testName
            // 
            this.testName.Name = "testName";
            this.testName.Size = new System.Drawing.Size(150, 50);
            // 
            // runTestBtn
            // 
            this.runTestBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runTestBtn.Image = global::TestRunner.Properties.Resources.emblem_multimedia_5837;
            this.runTestBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.runTestBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runTestBtn.Name = "runTestBtn";
            this.runTestBtn.Size = new System.Drawing.Size(36, 47);
            this.runTestBtn.Text = "Run Test";
            this.runTestBtn.Click += new System.EventHandler(this.runTestBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingsBtn.Image = global::TestRunner.Properties.Resources.emblem_system_9797;
            this.SettingsBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SettingsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(36, 47);
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // clearConsoleBtn
            // 
            this.clearConsoleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearConsoleBtn.Image = global::TestRunner.Properties.Resources.edit_delete_4374;
            this.clearConsoleBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clearConsoleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearConsoleBtn.Name = "clearConsoleBtn";
            this.clearConsoleBtn.Size = new System.Drawing.Size(36, 47);
            this.clearConsoleBtn.Text = "Clear console log";
            this.clearConsoleBtn.Click += new System.EventHandler(this.clearConsoleBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 564);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Run tests";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox browserComboBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox OSComboBox;
        private System.Windows.Forms.ToolStripButton runTestBtn;
        private System.Windows.Forms.ToolStripButton runSauseLabsBtn;
        private System.Windows.Forms.ToolStripButton createOverrideFileBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox testName;
        private System.Windows.Forms.ToolStripButton SettingsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton clearConsoleBtn;
    }
}

