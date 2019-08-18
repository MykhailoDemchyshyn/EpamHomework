using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Homework.Homework_1
{
    static class Rectangle_Task_4_
    {
        public static int Perimeter(Point LeftUp, Point RightDown)
        {
            return (RightDown.X - LeftUp.X) * 2 + (LeftUp.Y - RightDown.Y) * 2;
        }
        public static int Area(Point LeftUp, Point RightDown)
        {
            return (RightDown.X - LeftUp.X) * (LeftUp.Y - RightDown.Y);
        }
    }
}
