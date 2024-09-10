using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator { 
    public delegate T Formula<T>(T arg1,T arg2);
    public class CalculatorClass
    {
        public Formula<double> formula;
        public event Formula<double> CalculateEvent 
        {
            add {
                System.Console.WriteLine("Added the Delegate");
              
            }
            remove {
                System.Console.WriteLine("Removed the Delegate");
              
            }
        }
       

        public double GetSum(double x, double y)
        {
            return x + y;
        }

        public double GetDifference(double x, double y)
        {
            
            return x-y;
        }

        public double GetProduct(double x, double y)
        {
            return x * y;
        }

        public double GetDivide(double x, double y)
        {
            return x / y;
        }
    }
}
