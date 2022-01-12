using System;

namespace IntegerVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int checking;
            long days;

            checking = -20;
            days = 189000;

            //string interpolation
            Console.WriteLine($"Our account balance is {checking:C}"); //:C formats a variable to a currency with 2 decimal places and dollar sign
            Console.WriteLine($"About {days} days ago Columbus stood on this spot.");
        }
    }
}
