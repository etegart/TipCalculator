using System;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What was your bill amount?");
            string billInput = Console.ReadLine();
            //billInput = billInput.Trim();
            //billInput = billInput.Trim('$');
            billInput = billInput.Trim().Trim('$');

           

            Console.WriteLine("What percent would you like to tip?");
            string tipPercentInput = Console.ReadLine();
            //tipPercentInput = tipPercentInput.Trim();
            //tipPercentInput = tipPercentInput.Trim('%');
            tipPercentInput = tipPercentInput.Trim().Trim('%');

            double tipPercent;
            double bill; 
            if (!double.TryParse(tipPercentInput, out tipPercent)) 
            {
                Console.WriteLine($"The value {tipPercentInput} is not valid");
            }

            if (!double.TryParse(billInput, out bill))
            {
                Console.WriteLine($"The value {bill} is not valid");
            }
            //double bill = double.Parse(billInput);
            // int tipPercent = int.Parse(tipPercentInput);


            double tipAmount = Math.Round (tipPercent * bill / 100, 2);
            double totalBill = Math.Round(bill + tipAmount, 2);

            //double roundedTipAmount = Math.Round(tipAmount, 2);
            //totalBill = Math.Round(totalBill, 2);

            Console.WriteLine($"Your tip amount is ${ tipAmount}");
            Console.WriteLine($"Your total bill is ${totalBill}");

            Console.ReadLine();
        }
    }
}
