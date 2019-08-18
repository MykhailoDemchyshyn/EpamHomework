using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Homework_2.Task_4
{

    class Figure_Task4_:IDrawable
    {
        public readonly int X;
        public readonly int Y;
        public Figure_Task4_()
        {
            X = 0;
            Y = 0;
        }
        public Figure_Task4_(int x, int y)
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
