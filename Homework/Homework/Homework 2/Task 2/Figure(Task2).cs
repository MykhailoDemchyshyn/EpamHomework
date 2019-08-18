using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Homework_2.Task_2
{
    abstract class Figure_Task2_
    {
        public readonly int X;
        public readonly int Y;
        public Figure_Task2_()
        {
            X = 0;
            Y = 0;
        }
        public Figure_Task2_(int x,int y)
        {
            X = x;
            Y = y;
        }
        public abstract void Draw();
    }
}
