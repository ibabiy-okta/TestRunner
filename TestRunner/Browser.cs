using System;
using System.Collections.Generic;
using System.Text;

namespace TestRunner
{
    public class Browser
    {
        private string name;
        private string version;

        public Browser(string name, string version)
        {
            this.name = name;
            this.version = version;
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
    }
}
