using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MementoPattern
{
    public partial class MainForm : Form
    {
        private Point _start, _end;
        private Drawing _drawing;

        public MainForm()
        {
            InitializeComponent();

            _drawing = new Drawing(panel1);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _start = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _end = e.Location;

            _drawing.AddLine(_start, _end);
        }

        private Memento _memento;

        private void button1_Click(object sender, EventArgs e)
        {
            _memento = _drawing.CreateMemento();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_memento != null)
                _drawing.RestoreMemento(_memento);

            else
                MessageBox.Show("Invalid Memento!");
        }
    }
}
