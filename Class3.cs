using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxLibrary
{
    public class TaxCalculator
    {
        public double CalculateOldRegime(double income)
        {
            double tax = 0;
            if (income > 1000000)
                tax = (income - 1000000) * 0.30 + 250000 * 0.20 + 250000 * 0.05;

            else if (income > 500000)
                tax = (income - 500000) * 0.20 + 12500;

            else if (income > 250000)
                tax = (income - 250000) * 0.05;

            return tax;

        }
        public double CalculateNewRegime(double income)
        {
            double tax = 0;
            if (income > 1500000)
                tax = (income - 1500000) * 0.30 + 500000 * 0.020 + 400000 * 0.15 + 300000 * 0.10 + 300000 * 0.05;
            else if (income > 1200000)
                tax = (income - 1200000) * 0.20 + 30000 + 45000 + 60000;
            else if (income > 900000)
                tax = (income - 900000) * 0.15 + 30000 + 45000;
            else if (income > 600000)
                tax = (income - 600000) * 0.10 + 30000;
            else if (income > 300000)
                tax = (income - 300000) * 0.05;
            return tax;
        }
    }
}
