using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace TemplateMethodPattern
{
    public class PizzaMachine : Machine
    {
        protected override void Produce()
        {
            Trace.WriteLine("PizzaMachine.Producing..");

            MainForm.Instance.flowLayoutPanel1.Controls.Add(new PictureBox() { Image = Images.Pizza, Width = 150, Height = 150, SizeMode = PictureBoxSizeMode.StretchImage, BorderStyle = BorderStyle.Fixed3D });
        }
    }
}
