using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractFactory
{
    public interface IControlFactory
    {
        IPanel CreatePanel();
        IButton CreateButton();
    }

    public interface IPanel
    {
        Color BackColor { get; set; }
    }

    public interface IButton
    {
        Color BackColor { get; set; }
    }

    public class YellowButton : Button, IButton
    {
        public YellowButton()
        {
            BackColor = Color.Yellow;
        }

        public override Color BackColor
        {
            get;
            set;
        }
    }

    public class YellowPanel : Panel, IPanel
    {
        public YellowPanel()
        {
            BackColor = Color.Yellow;
        }

        public override Color BackColor
        {
            get;
            set;
        }
    }

    public class YellowControlFactory : IControlFactory
    {
        public IPanel CreatePanel()
        {
            return new YellowPanel(); 
        }

        public IButton CreateButton()
        {
            return new YellowButton();
        }
    }

}
