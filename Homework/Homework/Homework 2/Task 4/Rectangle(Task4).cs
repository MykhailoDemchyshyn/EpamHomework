using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Homework_2.Task_4
{
    class Rectangle_Task4_:Figure_Task4_
    {
        public Rectangle_Task4_() : base()
        {
        }
        public Rectangle_Task4_(int x, int y) : base(x, y)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine($"X={X}; Y={Y}");
        }
    }
}
