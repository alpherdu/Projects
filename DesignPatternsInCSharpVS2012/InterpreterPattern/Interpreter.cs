using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace InterpreterPattern
{
    public class Interpreter
    {
        public void Execute(string commands, Graphics graphics)
        {
            graphics.Clear(Color.FromArgb(237, 253, 200));

            int i = 0;

            foreach (string rawCommand in commands.Split(';'))
            {
                string command = rawCommand.Replace(Environment.NewLine, string.Empty).Trim();

                if (command.StartsWith("line"))
                {
                    i = 0;
                    int x = 0, y = 0, width = 0, height = 0;

                    foreach (string argument in command.Split(','))
                    {
                        if (i == 1)
                            x = int.Parse(argument);

                        else if (i == 2)
                            y = int.Parse(argument);

                        else if (i == 3)
                            width = int.Parse(argument);

                        else if (i == 4)
                            height = int.Parse(argument);

                        i++;
                    }

                    new Line(graphics).Draw(x, y, width, height);
                }
                else if (command.StartsWith("circle"))
                {
                    i = 0;
                    int x = 0, y = 0, radius = 0;

                    foreach (string argument in command.Split(','))
                    {
                        if (i == 1)
                            x = int.Parse(argument);

                        else if (i == 2)
                            y = int.Parse(argument);

                        else if (i == 3)
                            radius = int.Parse(argument);

                        i++;
                    }

                    new Circle(graphics).Draw(x, y, radius);
                }
            }
        }
    }
}
