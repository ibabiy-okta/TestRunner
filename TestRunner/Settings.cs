using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace TestRunner
{
    class Settings
    {
        private static Settings settings;

        private string workspaceLocation;
        private string userName;
        private string accessKey;

        private string fontColor;
        private string backColor;
        private string fontName;
        private string fontSize;
        private string fontBold;
        private string fontItalic;
        private string fontSrikeout;
        private string fontUnderline;

        private string pluginName;

        private Settings()
        {
            workspaceLocation = "";
            fontColor = "WindowText";
            backColor = "Control";
            fontName = "Microsoft Sans Serif";
            fontSize = "8.25";
            fontBold = "false";
            fontItalic = "false";
            fontSrikeout = "false";
            fontUnderline = "false";
            ReadFromRegistry();
        }

        public static Settings Get()
        {
            if (settings == null)
                settings = new Settings();
            return settings;
        }

        public string WorkspaceLocation 
        {
            get { return workspaceLocation; }
            set { workspaceLocation = value; }
        }

        public string AccessKey
        {
            get { return accessKey; }
            set { accessKey = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string FontColor
        {
            get { return fontColor; }
            set { fontColor = value; }
        }

        public string BackColor
        {
            get { return backColor; }
            set { backColor = value; }
        }

        public string FontName
        {
            get { return fontName; }
            set { fontName = value; }
        }

        public string FontSize
        {
            get { return fontSize; }
            set { fontSize = value; }
        }

        public string FontBold
        {
            get { return fontBold; }
            set { fontBold = value; }
        }

        public string FontItalic
        {
            get { return fontItalic; }
            set { fontItalic = value; }
        }

        public string FontSrikeout
        {
            get { return fontSrikeout; }
            set { fontSrikeout = value; }
        }

        public string FontUnderline
        {
            get { return fontUnderline; }
            set { fontUnderline = value; }
        }

        public string PluginName
        {
            get { return pluginName; }
            set { pluginName = value; }
        }

        public void SaveToRegistry()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\TestRunner");
            key.SetValue("WorkSpaceLocation", workspaceLocation);
           // key.SetValue("PluginName", pluginName);
            key.SetValue("UserName", userName);
            key.SetValue("AccessKey", accessKey);
            key.SetValue("FontColor", fontColor);
            key.SetValue("BackColor", backColor);
            key.SetValue("FontSize", fontSize);
            key.SetValue("FontName", fontName);
            key.SetValue("FontBold", fontBold);
            key.SetValue("FontItalic", fontItalic);
            key.SetValue("FontSrikeout", fontSrikeout);
            key.SetValue("FontUnderline", fontUnderline);
            
        }

        public void ReadFromRegistry()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\TestRunner");
            try
            {
                if (key != null)
                {
                    workspaceLocation = key.GetValue("WorkSpaceLocation").ToString();
                    userName = key.GetValue("UserName").ToString();
                    accessKey = key.GetValue("AccessKey").ToString();
                    fontColor = key.GetValue("FontColor").ToString();
                    backColor = key.GetValue("BackColor").ToString();
                    fontSize = key.GetValue("FontSize").ToString();
                    fontName = key.GetValue("FontName").ToString();
                    fontBold = key.GetValue("FontBold").ToString();
                    fontItalic = key.GetValue("FontItalic").ToString();
                    fontSrikeout = key.GetValue("FontSrikeout").ToString();
                    fontUnderline = key.GetValue("FontUnderline").ToString();
                   // pluginName = key.GetValue("PluginName").ToString();

                }
            }
            catch { }
        }

        public bool CheckConf() 
        {
            return (workspaceLocation != "");// && (pluginName!="");
        }
    }
}
