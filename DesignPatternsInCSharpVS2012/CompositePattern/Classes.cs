using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clock;

namespace CompositePattern
{
    interface IComponent
    {
        void Add(IComponent notifier);
        void SetTime(DateTime time);
    }

    class Office : IComponent
    {
        private IList<IComponent> _list = new List<IComponent>();

        public void Add(IComponent notifier)
        {
            _list.Add(notifier);
        }

        public void SetTime(DateTime time)
        {
            foreach (IComponent n in _list)
                n.SetTime(time);
        }
    }

    class Clock : IComponent
    {
        public ClockControl ClockControl;

        public void Add(IComponent notifier)
        {
            throw new ApplicationException("You cannot add IClock!");
        }

        public void SetTime(DateTime time)
        {
            ClockControl.CurrentTime = time;
        }
    }
}
