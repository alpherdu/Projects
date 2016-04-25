using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using BuilderPattern.Resources;

namespace BuilderPattern.Classes
{
    /// <summary>
    /// Robot class implementing builder pattern
    /// </summary>
    public partial class Robot : UserControl
    {
        /// <summary>
        /// Dictionary containing peripheral and the option
        /// </summary>
        public Dictionary<Peripheral, string> Peripherals = new Dictionary<Peripheral, string>();

        /// <summary>
        /// The core method used to create different representations
        /// </summary>
        public void Create()
        {
            while (true)
            {
                // Create new Computer
                _computer = new Bitmap(Images.Computer);

                foreach (Peripheral peripheral in Peripherals.Keys)
                {
                    if (peripheral == Peripheral.Processor)
                        AssembleCPU(Peripherals[peripheral]);

                    if (peripheral == Peripheral.Monitor)
                        AssembleMonitor(Peripherals[peripheral]);

                    if (peripheral == Peripheral.Speakers)
                        AssembleSpeakers(Peripherals[peripheral]);

                }

                AddToStore();
            }
        }

        public Robot()
        {
            InitializeComponent();
        }

        private Bitmap _computer;

        private PictureBox _pictureBox;

        private void AddToStore()
        {
            _pictureBox = new PictureBox();
            _pictureBox.BorderStyle = BorderStyle.FixedSingle;
            _pictureBox.Image = _computer;
            _pictureBox.Height = _computer.Height;
            _pictureBox.Width = _computer.Width;

            try
            {
                MyDelegate del = new MyDelegate(AddToParent);
                IAsyncResult result = Store.BeginInvoke(del);
                while (!result.IsCompleted)
                    Application.DoEvents();
            }
            catch
            {
                // As no stop button provided we have to abort the thread
                Thread.CurrentThread.Abort();
            }
        }

        private void AddToParent()
        {
            Store.Controls.Add(_pictureBox);

            if (Store.Controls.Count > 1)
            {
                Control lastControl = Store.Controls[Store.Controls.Count - 2];
                _pictureBox.Top = lastControl.Top + lastControl.Height + 1;
                Store.ScrollControlIntoView(_pictureBox);
            }
        }

        private delegate void MyDelegate();

        private const int Delay = 500;

        public void AssembleCPU(string model)
        {
            AddLog("Assembling CPU " + model + "..");

            Thread.Sleep(Delay);
            Application.DoEvents();
        }

        public void AssembleMonitor(string model)
        {
            AddLog("Assembling Monitor " + model + "..");

            Thread.Sleep(Delay);
            Application.DoEvents();
        }

        public void AssembleSpeakers(string model)
        {
            AddLog("Assembling Speakers " + model + "..");

            if (model == "Stereo")
                _computer = new Bitmap(Images.ComputerWith2Speaker);
            else
                _computer = new Bitmap(Images.ComputerWithSurroundSpeakers);

            Thread.Sleep(Delay);
            Application.DoEvents();
        }

        private void AddLog(string msg)
        {
            LogBox.Items.Add(msg);

            LogBox.SelectedIndex = LogBox.Items.Count - 1;
        }
    }

    #region "Related Types#

    public enum Peripheral
    {
        Processor,
        Monitor,
        Speakers
    }

    #endregion
}
