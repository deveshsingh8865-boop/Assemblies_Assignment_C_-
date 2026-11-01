using System;

namespace SalaryLibrary
{
    public class SalaryCalculator
    {
        public double CalculateBasicSalary(double basic)
        {
            return basic;
        }

        public double CalculateAllowances(double basic)
        {
            double hra = basic * 0.20;
            double da = basic * 0.10;
            double ta = basic * 0.05;

            return hra + da + ta;
        }
    }
}