using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Settings settings = new Settings();
            Settings settingsClone = (Settings)settings.Clone();

            settingsClone.ApplicationSettings = "NewSettings";

            Console.WriteLine("INSTANCE 1: " + settings.ToString());
            Console.WriteLine("INSTANCE 2: " + settingsClone.ToString());

            Console.ReadKey(false);
        }
    }
}
