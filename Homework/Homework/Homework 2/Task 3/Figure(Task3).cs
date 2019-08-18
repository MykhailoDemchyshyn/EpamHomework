using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Homework_2.Task_3
{
    class Figure_Task3_
    {
        public readonly int X;
        public readonly int Y;
        public Figure_Task3_()
        {
            X = 0;
            Y = 0;
        }
        public Figure_Task3_(int x, int y)
        {
            X = x;
            Y = y;
        }
        public virtual void Draw()
        {
            Console.WriteLine("Figure");
            Console.WriteLine($"X={X}; Y={Y}");
        }
    }
}
