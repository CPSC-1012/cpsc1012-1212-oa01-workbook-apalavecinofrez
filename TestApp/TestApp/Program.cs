using System;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter some int value: ");
            int value = int.Parse(Console.ReadLine());

            Console.WriteLine("value is: " + value);
        }
    }
}
