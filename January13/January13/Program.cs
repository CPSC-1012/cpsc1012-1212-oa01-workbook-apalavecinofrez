using System;

namespace January13
{
    internal class Program
    {
        static void ExerciseOne()
        {
            String name;
            int age;
            double annualPay;

            //prompts user for name and saves that value in name variable then prints it to screen
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine(name);

            //prompts user for name and saves that value in name variable then prints it to screen
            Console.WriteLine("Enter your age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine(age);

            //prompts user for name and saves that value in name variable then prints it to screen
            Console.WriteLine("Enter your annual salary");
            annualPay = double.Parse(Console.ReadLine());
            Console.WriteLine(annualPay);

            //prints to screen all the user inputs in a descriptive sentence
            Console.WriteLine($"My name is {name}, my age is {age} and I hope to earn {annualPay:C} per year");
        }

        static void ExerciseTwo()
        {
            //declares variables for user inputted variables: radius and length, and for calculated variables: area, volume
            double radius,
                length,
                area,
                volume;
            //prompts user for input
            Console.WriteLine("Enter the radius and length of a cylinder");
            radius = double.Parse(Console.ReadLine());
            length = double.Parse(Console.ReadLine());

            //calculates area and volume using the user inputs for radius and length
            area = radius * radius * Math.PI;
            volume = area * length;

            //prints to screen the calculated area (rounded to 4 decimal places) and volume (rounded to 1 decimal place)
            Console.WriteLine($"The area is {Math.Round(area,4)}");
            Console.WriteLine($"The volume is {Math.Round(volume,1)}");
        }

        static void ExerciseThree()
        {
            //declares variables for length and area
            double length,
                area;

            //prompts user for input and stores it in length variable
            Console.WriteLine("Enter the length of the side:");
            length = double.Parse(Console.ReadLine());

            //computes the area of the hexagon
            area = (3 * Math.Sqrt(3) / 2) * Math.Pow(length, 2);

            //prints to screen the area previously calculated rounded to 4 decimal places
            Console.WriteLine($"The area of the hexagon is {Math.Round(area, 4)}");
        }

        static void ExerciseFour()
        {
            //declares the number and sum variables
            int number;
            int sum = 0;

            //prompts user for input and stores it in number variable
            Console.WriteLine("Enter a number between 0 and 1000: ");
            number = int.Parse(Console.ReadLine());

            //loops using modulus and integer division until it calculates the sum of all the digits in the number variable
            while (number >=1)
            {
                sum += number%10;
                number /= 10;
            }

            //prints to screen the sum variable
            Console.WriteLine($"The sum of the digits is {sum}");
        }

        static void ExerciseFive()
        {
            //declares the investAmount, annualInterest, years and futureValue variables
            double investAmount,
                annualInterest,
                monthlyInterest,
                futureValue;
            int years;

            //prompts user for input and saves it into the investAmount variable
            Console.WriteLine("Enter investment amount: ");
            investAmount = double.Parse(Console.ReadLine());

            //prompts user for input, converts it from percent to decimal and saves it into the annualInterest variable
            Console.WriteLine("Enter annual interest rate in percentage: ");
            annualInterest = double.Parse(Console.ReadLine());

            //prompts user for input and saves it into the years variable
            Console.Write("Enter value of years: ");
            years = int.Parse(Console.ReadLine());

            //calculates monthlyInterest
            monthlyInterest = annualInterest / 12 / 100;

            //calculates the futureValue
            futureValue = investAmount * Math.Pow((1 + monthlyInterest), (years * 12));

            //prints the calculated futureValue as a currency
            Console.WriteLine($"Future value is {futureValue:C}");
        }
        static void Main(string[] args)
        {
            //declares exercise variable
            int exercise;

            //prompts user for exercise they wanna test and saves the value to exercise variable
            Console.WriteLine("Which exercise do you wanna test: (1-5)");
            exercise = int.Parse(Console.ReadLine());

            //checks which exercise the user chose and runs it. If user chose none of them it gives a message
            switch(exercise)
            {
                case 1:
                    Program.ExerciseOne();
                    break;
                case 2:
                    Program.ExerciseTwo();
                    break;
                case 3:
                    Program.ExerciseThree();
                    break;
                case 4:
                    Program.ExerciseFour();
                    break;
                case 5:
                    Program.ExerciseFive();
                    break;
                default:
                    Console.WriteLine("sorry that wasn't an option");
                    break;
            }

        }
    }
}
