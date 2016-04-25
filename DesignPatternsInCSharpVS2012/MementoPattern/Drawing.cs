using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MementoPattern
{
    /// Class having Line drawing functionalities
    public class Drawing
    {
        private Graphics _graphics;

        public Drawing(Panel panel)
        {
            _graphics = panel.CreateGraphics();
        }

        /// Internal State
        private List<Line> _list = new List<Line>();

        public void AddLine(Point start, Point end)
        {
            _list.Add(new Line() { Start = start, End = end });

            DrawLines();
        }

        private void DrawLines()
        {
            _graphics.Clear(Color.Navy);

            foreach(Line line in _list)
                _graphics.DrawLine(Pens.Yellow, line.Start, line.End);
        }

        /// Create snapshot of current State
        public Memento CreateMemento()
        {
            return new Memento() { State = _list };
        }

        /// Restore State to given Memento
        public void RestoreMemento(Memento memento)
        {
            _list = memento.State as List<Line>;

            DrawLines();
        }
    }

    // Class holding Line information
    public class Line
    {
        public Point Start, End;
    }
}
