using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Homework_2.Task_2
{
    class Square_Task2_:Figure_Task2_
    {
        public Square_Task2_() : base()
        {
        }
        public Square_Task2_(int x, int y) : base(x, y)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("Square");
            Console.WriteLine($"X={X}; Y={Y}");
        }
    }
}
