using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BridgePattern
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AbstractBL bl = new TransactionBL();
            bl.Logger = new TextFileLogger();
            bl.ProcessPayment();

            bl.Logger = new EmailLogger();
            bl.ProcessPayment();

            Console.ReadKey(false);
        }
    }
}
