using System;
using SalaryLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientAppV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalaryCalculator obj = new SalaryCalculator();
            double basic = 30000;
            Console.WriteLine("Salary Version 1.0");
            Console.WriteLine("Basic Salary: " + obj.CalculateBasicSalary(basic));

            Console.ReadLine();
        }
    }
}
