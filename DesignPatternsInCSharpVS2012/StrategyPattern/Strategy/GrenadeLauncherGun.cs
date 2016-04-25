using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace StrategyPattern.Strategy
{
    public class GrenadeLauncherGun : IGun
    {
        public GrenadeLauncherGun(PictureBox gunBox, PictureBox bulletBox)
        {
            _gunBox = gunBox;
            _bulletBox = bulletBox;
        }

        public void Fire()
        {
            if (_bullets == 0)
            {
                MessageBox.Show("No Ammo!");
                return;
            }

            _bulletBox.Image = Images.Grenade;
            _bulletBox.Left = _gunBox.Left + _gunBox.Width + 5;
            _bulletBox.Top = _gunBox.Top + 60;
            _bulletBox.Show();

            for (int i = 1; i <= 18; i++)
            {
                Thread.Sleep(50);
                Application.DoEvents();
                _bulletBox.Left += _bulletBox.Width / 2;
            }

            _bullets--;

            _bulletBox.Hide();
        }

        public void Draw()
        {
            _gunBox.Image = Images.GrenadeLauncher;

            _gunBox.Width = _gunBox.Image.Width;
            _gunBox.Height = _gunBox.Image.Height;
        }

        public int _bullets = 20;

        public int Bullets
        {
            get
            {
                return _bullets;
            }
            set
            {
                _bullets = value;
            }
        }

        private PictureBox _gunBox;
        private PictureBox _bulletBox;

        public PictureBox GunBox
        {
            get
            {
                return _gunBox;
            }
            set
            {
                _gunBox = value;
            }
        }

        public PictureBox BulletBox
        {
            get
            {
                return _bulletBox;
            }
            set
            {
                _bulletBox = value;
            }
        }
    }
}
