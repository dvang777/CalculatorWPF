using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CalculatorWPF
{
    public class Calculator
    {
        public double Calculate(string input)
        {
            DataTable data = new DataTable();
            var result = data.Compute(input, "");
            return Convert.ToDouble(result);
        }
    }
}
