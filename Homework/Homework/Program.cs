using Homework.Homework_1;
using Homework.Homework_2.Task_1;
using Homework.Homework_2.Task_2;
using Homework.Homework_2.Task_3;
using Homework.Homework_2.Task_4;
using System;
using System.Drawing;

namespace Homework
{
    class Program
    {
        public static void DrawAll(params IDrawable[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Draw();
            }
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Homework 1 - enter 1");
                Console.WriteLine("Homework 2 - enter 2");
                string n = Console.ReadLine();
                if(n=="1")
                {
                    Console.WriteLine("Task 1 - enter 1");
                    Console.WriteLine("Task 2 - enter 2");
                    Console.WriteLine("Task 3 - enter 3");
                    Console.WriteLine("Task 4 - enter 4");
                    Console.WriteLine("Task 5 - enter 5");
                    n = Console.ReadLine();
                    #region if n==1
                    if (n=="1")
                    {
                        Point LeftUp = new Point(); Point RightDown = new Point();
                        while (true)
                        {
                            
                            Console.Write("LeftUp X="); LeftUp.X =Convert.ToInt32(Console.ReadLine());
                            Console.Write("LeftUp Y="); LeftUp.Y = Convert.ToInt32(Console.ReadLine());
                            Console.Write("RightDown X="); RightDown.X = Convert.ToInt32(Console.ReadLine());
                            Console.Write("RightDown Y="); RightDown.Y = Convert.ToInt32(Console.ReadLine());
                            if (LeftUp.X < RightDown.X && LeftUp.Y > RightDown.Y) { break; }
                            else { Console.WriteLine("error"); }
                        }
                        Rectangle_Task_1_ rec1 = new Rectangle_Task_1_(LeftUp, RightDown);
                        Console.WriteLine($"area={rec1.Area()}, perimeter={rec1.Perimeter()}");
                    }
                    #endregion
                    #region if n==2
                    else if (n=="2")
                    {
                        Point LeftUp = new Point(); Point RightDown = new Point();
                        while (true)
                        {

                            Console.Write("LeftUp X="); LeftUp.X = Convert.ToInt32(Console.ReadLine());
                            Console.Write("LeftUp Y="); LeftUp.Y = Convert.ToInt32(Console.ReadLine());
                            Console.Write("RightDown X="); RightDown.X = Convert.ToInt32(Console.ReadLine());
                            Console.Write("RightDown Y="); RightDown.Y = Convert.ToInt32(Console.ReadLine());
                            if (LeftUp.X < RightDown.X && LeftUp.Y > RightDown.Y) { break; }
                            else { Console.WriteLine("error"); }
                        }
                        Rectangle_Task_2_ rec1 = new Rectangle_Task_2_(LeftUp, RightDown);
                        Console.WriteLine($"area={rec1.Area()}, perimeter={rec1.Perimeter()}");
                    }
                    #endregion
                    #region if n==3
                    else if (n == "3")
                    {
                        double radius;
                        while (true)
                        {
                            Console.WriteLine("enter radius="); radius =Convert.ToDouble(Console.ReadLine());
                            if (radius > 0) { break; }
                        }
                        Circle_Task3_ cir = new Circle_Task3_();
                        Console.WriteLine($"area={cir.Area(radius)}; length={cir.Length(radius)}");

                    }
                    #endregion
                    #region if n==4
                    else if (n == "4")
                    {
                        Point LeftUp = new Point(); Point RightDown = new Point();
                        while (true)
                        {

                            Console.Write("LeftUp X="); LeftUp.X = Convert.ToInt32(Console.ReadLine());
                            Console.Write("LeftUp Y="); LeftUp.Y = Convert.ToInt32(Console.ReadLine());
                            Console.Write("RightDown X="); RightDown.X = Convert.ToInt32(Console.ReadLine());
                            Console.Write("RightDown Y="); RightDown.Y = Convert.ToInt32(Console.ReadLine());
                            if (LeftUp.X < RightDown.X && LeftUp.Y > RightDown.Y) { break; }
                            else { Console.WriteLine("error"); }
                        }
                        Console.WriteLine($"area={Rectangle_Task_4_.Area(LeftUp,RightDown)}, perimeter={Rectangle_Task_4_.Perimeter(LeftUp,RightDown)}");

                        double radius;
                        while (true)
                        {
                            Console.WriteLine("enter radius="); radius = Convert.ToDouble(Console.ReadLine());
                            if (radius > 0) { break; }
                        }
                        Console.WriteLine($"area={Circle_Task4_.Area(radius)}; length={Circle_Task4_.Length(radius)}");

                    }
                    #endregion
                    #region if n==5
                    else if (n == "5")
                    {
                        Console.Write("enter real part of numb 1=");
                        double real = Convert.ToDouble(Console.ReadLine());
                        Console.Write("enter imaginary part of numb 1=");
                        double imaginary = Convert.ToDouble(Console.ReadLine());
                        ComplexNumber_Task5_ numb1 = new ComplexNumber_Task5_(real, imaginary);
                        Console.Write("enter real part of numb 2=");
                        real = Convert.ToDouble(Console.ReadLine());
                        Console.Write("enter imaginary part of numb 2=");
                        imaginary = Convert.ToDouble(Console.ReadLine());
                        ComplexNumber_Task5_ numb2 = new ComplexNumber_Task5_(real, imaginary);
                        ComplexNumber_Task5_ Product = numb1 * numb2;
                        ComplexNumber_Task5_ Quotient = numb1 / numb2;
                        Console.WriteLine($"numb1*numb2 real={Product.Real}; imaginamry={Product.Imaginary}");
                        Console.WriteLine($"numb1 / numb2 real=={ Quotient.Real}; imaginary={Quotient.Imaginary}");
                    }
                    #endregion
                }
                else if(n=="2")
                {
                    Console.WriteLine("Task 1 - enter 1");
                    Console.WriteLine("Task 2 - enter 2");
                    Console.WriteLine("Task 3 - enter 3");
                    Console.WriteLine("Task 4 - enter 4");
                    n = Console.ReadLine();
                    #region if n==1
                    if (n=="1")
                    {
                        Rectangle_Task1_ rect = new Rectangle_Task1_();
                        Square_Task1_ squa = new Square_Task1_();
                        rect.Draw();
                        squa.Draw();
                    }
                    #endregion
                    #region if n==2
                    else if (n=="2")
                    {
                        Console.WriteLine("enter rectangle X="); int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter rectangle y="); int y = Convert.ToInt32(Console.ReadLine());
                        Rectangle_Task2_ rect = new Rectangle_Task2_(x,y);
                        Console.WriteLine("enter square X="); x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter square y="); y = Convert.ToInt32(Console.ReadLine());
                        Square_Task2_ squa = new Square_Task2_(x,y);
                        rect.Draw();
                        squa.Draw();
                    }
                    #endregion
                    #region if n==3
                    else if (n=="3")
                    {
                        Console.WriteLine("enter rectangle X="); int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter rectangle y="); int y = Convert.ToInt32(Console.ReadLine());
                        Rectangle_Task3_ rect = new Rectangle_Task3_(x, y);
                        Console.WriteLine("enter square X="); x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter square y="); y = Convert.ToInt32(Console.ReadLine());
                        Square_Task3_ squa = new Square_Task3_(x, y);
                        Console.WriteLine("enter figure X="); x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter figure y="); y = Convert.ToInt32(Console.ReadLine());
                        Figure_Task3_ figu = new Figure_Task3_ (x, y);
                        rect.Draw();
                        squa.Draw();
                        figu.Draw();

                    }
                    #endregion
                    #region if n==4
                    else if (n=="4")
                    {
                        Rectangle_Task4_ rec = new Rectangle_Task4_();
                        Square_Task4_ squ = new Square_Task4_();
                        Figure_Task4_ fig = new Figure_Task4_();
                        Figure_Task4_[] arr = new Figure_Task4_[] { fig, rec, squ };
                        DrawAll(arr);
                    }
                    #endregion
                }
            }
            Console.ReadKey();
        }
    }
}
