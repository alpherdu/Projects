using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ChainOfResponsibility.Classes
{
    public interface IReceiver
    {
        bool HandleMessage(Message message);
    }

    public class Logger : IReceiver
    {
        private IReceiver _nextReceiver;

        public Logger(IReceiver nextReceiver)
        {
            _nextReceiver = nextReceiver;
        }

        public bool HandleMessage(Message message)
        {
            if (message.Priority == MessagePriority.Normal)
            {
                Trace.WriteLine(message.Text + " : Logger processed it!");
                return true;
            }
            else
            {
                if (_nextReceiver != null)
                    _nextReceiver.HandleMessage(message);
            }

            return false;
        }
    }

    public class Emailer : IReceiver
    {
        private IReceiver _nextReceiver;

        public Emailer(IReceiver nextReceiver)
        {
            _nextReceiver = nextReceiver;
        }

        public bool HandleMessage(Message message)
        {
            if (message.Priority == MessagePriority.High)
            {
                Trace.WriteLine(message.Text + " : Emailer processed it!");
                return true;
            }
            else
            {
                if (_nextReceiver != null)
                    _nextReceiver.HandleMessage(message);
            }

            return false;
        }
    }
}
