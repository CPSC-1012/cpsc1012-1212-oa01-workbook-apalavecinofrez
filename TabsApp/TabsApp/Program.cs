using System;

namespace TabsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is a test of escape sequence code with tabs and newlines
            Console.Write("These are our top sellers: \n");
            Console.Write("\tItem 1\n\tItem 2\n\tItem 3\n");


            //this is better code because it is more readable and the output is identical
            Console.WriteLine("These are our top sellers:");
            Console.WriteLine("\tItem 1");
            Console.WriteLine("\tItem 2");
            Console.WriteLine("\tItem 3");
        }
    }
}
