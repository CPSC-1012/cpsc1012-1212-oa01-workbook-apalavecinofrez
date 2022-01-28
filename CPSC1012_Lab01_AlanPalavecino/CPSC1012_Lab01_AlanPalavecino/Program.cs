/* purpose: compute the provincial tax, Federal tax, total tax, subtotal, and total price using the
 *          user inputted price, quantity, and constant variables of the provincial and federal tax
 *          rates
 *          
 * input:   price in dollars and cents, quantity
 * 
 * output:  subTotal, Provincial tax, Federal tax, total tax, total price
 * 
 * written by: Alan Esteban Palavecino Frez
 * 
 * Written for: Sam Wu
 * 
 * section A01
 */

using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declares the variables
            double retailPrice,
                subTotal,
                provincialTax,
                federalTax,
                totalTax,
                totalPrice;
            int quantity;
            const double ProvincialRate = 0.06; //based off of provided provincial tax rate
            const double FederalRate = 0.05; //based off of provided federal tax rate

            //Prompts user to enter the retail price of an item, and the quantity being purchased
            Console.WriteLine("************Welcome to the General Store************");
            Console.Write("Enter the retail price of the item: ");
            retailPrice = double.Parse(Console.ReadLine());

            Console.Write("Enter the quantity being purchased: ");
            quantity = int.Parse(Console.ReadLine());

            //calculates the subtotal, provincial tax, federal tax, tax total, and the total price
            subTotal = Math.Round(retailPrice * quantity, 2);
            provincialTax = Math.Round(subTotal * ProvincialRate, 2);
            federalTax = Math.Round(subTotal * FederalRate, 2);
            totalTax = Math.Round(provincialTax + federalTax, 2);
            totalPrice = Math.Round(subTotal + provincialTax + federalTax, 2);

            /* prints to screen a reciept view of the subTotal, provincialTax, federalTax, totalTax,
             * and totalPrice. these doubles are formatted to strings to ensure that the values are 
             * shown to 2 decimal places. They are also formatted in collumns so that they are all
             * alligned.
             */

            Console.WriteLine($"Invoice Summary");
            Console.WriteLine("=========================");
            Console.WriteLine($"{"Sub Total:",-17} {subTotal.ToString("F2"),7}\n");
            Console.WriteLine($"{"Provincial Tax:",-17} {provincialTax.ToString("F2"),7}");
            Console.WriteLine($"{"Federal Tax:",-17} {federalTax.ToString("F2"),7}");
            Console.WriteLine($"{"Total Tax:",-17} {totalTax.ToString("F2"),7}\n");
            Console.WriteLine($"{"Total Price",-17} {totalPrice.ToString("F2"),7}");
            Console.WriteLine("=========================\n");
            Console.WriteLine("Thank you for your purchase, come again.");
            Console.WriteLine("Press any key to exit");

        }
    }
}
