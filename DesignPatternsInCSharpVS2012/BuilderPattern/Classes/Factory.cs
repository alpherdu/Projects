using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BuilderPattern.Classes
{
    public class Factory
    {
        public void Execute(Control.ControlCollection controlCollection)
        {
            foreach (Robot robot in controlCollection)
            {
                ThreadStart threadStart = new ThreadStart(robot.Create);
                Thread thread = new Thread(threadStart);
                thread.Start();
            }
        }
    }
}
