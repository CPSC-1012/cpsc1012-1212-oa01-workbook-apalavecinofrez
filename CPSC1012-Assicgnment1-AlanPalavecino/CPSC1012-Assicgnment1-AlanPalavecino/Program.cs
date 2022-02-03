/* purpose: create an itemized sales invoice of a bicycle sale using the user's choices of brand
 *          tire size, metal selection, and a donation to green earth.
 * 
 * Inputs:  Customer Name, Brand Choice, Tire size Choice, Metal selection choice, donation
 * 
 * Outputs: Customer Name, chosen Brand Name, base price of bike, tire size price, metal price, 
 *          Sub Total, GST, Donation amount, Total
 * 
 * Algorithm:   Step 1) show brand options to user
 *                      a for trek
 *                      b for giant
 *                      c for specialized
 *                      d for raleigh
 *                      
 *              Step 2) prompt the user for choice and filter the user's input as follows:
 *                  switch (choice)
 *                      case "a":
 *                          brand = "trek"
 *                      case "b":
 *                          brand = "giant"
 *                      case "c":
 *                          brand = "specialized"
 *                      case "d":
 *                          brand = "raleigh"

 *              Step 3) Prompt and read in the user's tire size choice
 *              
 *              Step 4) Compute the price for the chosen tire size using this formula:
 *                          TireSizePrice = TireSize * 17.50
 *                          
 *              Step 5) Prompt and read in a metal choice
 *                      1 for Steel
 *                      2 for Aluminum
 *                      3 for Titanium
 *                      4 for Carbon Fiber
 *                      
 *              Step 6) prompt the user for choice and filter the user's input as follows:
                    switch (metalChoice)
                        case 1:
                            metalPrice = 0
                            validChoice = True
                        case 2:
                            metalPrice = 175
                            validChoice = True
                        case 3:
                            metalPrice = 425
                            validChoice = True
                        default:
                            Display an invalid input message
                
                step 7) Prompt user if they wish to donate and read in user's input

                step 8) if donation == "y":
                            prompt user for donation amount and read into donationAmount
                         else:
                            donationAmount = 0

                step 9) print an itemized invoice with all apropriate outputs, converting any prices to currency
                         and formatting them to the right
                            
 *                     
 *                      
 *          
 * 
 * 
 * Test Plan:
 *      Test Case       Test Data               Expected Results        Passed
 *      ---------       ---------               ----------------        ------
 *      name test       name = Alan Frez        Customer: Alan Frez     yes
 *      
 *      brand choice    choice = a              Brand: Trek             yes
 *                      choice = b              Brand: Giant            yes
 *                      choice = c              Brand: Specialized      yes
 *                      chioce = d              Brand: Raleigh          yes
 
 *      Tire size       size = 20               tire price: 350.00
 *      
 *      metal choice    metalChoice = 1         metal Price: 0.00
 *      
 *      donation        donation = y
 *                      donationAmount = 22.58  donation: 22.58
 *      
 * 
 * 
 * 
 */
using System;

namespace CPSC1012_Assicgnment1_AlanPalavecino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            string name,
                   selection,
                   brand = "",
                   donationChoice;
            double tirePrice,
                   metalPrice = 0,
                   donationAmount,
                   subTotal,
                   gst,
                   total;
            //declaring constants
            const double BasePrice = 500.00,
                         PricePerInch = 17.50,
                         GstRate = 0.05;

            //prompting user for name and reading it to name variable
            Console.Write("Enter your name >> ");
            name = Console.ReadLine();

            //gives user the brand options
            Console.WriteLine("Brand");
            Console.WriteLine($"a) Trek");
            Console.WriteLine($"b) Giant");
            Console.WriteLine($"c) Specialized");
            Console.WriteLine($"d) Raleigh");

            //prompts user for a choice from brand options and reads their input to selection
            Console.Write("Make a selection [a,b,c,d] >> ");
            selection = Console.ReadLine();

            //checks the user's selection and stores the corresponding brand in the brand variable
            switch (selection)
            {
                case "a":
                    brand = "Trek";
                    break;

                case "b":
                    brand = "Giant";
                    break;

                case "c":
                    brand = "Specialized";
                    break;

                case "d":
                    brand = "Raleigh";
                    break;

            }

            //prompts user for tire size
            Console.Write("Choose as tire size [20-26] @ 17.50 per inch >>");
            //computes the price by multiplying the input by the pricePerInch variable and then saves it to tirePrice variable
            tirePrice = int.Parse(Console.ReadLine()) * PricePerInch;

            //gives user the metal options
            Console.WriteLine("Enter the number of your corresponding choice of metal.");
            Console.WriteLine("1. Steel [$0]");
            Console.WriteLine("2. Aluminum [$175]");
            Console.WriteLine("3. Titanium [$425]");
            Console.WriteLine("4. Carbon Fiber [$615]");
            
            //prompts user for choice of metal adn reads it into selection variable
            Console.Write("Choice [1-4] >> ");
            selection = Console.ReadLine();

            //checks the user's selection and stores the corresponding price in the metalPrice variable
            switch (int.Parse(selection))
            {
                case 1:
                    metalPrice = 0;
                    break;
                case 2:
                    metalPrice = 175;
                    break;
                case 3:
                    metalPrice = 425;
                    break;
                case 4:
                    metalPrice = 615;
                    break;
            }

            //prompts user whether or not they wish to make a donation and reads their response to donationChoice variable
            Console.Write("Would you like to make a donation to the Green Earth Fund [y/n] ");
            donationChoice = Console.ReadLine();

            //checks if user chose to make a donation
            if (donationChoice == "y")
            {
                //prompts user for donation amount and reads it into variable donationAmount
                Console.Write("Amount >> ");
                donationAmount = double.Parse(Console.ReadLine());
            }
            else
            {
                //user chose not to donate so it saves the donationAmount as zero
                donationAmount = 0;
            }

            //calculates the subTotal, gst, and total
            subTotal = BasePrice + tirePrice + metalPrice;
            gst = subTotal * GstRate;
            total = subTotal + donationAmount + gst + donationAmount;

            //prints invoice formatted with prices alligned to the right in 2 decimal places
            Console.WriteLine("Invoice and Packing Slip\n");
            Console.WriteLine($"{"Customer:",-24} {name}");
            Console.WriteLine($"{"Brand:",-24} {brand}");
            Console.WriteLine($"{"Base Price:",-24} {"",10} {BasePrice.ToString("F2"), 9}");
            Console.WriteLine($"{"Tire Size Premium:",-24} {"",10} {tirePrice.ToString("F2"), 9}");
            Console.WriteLine($"{"Metal Selection Premium:",-24} {"",10} {metalPrice.ToString("F2"), 9}");
            Console.WriteLine($"{"---------",45}");
            Console.WriteLine($"{"Sub Total:",-24} {"",10} {subTotal.ToString("F2"), 9}");
            Console.WriteLine($"{"GST:",-24} {"",10} {gst.ToString("F2"),9}");
            Console.WriteLine($"{"=========",45}");
            Console.WriteLine($"{"Donation to Green Earth",-24} {"",10} {donationAmount.ToString("F2"), 9}");
            Console.WriteLine($"{"Total:",-24} {"",10} {total.ToString("F2"), 9}");
        }
    }
}
