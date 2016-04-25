using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.Classes
{
    public interface ICommand
    {
        void Do();
        void Undo();
    }
}
