using System;
using TaxLibrary;
namespace TaxApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator obj = new TaxCalculator();
            double income = 1200000;
            Console.WriteLine("Annual Income : "+ income);

            double oldTax = obj.CalculateOldRegime(income);
            double newTax = obj.CalculateNewRegime(income);

            Console.WriteLine("Annual Income: "+ income);
            Console.WriteLine("Old Regime Tax: "+ oldTax);
            Console.WriteLine("New Regime Tax: "+ newTax);

            Console.ReadLine();
        }
    }
}
