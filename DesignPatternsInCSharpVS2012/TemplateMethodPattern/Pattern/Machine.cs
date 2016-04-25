using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace TemplateMethodPattern
{
public class Machine
{
    public void Execute()
    {
        Start();
        Produce();
        Stop();
    }

    protected virtual void Start()
    {
        Trace.WriteLine("Machine.Starting..");
    }

    protected virtual void Produce()
    {
        Trace.WriteLine("Machine.Producing.. (But I don't know what to produce)");
    }

    protected virtual void Stop()
    {
        Trace.WriteLine("Machine.Stopping..");
        Trace.WriteLine(string.Empty);
    }

    public override string ToString()
    {
        return GetType().Name;
    }
}
}
