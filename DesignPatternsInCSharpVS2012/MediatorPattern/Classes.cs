using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    public class FlightMediator
    {
        private Engine _engine;
        private Aviation _aviation;
        private Wheels _wheels;
        private Cockpit _cockpit;

        public FlightMediator(Engine engine, Aviation aviation, Wheels wheels, Cockpit cockpit)
        {
            _engine = engine;
            _aviation = aviation;
            _wheels = wheels;
            _cockpit = cockpit;
        }

        public bool IsReady()
        {
            return _engine.IsReady() && _aviation.IsReady() && _wheels.IsReady() && _cockpit.IsReady();
        }
    }

    public class Engine
    {
        public void Start()
        {
        }

        public bool IsReady()
        {
            return true;
        }
    }

    public class Aviation
    {
        private int _FuelLevel = 1000;

        public bool IsReady()
        {
            return _FuelLevel > 5000; // Returns false as not enough fuel
        }
    }

    public class Wheels
    {
        public bool IsReady()
        {
            return true;
        }
    }

    public class Cockpit
    {
        public bool IsReady()
        {
            return true;
        }
    }
}
