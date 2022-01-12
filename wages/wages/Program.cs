using System;

namespace Wages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double regularWages; // The calculated regular wages

            Console.Write("enter basePay: ");
            double basePay = double.Parse(Console.ReadLine()); // The base pay rate

            Console.Write("enter regular hours: ");
            double regularHours = double.Parse(Console.ReadLine()); ; // The hours worked less overtime.
            double overtimeWages; // Overtime wages

            Console.Write("enter overtime pay: ");
            double overtimePay = double.Parse(Console.ReadLine()); // Overtime pay rate

            Console.Write("enter overtime hours: ");
            double overtimeHours = double.Parse(Console.ReadLine()); // Overtime hours worked

            double totalWages; // Total wages
            regularWages = basePay * regularHours;
            overtimeWages = overtimePay * overtimeHours;
            totalWages = regularWages + overtimeWages;
            Console.WriteLine("Wages for this week are $" + totalWages);
        }
    }
}
