using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PrototypePattern
{
    public class Settings : ICloneable
    {
        public Settings()
        {
            // Load ApplicationSettings from Configuration
            // Load ThemeSettings from Database
            // Load UserSettings from Database
            Thread.Sleep(3000); // Simulate a delay for the above operations

            ApplicationSettings = "ApplicationSettings1";
            ThemeSettings = "ThemeSettings1";
            UserSettings = "UserSettings1";
        }

        public string ApplicationSettings
        {
            get;
            set;
        }

        public string ThemeSettings
        {
            get;
            set;
        }

        public string UserSettings
        {
            get;
            set;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return this.ApplicationSettings + " " + this.ThemeSettings + " " + this.UserSettings;
        }
    }
}
