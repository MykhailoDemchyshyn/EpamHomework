using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Homework_1
{
    class Circle_Task3_
    {
        private const double pi = 3.14159265358979;
        public Circle_Task3_()
        {
        }
        public double Length(double radius)
        {
            return 2 * pi * radius;
        }
        public double Area(double radius)
        {
            return pi * radius * radius;
        }
    }
}
