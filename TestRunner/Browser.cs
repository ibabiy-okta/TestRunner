using System;
using System.Collections.Generic;
using System.Text;

namespace TestRunner
{
    public class Browser
    {
        private string name;
        private string version;
        private string browserName;
        private string browserPlugin;

        public Browser(string name, string version, string browserName, string browserPlugin)
        {
            this.name = name;
            this.version = version;
            this.browserName = browserName;
            this.browserPlugin = browserPlugin;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        public string BrowserName 
        {
            get { return browserName; }
            set { browserName = value; }
        }

        public string BrowserPlugin
        {
            get { return browserPlugin; }
            set { browserPlugin = value; }
        }
    }
}

