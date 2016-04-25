using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern
{
    public class Memento
    {
        public List<Line> _state;

        public List<Line> State
        {
            get { return _state; }
            set 
            {
                _state = new List<Line>();
                foreach(Line line in value)
                    _state.Add(line);
            }
        }
    }
}
