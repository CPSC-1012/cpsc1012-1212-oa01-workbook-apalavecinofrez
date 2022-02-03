/* purpose: Give the user choices of converting inches to centimeters, Yards to Meters, or Miles to Kilometers.
 *          Then using their choice, taking an input and performing the conversion they chose on it and displaying to user.
 *          
 * input:   user choice for conversion type, value to be converted
 * 
 * output:  converted value
 * 
 * written by: Alan Esteban Palavecino Frez
 * 
 * Written for: Sam Wu
 * 
 * section A01
 */

using System;

namespace CPSC1012_Lab02_AlanPalavecino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            int userInput;
            double input,
                output;

            //application menu and prompting for user input
            Console.WriteLine("Please choose from the following menu");
            Console.WriteLine("1)Inches to Centimeters");
            Console.WriteLine("2)Yards to Meters");
            Console.WriteLine("3)Miles to Kilometers");
            Console.WriteLine("4)Exit");
            Console.Write("Selecton ? ");
            userInput = int.Parse(Console.ReadLine());

            //switch case using user input to perform the action of their choice
            switch(userInput)
            {
                case 1: //inches to centimeters
                    //asks for input and stores it
                    Console.WriteLine("Please enter value in inches: ");
                    input = double.Parse(Console.ReadLine());

                    output = Math.Round(input * 2.54, 2); //conversion formula for inch to cm rounded to 2 decimal places

                    //prints the input and output of the conversion rounded to 2 decimal places
                    Console.WriteLine($"The value of {input.ToString("F2")} inches is {output.ToString("F2")} cm");
                    break;

                case 2: //yards to meters
                    //asks for input and stores it
                    Console.WriteLine("Please enter value in yards: ");
                    input = double.Parse(Console.ReadLine());

                    output = Math.Round(input * 0.9144, 2); //conversion formula for yards to meters rounded to 2 decimal places

                    //prints the input and output of the conversion rounded to 2 decimal places
                    Console.WriteLine($"The value of {input.ToString("F2")} yards is {output.ToString("F2")} meters");
                    break;

                case 3: //miles to kilometers
                    //asks for input and stores it
                    Console.WriteLine("Please enter value in miles: ");
                    input = double.Parse(Console.ReadLine());

                    output = Math.Round(input * 1.609344, 2); //conversion formula for miles to kilometers rounded to 2 decimal places

                    //prints the input and output of the conversion rounded to 2 decimal places
                    Console.WriteLine($"The value of {input.ToString("F2")} miles is {output.ToString("F2")} km");
                    break;

                case 4: //exit
                    //displays exit message
                    Console.WriteLine("Exit, Good Bye...");
                    break;

                default: //invalid input
                    //displays invalid input and exits
                    Console.WriteLine("INVALID Selection, Good Bye...");
                    break;

            }
        }
    }
}
