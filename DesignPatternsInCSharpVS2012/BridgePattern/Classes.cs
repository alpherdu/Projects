using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    public abstract class AbstractBL
    {
        public AbstractLogger Logger;

        public abstract void ProcessPayment();
    }

    public abstract class AbstractLogger
    {
        public abstract void Write(string info);
    }

    public class TransactionBL : AbstractBL
    {
        public override void ProcessPayment()
        {
            Logger.Write("Processing Payment");

            // Process Payment here
        }
    }

    public class TextFileLogger : AbstractLogger
    {
        public override void Write(string info)
        {
            Console.WriteLine("Writing to file: " + info);
        }
    }

    public class EmailLogger : AbstractLogger
    {
        public override void Write(string info)
        {
            Console.WriteLine("Sending Email: " + info);
        }
    }

}
