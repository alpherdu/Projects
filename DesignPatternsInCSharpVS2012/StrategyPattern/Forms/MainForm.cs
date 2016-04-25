using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StrategyPattern.Strategy;

namespace StrategyPattern
{
    public partial class MainForm : Form
    {
        private Gamer _gamer;
        private IList<IGun> _gunList = new List<IGun>();

        private int _index;

        public MainForm()
        {
            InitializeComponent();

            _gunList.Add(new PistolGun(GunBox, BulletBox));
            _gunList.Add(new GrenadeLauncherGun(GunBox, BulletBox));

            _gamer = new Gamer(BulletsLabel);
            _gamer.Gun = _gunList[_index = 0];
        }

        private void ChangeGun_Click(object sender, EventArgs e)
        {
            _index++;

            if (_index >= _gunList.Count)
                _index = 0;

            _gamer.Gun = _gunList[_index];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _gamer.Fire();
        }
    }
}
