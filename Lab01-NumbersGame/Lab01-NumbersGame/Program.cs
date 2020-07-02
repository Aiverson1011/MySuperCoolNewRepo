using System;
using System.Dynamic;

namespace Lab01_NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyMethod();
        }

        public static void MyMethod()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); ;
            Console.WriteLine($"Hello {name}");
            
        }
    }
}
