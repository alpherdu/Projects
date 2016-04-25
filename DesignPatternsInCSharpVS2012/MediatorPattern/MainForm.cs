using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediatorPattern
{
    public partial class MainForm : Form
    {
        private FlightMediator _mediator;

        private Engine _engine;
        private Aviation _aviation;
        private Wheels _wheels;
        private Cockpit _cockpit;

        public MainForm()
        {
            InitializeComponent();

            // Create Instances
            _engine = new Engine();
            _aviation = new Aviation();
            _wheels = new Wheels();
            _cockpit = new Cockpit();

            _mediator = new FlightMediator(_engine, _aviation, _wheels, _cockpit);
        }

        private void MediatorButton_Click(object sender, EventArgs e)
        {
            bool status = _mediator.IsReady();

            if (status)
                MediatorButton.BackColor = Color.Green;
            else
                MediatorButton.BackColor = Color.Red;
        }
    }
}
