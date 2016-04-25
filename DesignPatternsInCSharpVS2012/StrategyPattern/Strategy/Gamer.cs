using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StrategyPattern.Strategy
{
    public class Gamer
    {
        private Label _bulletsLabel;

        public Gamer(Label bulletsLabel)
        {
            _bulletsLabel = bulletsLabel;
        }

        private IGun _gun;

        public IGun Gun
        {
            get { return _gun; }
            set { _gun = value; RefreshGunInfo();  }
        }

        private void RefreshGunInfo()
        {
            _gun.Draw();
            ShowBulletsInfo();
        }

        private void ShowBulletsInfo()
        {
            _bulletsLabel.Text = "Bullets: " + _gun.Bullets.ToString();
        }

        public void Fire()
        {
            _gun.Fire();
            
            ShowBulletsInfo();
        }
    }
}
