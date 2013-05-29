namespace TestRunner
{
    partial class SettingsForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.workspaceLocationEdit = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.userNameEdit = new System.Windows.Forms.TextBox();
            this.accessKeyEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontColorBtn = new System.Windows.Forms.Button();
            this.backColorBtn = new System.Windows.Forms.Button();
            this.fontSelectBtn = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.fontColorExample = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.backColorExample = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.fontExample = new System.Windows.Forms.Label();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(545, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // workspaceLocationEdit
            // 
            this.workspaceLocationEdit.Location = new System.Drawing.Point(121, 40);
            this.workspaceLocationEdit.Name = "workspaceLocationEdit";
            this.workspaceLocationEdit.Size = new System.Drawing.Size(418, 20);
            this.workspaceLocationEdit.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "WorkspaceLocation";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // userNameEdit
            // 
            this.userNameEdit.Location = new System.Drawing.Point(121, 66);
            this.userNameEdit.Name = "userNameEdit";
            this.userNameEdit.Size = new System.Drawing.Size(418, 20);
            this.userNameEdit.TabIndex = 4;
            // 
            // accessKeyEdit
            // 
            this.accessKeyEdit.Location = new System.Drawing.Point(121, 92);
            this.accessKeyEdit.Name = "accessKeyEdit";
            this.accessKeyEdit.Size = new System.Drawing.Size(418, 20);
            this.accessKeyEdit.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "AccessKey";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(12, 69);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(57, 13);
            this.UserName.TabIndex = 7;
            this.UserName.Text = "UserName";
            // 
            // fontColorBtn
            // 
            this.fontColorBtn.Location = new System.Drawing.Point(15, 144);
            this.fontColorBtn.Name = "fontColorBtn";
            this.fontColorBtn.Size = new System.Drawing.Size(100, 23);
            this.fontColorBtn.TabIndex = 8;
            this.fontColorBtn.Text = "Set font color";
            this.fontColorBtn.UseVisualStyleBackColor = true;
            this.fontColorBtn.Click += new System.EventHandler(this.fontColorBtn_Click);
            // 
            // backColorBtn
            // 
            this.backColorBtn.Location = new System.Drawing.Point(15, 174);
            this.backColorBtn.Name = "backColorBtn";
            this.backColorBtn.Size = new System.Drawing.Size(100, 23);
            this.backColorBtn.TabIndex = 9;
            this.backColorBtn.Text = "Set back color";
            this.backColorBtn.UseVisualStyleBackColor = true;
            this.backColorBtn.Click += new System.EventHandler(this.backColorBtn_Click);
            // 
            // fontSelectBtn
            // 
            this.fontSelectBtn.Location = new System.Drawing.Point(15, 203);
            this.fontSelectBtn.Name = "fontSelectBtn";
            this.fontSelectBtn.Size = new System.Drawing.Size(100, 23);
            this.fontSelectBtn.TabIndex = 10;
            this.fontSelectBtn.Text = "Set font";
            this.fontSelectBtn.UseVisualStyleBackColor = true;
            this.fontSelectBtn.Click += new System.EventHandler(this.fontSelectBtn_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.backColorExample,
            this.fontColorExample});
            this.shapeContainer1.Size = new System.Drawing.Size(660, 244);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // fontColorExample
            // 
            this.fontColorExample.BackColor = System.Drawing.SystemColors.WindowText;
            this.fontColorExample.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.fontColorExample.FillGradientColor = System.Drawing.SystemColors.WindowText;
            this.fontColorExample.Location = new System.Drawing.Point(124, 145);
            this.fontColorExample.Name = "fontColorExample";
            this.fontColorExample.Size = new System.Drawing.Size(25, 22);
            // 
            // backColorExample
            // 
            this.backColorExample.BackColor = System.Drawing.SystemColors.Control;
            this.backColorExample.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.backColorExample.Cursor = System.Windows.Forms.Cursors.Default;
            this.backColorExample.Location = new System.Drawing.Point(124, 174);
            this.backColorExample.Name = "backColorExample";
            this.backColorExample.Size = new System.Drawing.Size(25, 22);
            // 
            // fontExample
            // 
            this.fontExample.AutoSize = true;
            this.fontExample.Location = new System.Drawing.Point(121, 208);
            this.fontExample.Name = "fontExample";
            this.fontExample.Size = new System.Drawing.Size(47, 13);
            this.fontExample.TabIndex = 12;
            this.fontExample.Text = "Example";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 244);
            this.Controls.Add(this.fontExample);
            this.Controls.Add(this.fontSelectBtn);
            this.Controls.Add(this.backColorBtn);
            this.Controls.Add(this.fontColorBtn);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accessKeyEdit);
            this.Controls.Add(this.userNameEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.workspaceLocationEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox workspaceLocationEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox userNameEdit;
        private System.Windows.Forms.TextBox accessKeyEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button fontColorBtn;
        private System.Windows.Forms.Button backColorBtn;
        private System.Windows.Forms.Button fontSelectBtn;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape backColorExample;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape fontColorExample;
        private System.Windows.Forms.Label fontExample;
        private System.Windows.Forms.FontDialog fontDialog;

    }
}