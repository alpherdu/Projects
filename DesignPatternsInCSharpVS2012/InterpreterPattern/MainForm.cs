using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterpreterPattern
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Interpreter _interpreter = new Interpreter();

        private void ExecuteBu_Click(object sender, EventArgs e)
        {
            _interpreter.Execute(CommandsText.Text, DrawingPanel.CreateGraphics());
        }
    }
}
