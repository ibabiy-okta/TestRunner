using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestRunner
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            workspaceLocationEdit.Text = Settings.Get().WorkspaceLocation;
            userNameEdit.Text = Settings.Get().UserName;
            accessKeyEdit.Text = Settings.Get().AccessKey;

            FontStyle fs = new FontStyle();
            if (Convert.ToBoolean(Settings.Get().FontBold))
                fs = FontStyle.Bold;
            if (Convert.ToBoolean(Settings.Get().FontItalic))
                fs |= FontStyle.Italic;
            if (Convert.ToBoolean(Settings.Get().FontSrikeout))
                fs = FontStyle.Strikeout;
            if (Convert.ToBoolean(Settings.Get().FontUnderline))
                fs = FontStyle.Underline;
            
            fontExample.Font = new Font(Settings.Get().FontName,
                                        (float)Convert.ToDouble(Settings.Get().FontSize), fs);

            fontColorExample.BackColor = Color.FromName(Settings.Get().FontColor);
            backColorExample.BackColor = Color.FromName(Settings.Get().BackColor);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                workspaceLocationEdit.Text = folderBrowserDialog.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Get().WorkspaceLocation = workspaceLocationEdit.Text;
            Settings.Get().UserName = userNameEdit.Text;
            Settings.Get().AccessKey = accessKeyEdit.Text;
            Settings.Get().SaveToRegistry();
        }

        private void fontColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                fontColorExample.BackColor = colorDialog.Color;
                Settings.Get().FontColor = colorDialog.Color.Name;
            }
        }

        private void backColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                backColorExample.BackColor = colorDialog.Color;
                Settings.Get().BackColor = colorDialog.Color.Name;
            }
        }

        private void fontSelectBtn_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                fontExample.Font = fontDialog.Font;
                Settings.Get().FontName = fontDialog.Font.Name;
                Settings.Get().FontSize = fontDialog.Font.Size.ToString();
                Settings.Get().FontBold = fontDialog.Font.Bold.ToString();
                Settings.Get().FontItalic = fontDialog.Font.Italic.ToString();
                Settings.Get().FontSrikeout = fontDialog.Font.Strikeout.ToString();
                Settings.Get().FontUnderline = fontDialog.Font.Underline.ToString();
            }
        }
    }
}
