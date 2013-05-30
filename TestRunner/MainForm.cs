using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace TestRunner
{
    

    public partial class MainForm : Form
    {
        private delegate void AppendText(string text);
        private AppendText appendTextDelegate;
        private Dictionary<string, Browser> browsers;
        Process p;
        private string template;

        List<Thread> threads;
        public MainForm()
        {
            InitializeComponent();
            initConsoleStyles();
            browserComboBox.SelectedIndex = 0;
            OSComboBox.SelectedIndex = 0;
            appendTextDelegate = new AppendText(AddTextMethod);
            addBrowsers();
            threads = new List<Thread>();
            template =  "use.saucelabs=True\n" +
                        "use.saucelabs.tunnel=True\n" +
                        "saucelabs.username=${username}\n" +
                        "saucelabs.access.key=${access.key}\n\n" +

                        "send.saucelabs.okta.plugin=true\n" +
                        "saucelabs.browser=${browser.name}\n" +
                        "saucelabs.browser.version=${browser.version}\n" +
                        "saucelabs.os=${os.version}\n\n" +

                        "saucelabs.${plugin.browser}.plugin.url=sauce-storage:Okta${plugin.name}PluginSilentInstaller-early-access.exe\n" +
                        "selenium.test.url=http://backdoorentry.okta1.com:1802\n" +
                        "test.app.server=rain.okta1.com\n\n" +

                        "junit.maxmem=1024m\n" +
                        "junit.permgen=512m";
            
            if (!Settings.Get().CheckConf())
            { 
                SettingsForm settingsForm = new SettingsForm();
                settingsForm.ShowDialog();
            }

            p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "cmd";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            injectEnvVars();
            //p.StandardInput.WriteLine("D:");
            //p.StandardInput.WriteLine("cd D:\\project");
        }

        private void initConsoleStyles()
        {
            FontStyle fs = new FontStyle();
            if (Convert.ToBoolean(Settings.Get().FontBold))
                fs = FontStyle.Bold;
            if (Convert.ToBoolean(Settings.Get().FontItalic))
                fs |= FontStyle.Italic;
            if (Convert.ToBoolean(Settings.Get().FontSrikeout))
                fs = FontStyle.Strikeout;
            if (Convert.ToBoolean(Settings.Get().FontUnderline))
                fs = FontStyle.Underline;

            richTextBox1.Font = new Font(Settings.Get().FontName,
                                        (float)Convert.ToDouble(Settings.Get().FontSize), fs);

            richTextBox1.ForeColor = Color.FromName(Settings.Get().FontColor);
            richTextBox1.BackColor = Color.FromName(Settings.Get().BackColor);
           // richTextBox1.AppendText("dfgsdfgsdfgdg");
        }

        private void addBrowsers()
        {
            browsers = new Dictionary<string, Browser>();
            browsers.Add("IE6", new Browser("iexplore", "6", "IE", "ie"));
            browsers.Add("IE7", new Browser("iexplore", "7", "IE", "ie"));
            browsers.Add("IE8", new Browser("iexplore", "8", "IE", "ie"));
            browsers.Add("IE9", new Browser("iexplore", "9", "IE", "ie"));
            browsers.Add("FireFox19", new Browser("firefox", "19", "Firefox", "firefox"));
            browsers.Add("Chrome", new Browser("googlechrome", "", "Chrome", "chrome"));
        }

        private void startRunningCommand()
        {
            richTextBox1.AppendText(textBox1.Text + "\n");
            string cmd = textBox1.Text;
            threads.Add(new Thread(() => RunCmd(cmd)));
            threads[threads.Count - 1].Start();
            textBox1.Text = "";
        }

        private void startRunningCommand(string cmd)
        {
            threads.Add(new Thread(() => RunCmd(cmd)));
            threads[threads.Count-1].Start();
            
        }

        private void AddTextMethod(string text)
        {
            richTextBox1.AppendText(">> "+text+Environment.NewLine);
            richTextBox1.ScrollToCaret();
        }

        private void RunCmd(string cmd)
        {
            string result;
            String line;
            p.StandardInput.WriteLine(cmd);
            //p.StartInfo.Arguments = "/c "+cmd;
            
            
            StreamReader sr = p.StandardOutput;
            try
            {
                while ((line = p.StandardOutput.ReadLine()) != null)
                {
                    richTextBox1.Invoke(appendTextDelegate, new object[] {line});    
                }
            }
            catch { }
            p.StandardInput.WriteLine("\x3");
            //p.WaitForExit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text == "") return;
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddTextMethod(textBox1.Text);
                startRunningCommand();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void createFile()
        {
            try
            {
                if (!Directory.Exists(Settings.Get().WorkspaceLocation))
                {
                    MessageBox.Show("Choose valid workspace path!");
                    return;
                }
                else
                {
                    if (!Settings.Get().WorkspaceLocation.EndsWith(@"\"))
                        Settings.Get().WorkspaceLocation += "\\";
                }
                StreamWriter writer = new StreamWriter(Settings.Get().WorkspaceLocation + "override.properties");
                Browser browser = browsers[browserComboBox.Text];
                writer.Write(template.Replace("${username}", Settings.Get().UserName)
                                     .Replace("${access.key}", Settings.Get().AccessKey)
                                     .Replace("${browser.name}", browser.Name)
                                     .Replace("${browser.version}", browser.Version)
                                     .Replace("${os.version}", OSComboBox.Text)
                                     .Replace("${plugin.name}", browser.BrowserName)
                                     .Replace("${plugin.browser}", browser.BrowserPlugin)
                            );
                writer.Close();
                writer.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            createFile();

        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            if (settings.ShowDialog() == DialogResult.OK) 
            {
                initConsoleStyles();
            }
            if (settings != null)
                settings.Dispose();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                p.Kill();
                foreach (Thread thread in threads)
                {
                    thread.Abort();
                }
            }
            catch { }
        }

        private void injectEnvVars()
        {
            //RunCmd();   
            p.StandardInput.WriteLine();
            p.StandardInput.WriteLine(@"set OKTA_HOME="+Settings.Get().WorkspaceLocation);
            p.StandardInput.WriteLine(@"set THIRDPARTY_HOME=%OKTA_HOME%\thirdparty");
            p.StandardInput.WriteLine(@"set MYSQL_HOME=C:\Program Files\MySQL\MySQL Server 5.1");
            p.StandardInput.WriteLine(@"set ANT_HOME=%THIRDPARTY_HOME%\apache-ant-1.8.2");
            p.StandardInput.WriteLine(@"set CATALINA_HOME=%THIRDPARTY_HOME%\tomcat\6.0.35");
            p.StandardInput.WriteLine(@"set TOMCAT_HOME=%CATALINA_HOME%");
            p.StandardInput.WriteLine(@"set JAVA_ENDORSED_DIRS=%TOMCAT_HOME%\lib\endorsed");
            p.StandardInput.WriteLine(@"set M2_HOME=%THIRDPARTY_HOME%\maven-3.0.3");
            p.StandardInput.WriteLine(@"set SCALA_HOME=%THIRDPARTY_HOME%\scala-2.9.1");
            p.StandardInput.WriteLine(@"set MAVEN_OPTS=-Xmx1024m -XX:MaxPermSize=256m");
            p.StandardInput.WriteLine(@"set GIT_HOME=C:\Program Files (x86)\Git");
            p.StandardInput.WriteLine(@"set OKTA_KS_PASSPHRASE=Abcd!234");
            p.StandardInput.WriteLine(@"set ANT_OPTS=-Xmx1024m -XX:MaxPermSize=512m");
            p.StandardInput.WriteLine(@"set PATH=%MYSQL_HOME%\bin;%ANT_HOME%\bin;%CATALINA_HOME%\bin;%M2_HOME%\bin;%SCALA_HOME%\bin;%GIT_HOME%\bin;%PATH%");
            p.StandardInput.WriteLine(@"call %CATALINA_HOME%\ss-conf\ss-java-env.bat");
            p.StandardInput.WriteLine(Settings.Get().WorkspaceLocation.Substring(0,1) + ":");
            p.StandardInput.WriteLine(@"cd %OKTA_HOME%/okta-core");
            
        }

        private void runTestBtn_Click(object sender, EventArgs e)
        {
            if (testName.Text == "")
            {
                MessageBox.Show("Enter valid class name");
                return;
            }
            createFile();
            startRunningCommand("ant run.selenium.test -Dtestname=" + testName.Text);
            
        }

        private void clearConsoleBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

    }
}
