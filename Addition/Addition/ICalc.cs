using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    interface ICalc
    {
        int Add(int a, int b);
        int Sub(int a, int b);
        int Multiply(int a, int b);
        double Divide(int a, int b);

    }
}
