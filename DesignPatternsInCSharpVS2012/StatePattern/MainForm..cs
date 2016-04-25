using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatePattern
{
    public partial class MainForm : Form
    {
        private Job _job = new Job();

        public MainForm()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;

            // listen to state change event
            _job.OnJobStateChanged += new Job.JobStateChanged(_job_OnJobStateChanged);
        }

        private void _job_OnJobStateChanged(object sender, JobState newJobState)
        {
            lbl.Text = msg.Text = newJobState.ToString();
            if (newJobState == JobState.Busy)
            {
                pbr.Style = ProgressBarStyle.Marquee;
            }
            else
            {
                pbr.Style = ProgressBarStyle.Blocks;
            }

            Application.DoEvents();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            bool result = _job.AddJob("job");
            if (result)
                msg.Text = "Succcessfully added new job!";
            else
                msg.Text = "Unable to add job!";
        }
    }
}
