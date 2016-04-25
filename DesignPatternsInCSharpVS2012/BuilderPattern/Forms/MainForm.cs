using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BuilderPattern.Classes;
using System.Threading;

namespace BuilderPattern
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void AddRobot_Click(object sender, EventArgs e)
        {
            if (Factory.Controls.Count < 3)
            {
                string cPU = IntelCPU.Text;
                if (AMDCPU.Checked)
                    cPU = AMDCPU.Text;

                string monitor = SamsungMonitor.Text;
                if (LGMonitor.Checked)
                    monitor = LGMonitor.Text;

                string speakers = StereoSpeakers.Text;
                if (SurroundSpeakers.Checked)
                    speakers = SurroundSpeakers.Text;

                // Create the robot
                Robot robot = new Robot();
                robot.Peripherals.Add(Peripheral.Processor, cPU);
                robot.Peripherals.Add(Peripheral.Monitor, monitor);
                
                if (!NoSpeakers.Checked)
                    robot.Peripherals.Add(Peripheral.Speakers, speakers);

                AddToFactory(robot);
            }
            else
                MessageBox.Show("Maximum 3 robots allowed!");
        }

        private void AddToFactory(Robot robot)
        {
            int left = 10, top = 14;

            if (Factory.Controls.Count > 0)
            {
                Control lastControl = Factory.Controls[Factory.Controls.Count - 1];
                left = lastControl.Left + lastControl.Width + 5;
            }

            Factory.Controls.Add(robot);

            robot.Left = left;
            robot.Top = top;
        }

        private void StartRun_Click(object sender, EventArgs e)
        {
            if (Factory.Controls.Count > 0)
            {
                StartRun.Enabled = false;
                new Factory().Execute(Factory.Controls);
            }
            else
                MessageBox.Show("No Robots added!");
        }
    }
}
