using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Homework_1
{
    static class Circle_Task4_
    {
        private static double pi = 3.14159265358979;
        static public double Length(double radius)
        {
            return 2 * pi * radius;
        }
        static public double Area(double radius)
        {
            return pi * radius * radius;
        }
    }
}
