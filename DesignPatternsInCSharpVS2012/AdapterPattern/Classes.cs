using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    public class Calculator
    {
        public int GetArea(Rectangle rectangle)
        {
            int area = rectangle.Width * rectangle.Height;

            return area;
        }
    }

    public class Rectangle
    {
        public int Width;
        public int Height;
    }

    public class Square
    {
        public int Size;
    }

    public class CalculatorAdapter
    {
        public int GetArea(Square square)
        {
            Calculator calculator = new Calculator();
            
            Rectangle rectangle = new Rectangle();
            rectangle.Width = rectangle.Height = square.Size;

            int area = calculator.GetArea(rectangle);

            return area;
        } 
    }
}
