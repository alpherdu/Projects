using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DecoratorPattern.Classes
{
public class Album
{
    public Graphics Graphics
    {
        get;
        set;
    }

    public Album()
    {
    }

    public Album(Graphics graphics)
    {
        Graphics = graphics;
    }

    public virtual void Draw()
    {
        Graphics.Clear(Color.White);
    }
} 
}
