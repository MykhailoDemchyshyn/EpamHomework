using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Homework_2.Task_3
{
    class Rectangle_Task3_:Figure_Task3_
    {
        public Rectangle_Task3_() : base()
        {
        }
        public Rectangle_Task3_(int x, int y) : base(x, y)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine($"X={X}; Y={Y}");
        }
    }
}
