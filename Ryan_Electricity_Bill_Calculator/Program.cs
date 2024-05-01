/*
Author: Ryan Hurlstone 2023000700
Pledge of Honour: I pledge by honour that this program is solely my work.
Purpose: This console application will calculate and print the electricity bill of a specific customer.
*/

namespace Ryan_Electricity_Bill_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This prompts the user to enter a Customer ID number and stores it in the variable 'customer_idno'
            Console.WriteLine("Enter IDNO:");
            string customer_idno = Console.ReadLine();

            // This prompts the user to enter a Customer Name and stores it in the variable 'customer_name'
            Console.WriteLine("Enter Name:");
            string customer_name = Console.ReadLine();

            // This prompts the user to enter the amount of units consumed and stores it in the variable 'units_consumed'
            Console.WriteLine("Enter Units Consumed:");
            int units_consumed = Convert.ToInt32(Console.ReadLine());

            // This calculates the total amount using the Calculator_Class
            double totalAmount = Calculator_Class.CalculateTotalAmount(units_consumed);

            // This displays the generated bill and customer information in the console
            Console.WriteLine("Generated Bill:");
            Console.WriteLine("Customer IDNO: " + customer_idno);
            Console.WriteLine("Customer Name: " + customer_name);
            Console.WriteLine("Units Consumed: " + units_consumed);
            Console.WriteLine("Amount Charges @NZ$" + Calculator_Class.CalculateChargePerUnit(units_consumed).ToString("0.00") + " per unit");

            // This checks and displays the surcharge amount if total amount exceeds $400
            if (totalAmount > 400)
            {
                Console.WriteLine("Surcharge Amount: NZ$" + (totalAmount - (units_consumed * Calculator_Class.CalculateChargePerUnit(units_consumed))).ToString("0.00"));
            }
            else
            {
                Console.WriteLine("Surcharge Amount: NZ$0");
            }

            Console.WriteLine("Net Amount Paid By the Customer: NZ$" + totalAmount.ToString("0.00"));
        }
    }
}
