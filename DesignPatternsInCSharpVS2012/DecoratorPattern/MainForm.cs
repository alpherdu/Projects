using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DecoratorPattern.Classes;

namespace DecoratorPattern
{
    public partial class MainForm : Form
    {
        private Graphics _graphics;
        private Album _album;

        public MainForm()
        {
            InitializeComponent();

            // Create Instances
            _graphics = pbxMain.CreateGraphics();
            _album = new Album(_graphics);
            _album.Draw();
        }

        private void btnAddChtristmasTree_Click(object sender, EventArgs e)
        {
            _album = new ChristmasTreeDecorator(_album);
            _album.Draw();
        }

        private void btnAddSantaClaus_Click(object sender, EventArgs e)
        {
            _album = new SantaClausDecorator(_album);
            _album.Draw();
        }

        private void pbxMain_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.X.ToString() + " " + e.Y.ToString());
        }

        private void btnAddStars_Click(object sender, EventArgs e)
        {
            _album = new StarDecorator(_album);
            _album.Draw();
        }
    }
}
