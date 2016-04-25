using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace StatePattern
{
    public class Job
    {
        public delegate void JobStateChanged(object sender, JobState newJobState);
        public event JobStateChanged OnJobStateChanged;

        private JobState _State;

        public JobState State
        {
            get { return _State; }
            set 
            { 
                _State = value;

                if (OnJobStateChanged != null)
                    OnJobStateChanged(this, _State);
            }
        }

        public bool AddJob(object jobParameter)
        {
            switch (State)
            {
                case JobState.Ready:
                    {
                        DoJob();
                        return true;
                    }
                case JobState.Busy:
                    {
                        return false;
                    }
            }

            return false;
        }

        private void DoJob()
        {
            State = JobState.Busy;
            new Thread(new ThreadStart(JobMethod)).Start();
        }

        private void JobMethod()
        {
            Application.DoEvents();
            Thread.Sleep(5000);
            State = JobState.Ready;
        }
    }

    public enum JobState
    {
        Ready,
        Busy
    }
}
