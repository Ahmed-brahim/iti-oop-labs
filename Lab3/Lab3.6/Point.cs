using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap3._6
{
    public class Point
    {
        public int X;
        public int Y;
        public Point()
        {}
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Print()
        {
            Console.WriteLine($"Your point is ({X}, {Y})");
        }
    }
}
