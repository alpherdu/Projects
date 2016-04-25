using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility.Classes
{
    public class Logic
    {
        public IReceiver Receiver;

        public void CreateMessage(Message message)
        {
            if (Receiver != null)
                Receiver.HandleMessage(message);
        }
    }
}
