using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Homework_2.Task_3
{
    class Square_Task3_:Figure_Task3_
    {
        public Square_Task3_() : base()
        {
        }
        public Square_Task3_(int x, int y) : base(x, y)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("Square");
            Console.WriteLine($"X={X}; Y={Y}");
        }
    }
}
