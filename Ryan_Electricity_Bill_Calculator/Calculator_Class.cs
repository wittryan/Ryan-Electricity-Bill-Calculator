/*
Author: Ryan Hurlstone 2023000700
Pledge of Honour: I pledge by honour that this program is solely my work.
Purpose: This console application will calculate and print the electricity bill of a specific customer.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryan_Electricity_Bill_Calculator
{
    internal class Calculator_Class
    {
        // This is a method to calculate the total amount of the electricity bill
        public static double CalculateTotalAmount(int unitsConsumed)
        {
            // This determines the charge per unit based on the units consumed
            double chargePerUnit = CalculateChargePerUnit(unitsConsumed);

            // This calculates the total amount based on the units consumed and charge per unit
            double totalAmount = unitsConsumed * chargePerUnit;

            // This ensures that the total amount is at least a minimum of $15
            totalAmount = Math.Max(totalAmount, 15);

            // This applies a surcharge if the total amount exceeds $400
            if (totalAmount > 400)
            {
                ApplySurcharge(ref totalAmount);
            }

            // This returns the total amount
            return totalAmount;
        }

        // This is a method to calculate the charge per unit of electricity
        public static double CalculateChargePerUnit(int unitsConsumed)
        {
            // This determines the charge per unit based on the units consumed
            if (unitsConsumed <= 199)
            {
                return 0.30; // This is the charge per unit for consumption less than or equal to 199 units
            }
            else if (unitsConsumed < 400)
            {
                return 0.32; // This is the charge per unit for consumption between 200 and 399 units
            }
            else if (unitsConsumed < 600)
            {
                return 0.36; // This is the charge per unit for consumption between 400 and 599 units
            }
            else
            {
                return 0.42; // This is the charge per unit for consumption greater than or equal to 600 units
            }
        }

        // This is a method to apply surcharge if total amount exceeds $400
        private static void ApplySurcharge(ref double totalAmount)
        {
            totalAmount *= 1.15; // This applies a 15% surcharge to the total amount
        }
    }
}