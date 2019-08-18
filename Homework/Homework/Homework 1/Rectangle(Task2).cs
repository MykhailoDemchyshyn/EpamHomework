using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Homework.Homework_1
{
    class Rectangle_Task2_
    {
        public Point LeftUp { get; set; }
        public Point RightDown { get; set; }
        public Rectangle_Task2_(Point _LeftUp, Point _RightDown)
        {
            LeftUp = _LeftUp;
            RightDown = _RightDown;
        }
        public int Perimeter()
        {
            return (RightDown.X - LeftUp.X) * 2 + (LeftUp.Y - RightDown.Y) * 2;
        }
        public int Area()
        {
            return (RightDown.X - LeftUp.X) * (LeftUp.Y - RightDown.Y);
        }
    }
}
