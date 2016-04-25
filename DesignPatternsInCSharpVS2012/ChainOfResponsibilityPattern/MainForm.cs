using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChainOfResponsibility.Classes;
using System.Diagnostics;

namespace ChainOfResponsibility
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Setup Listeners
            Trace.Listeners.Add(new CustomTraceListener(this));

            LoggerList.Items.Add("Logger");
            EmailerList.Items.Add("Emailer");
        }

        private void CreateMessageButton_Click(object sender, EventArgs e)
        {
            Logic logic = new Logic();
            logic.Receiver = new Logger(new Emailer(null));

            Classes.Message message = new Classes.Message();
            message.Text = MessageText.Text;
            if (NormalButton.Checked)
                message.Priority = MessagePriority.Normal;
            else
                message.Priority = MessagePriority.High;

            logic.CreateMessage(message);
        }
    }

    class CustomTraceListener : TraceListener
    {
        private MainForm _form;

        public CustomTraceListener(MainForm form)
        {
            _form = form;
        }

        public override void Write(string message)
        {
            WriteLine(message);
        }

        public override void WriteLine(string message)
        {
            if (message.Contains(": Logger"))
                _form.LoggerList.Items.Add(message);

            else
                _form.EmailerList.Items.Add(message);
        }
    }
}
