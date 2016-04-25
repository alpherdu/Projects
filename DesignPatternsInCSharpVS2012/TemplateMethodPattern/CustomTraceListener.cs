using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace TemplateMethodPattern
{
    public class CustomTraceListener : TraceListener
    {
        private ListBox _logBox;

        public CustomTraceListener(ListBox logBox)
        {
            _logBox = logBox;
        }

        public override void Write(string message)
        {
            WriteLine(message);
        }

        public override void WriteLine(string message)
        {
            _logBox.Items.Add(message);

            _logBox.SelectedIndex = _logBox.Items.Count - 1;
        }
    }
}
