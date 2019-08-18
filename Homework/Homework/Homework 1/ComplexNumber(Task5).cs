using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Homework_1
{
    class ComplexNumber_Task5_
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public ComplexNumber_Task5_()
        {
            Real = 0;
            Imaginary = 0;
        }
        public ComplexNumber_Task5_(double _Real, double _Imagionary)
        {
            Real = _Real;
            Imaginary = _Imagionary;
        }
        public static ComplexNumber_Task5_ operator *(ComplexNumber_Task5_ numb1, ComplexNumber_Task5_ numb2)
        {
            ComplexNumber_Task5_ Product = new ComplexNumber_Task5_();
            Product.Real = numb1.Real * numb2.Real;
            Product.Imaginary = numb1.Imaginary * numb2.Imaginary;
            return Product;
        }
        public static ComplexNumber_Task5_ operator /(ComplexNumber_Task5_ numb1, ComplexNumber_Task5_ numb2)
        {
            ComplexNumber_Task5_ Quotient = new ComplexNumber_Task5_();
            Quotient.Real = numb1.Real / numb2.Real;
            Quotient.Imaginary = numb1.Imaginary / numb2.Imaginary;
            return Quotient;
        }
    }
}
