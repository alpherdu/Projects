using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace InterpreterPattern
{
    public class Circle
    { 
        private Graphics _graphics;

        public Circle(Graphics graphics)
        {
            _graphics = graphics;
        }

        public void Draw(int x, int y, int radius)
        {
            _graphics.FillEllipse(Brushes.GreenYellow, x, y, radius, radius);
        }
    }
}
