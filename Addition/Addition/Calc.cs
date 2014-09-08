using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    class Calc: ICalc
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            ICalc cal = new Calc();
            Console.WriteLine(cal.Add(5, 3));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

    }
}
