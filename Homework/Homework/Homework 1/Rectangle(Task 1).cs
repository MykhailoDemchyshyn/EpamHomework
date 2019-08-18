using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Homework.Homework_1
{
    class Rectangle_Task_1_
    {
        private Point leftUp;
        private Point rightDown;
        public Point LeftUp
        {
            get
            {
                return leftUp;
            }
            set
            {
                leftUp = value;
            }
        }
        public Point RightDown
        {
            get
            {
                return rightDown;
            }
            set
            {
                rightDown = value;
            }
        }
        public Rectangle_Task_1_(Point _LeftUp, Point _RightDown)
        {
            leftUp = _LeftUp;
            rightDown = _RightDown;
        }
        public int Perimeter()
        {
            return (rightDown.X - leftUp.X) * 2 + (leftUp.Y - rightDown.Y) * 2;
        }
        public int Area()
        {
            return (rightDown.X - leftUp.X) * (leftUp.Y - rightDown.Y);
        }
    }
}
