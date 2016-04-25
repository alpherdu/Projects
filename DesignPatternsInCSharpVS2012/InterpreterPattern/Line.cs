using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace InterpreterPattern
{
    public class Line
    {
        private Graphics _graphics;

        public Line(Graphics graphics)
        {
            _graphics = graphics;
        }

        public void Draw(int x, int y, int width, int height)
        {
            _graphics.DrawLine(Pens.Black, new Point(x, y), new Point(x + width, y + height));
        }
    }
}
