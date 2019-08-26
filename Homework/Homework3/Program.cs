using System;
using System.Collections.Generic;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> ListPersons = new List<Person>
            {
                new Person ( "Ashot", 54,  new List<string>{"0671386247","0971386248","0961386249" }),
                new Person ( "Mahmud", 19,  new List<string>{"0771646247","0671334648","0661381239","0986423578" }),
                new Person ( "Ali", 27,  new List<string>{"0987654321","0986423578","0465821239" }),
                new Person ( "Abbulla", 77,  new List<string>{"0771646247","0671334648","0661381239","0671386247","0963852741" }),
                new Person ( "Omar", 15,  new List<string>{ "0661381239", "0961386249", "0987654321", "0173996247" }),
                new Person ( "Muhammed", 35,  new List<string>{ "0465678921", "0273468523", "0756487316" })

            };
            string n;
            while(true)
            {
                Console.WriteLine("Task 1 - enter 1");
                Console.WriteLine("Task 2 - enter 2");
                Console.WriteLine("Task 3 - enter 3");
                n = Console.ReadLine();
                if (n == "1")
                {
                    for (int i = 0; i < ListPersons.Count; i++)
                    {
                        ListPersons[i].Print();
                    }
                }
                if (n == "2")
                {
                    List<Person> lst = new List<Person>
                    {
                        new Person ( "Mustafa", 43,  new List<string>{"0173996247","0346734648","0123456789" }),
                        new Person ( "Nursultan", 36,  new List<string>{"0771647946","0671645648","0661324239" })
                    };
                    ListPersons.AddRange(lst);
                    for (int i = 0; i < ListPersons.Count; i++)
                    {
                        ListPersons[i].PrintNumbers();
                    }
                }
                if(n=="3")
                {
                    Console.WriteLine("enter n");
                    int numb = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"before = {numb}");
                    List<string> arr = RandomStrings(numb);
                    Console.WriteLine($"after = {arr.Count}");
                    arr.Sort();
                    arr.Reverse();
                    int NumberPage=0;
                    try
                    {
                        Console.WriteLine($"enter number page [1-{arr.Count}] = ");
                        NumberPage = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        break;
                    }
                    finally
                    {
                        DisplayPage(NumberPage, arr);
                    }
                    
                    
                }
                
            }
        }
        public static List<string> RandomStrings(int numb)
        {
           
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            List<string> arr = new List<string> { };
            Random rand = new Random();
            for (int i = 0; i < numb; i++)
            {
                char[] mas = new char[4];
                for (int j = 0; j < mas.Length; j++)
                {
                    mas[j] = chars[rand.Next(chars.Length)];
                }
                arr.Add(new string(mas));
            }
            for (int i = 0; i < arr.Count; i++)
            {
                string str = arr[i];
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (str == arr[j])
                    {
                        arr.RemoveAt(j);
                        j--;
                    }
                }
            }
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i][0] == 'Z')
                {
                    arr.RemoveAt(i);
                    i--;
                }
            }
            
            return arr;
        }
        public static void DisplayPage(int NumberPage, List<string> arr)
        {
            Console.WriteLine();
            Console.WriteLine($"{NumberPage} = {arr[NumberPage-1]}");
            Console.WriteLine();
        }
    }
}
