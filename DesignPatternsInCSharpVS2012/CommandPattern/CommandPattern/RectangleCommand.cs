using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CommandPattern.Classes;
using System.Collections;

namespace CommandPattern.CommandPattern
{
    public class RectangleCommand : ICommand
    {
        private Point _point;
        private Bitmap _bitmap;
        private Graphics _graphics;
        private Color _color;

        public RectangleCommand(Bitmap bitmap, Color color, int x, int y)
        {
            _bitmap = bitmap;
            _graphics = Graphics.FromImage(_bitmap);
            _color = color;
            _point = new Point(x, y);
        }

        public void Do()
        {
            // Save the current pixel colors for a future UNDO perform
            SaveCurrentPixels();

            // Do the drawing
            _graphics.FillRectangle(new SolidBrush(_color), new Rectangle(_point.X, _point.Y, Width, Height));
        }

        private const int Width = 100;
        private const int Height = 50;

        private IList<Color> _colors = new List<Color>();

        private void SaveCurrentPixels()
        {
            for (int i = _point.X; i < _point.X + Width; i++)
                for (int j = _point.Y; j < _point.Y + Height; j++)
                    _colors.Add(_bitmap.GetPixel(i, j));
        }

        /// <summary>
        /// Perform Undo by restoring back the pixels to previous colors
        /// </summary>
        public void Undo()
        {
            int ix = 0;
            for (int i = _point.X; i < _point.X + Width; i++)
                for (int j = _point.Y; j < _point.Y + Height; j++)
                    _bitmap.SetPixel(i, j, _colors[ix++]);

        }
    }
}
