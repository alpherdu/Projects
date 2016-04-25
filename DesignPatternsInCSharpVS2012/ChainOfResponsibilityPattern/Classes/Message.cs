using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility.Classes
{
    public class Message
    {
        public string Text;
        public MessagePriority Priority;
    }

    public enum MessagePriority
    {
        Normal,
        High
    }
}
