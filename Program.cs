using System;
//using SalaryLibraryV2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryLibrary;

namespace ClientAppV2
{
    internal class Program
    {
        static void Main()
        {
            SalaryCalculator obj = new SalaryCalculator();
            double basic = 30000;
            Console.WriteLine("Salary Version 2.0");
            Console.WriteLine("Basic Salary: "+ obj.CalculateBasicSalary(basic));
            Console.WriteLine("Allowances: "+ obj.CalculateAllowances(basic));

            Console.ReadLine();
        }
    }
}
