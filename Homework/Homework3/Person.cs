using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PhoneNumbers { get; set; }
        public Person(string name, int age, IEnumerable<string> numbers)
        {
            Name = name;
            Age = age;
            PhoneNumbers = numbers;
        }
        public void Print()
        {
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Age = {Age}");
            Console.WriteLine();
        }
        public void PrintNumbers()
        {
            Console.WriteLine(Name);
            foreach(string i in PhoneNumbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
