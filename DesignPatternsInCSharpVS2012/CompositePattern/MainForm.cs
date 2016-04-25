using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompositePattern
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            CreateForms();
        }

        private Office _headOffice;

        private void CreateForms()
        {
            // Create Forms
            ClockForm hForm = new ClockForm();
            hForm.Show();

            ClockForm b1Form = new ClockForm();
            b1Form.clock1.ClockBackColor = Color.Red;
            b1Form.clock2.ClockBackColor = Color.LightGreen;
            b1Form.Show();

            ClockForm b2Form = new ClockForm();
            b2Form.clock1.ClockBackColor = Color.Red;
            b2Form.clock2.ClockBackColor = Color.LightGreen;
            b2Form.Show();

            // Create Composite Classes and assign Clock Control instances
            _headOffice = new Office();
            _headOffice.Add(new Clock() { ClockControl = hForm.clock1 });
            _headOffice.Add(new Clock() { ClockControl = hForm.clock2 });

            Office branch1 = new Office();
            branch1.Add(new Clock() { ClockControl = b1Form.clock1 });
            branch1.Add(new Clock() { ClockControl = b1Form.clock2 });
            _headOffice.Add(branch1);

            Office branch2 = new Office();
            branch2.Add(new Clock() { ClockControl = b2Form.clock1 });
            branch2.Add(new Clock() { ClockControl = b2Form.clock2 });
            _headOffice.Add(branch2);
        }

        private void SetTimeButton_Click(object sender, EventArgs e)
        {
            _headOffice.SetTime(new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 10, 0, 0));
        }
    }
}
