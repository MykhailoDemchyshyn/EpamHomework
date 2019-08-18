using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Homework_2.Task_2
{
    class Rectangle_Task2_:Figure_Task2_
    {
        public Rectangle_Task2_() : base()
        {
        }
        public Rectangle_Task2_(int x,int y):base(x,y)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine($"X={X}; Y={Y}");
        }
    }
}
