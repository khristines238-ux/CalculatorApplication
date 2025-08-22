using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg1, T arg2);

    public class CalculatorClass
    {
        public Formula<double> formula;

        public Formula<double> calculateEvent;
        public event Formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
                calculateEvent += value;
            }
            remove
            {
                Console.WriteLine("Removed the Delegate");
                calculateEvent -= value;
            }
        }
        public double GetSum(double x, double y)
        {
            return x + y;
        }

        public double GetDifference(double x, double y)
        {
            return x - y;
        }

        public double GetProduct(double x, double y)
        {
            return x * y;
        }

        public double GetQuotient(double x, double y)
        {
            if (y == 0) return double.NaN;
            return x / y;
        }
    }
}