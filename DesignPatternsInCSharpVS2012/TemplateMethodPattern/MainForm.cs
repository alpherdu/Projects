using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TemplateMethodPattern
{
    public partial class MainForm : Form
    {
        public static MainForm Instance;

        public MainForm()
        {
            Instance = this;

            InitializeComponent();

            SetTraceListener();

            FillMachineList();
        }

        private void SetTraceListener()
        {
            CustomTraceListener listener = new CustomTraceListener(LogBox);
            Trace.Listeners.Add(listener);
        }

        private void FillMachineList()
        {
            MachineBox.Items.Clear();
            MachineBox.Items.Add(new PizzaMachine());
            MachineBox.Items.Add(new BurgerMachine());

            MachineBox.SelectedIndex = 0;
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            (MachineBox.SelectedItem as Machine).Execute();
        }
    }
}
