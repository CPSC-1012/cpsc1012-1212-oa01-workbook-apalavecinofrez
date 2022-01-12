/*  purpose:    compute the total price of a sales item using the user inputted price and a const tax (provincial tax)
 * 
 *  inputs:     price in dollars and cents
 * 
 *  Outputs:    price, tax, and total price of product
 *  
 *  Algorithm:  Step 1) Prompt and read in the sale price
 *              Step 2) Calculate the sale total using the formula:
 *                          total = price + tax
 *                      where tax = price * 0.05
 *              Step 3) Display the computed sale total
 *              
 *  Last modified:  2022-01-12
 * 
 * */
using System;

namespace saleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables to store for the price, tax, and total
            double price,
                tax,
                total;
            //declare the constant provincialGst
            const double provincialGst = 0.05;

            //prompt user for price
            Console.WriteLine("Enter the price of the item: ");

            //convert string from input to double
            price = double.Parse(Console.ReadLine());

            //calculate tax for the given price and the total price
            tax = price*provincialGst;
            total = price + tax;

            // Write to the screen the price, tax, and total
            Console.WriteLine($"the price of the item is {price:C}");
            Console.WriteLine($"the tax is {tax:C}");
            Console.WriteLine($"the total is {total:C}");
        }
    }
}
