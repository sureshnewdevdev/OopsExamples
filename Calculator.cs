using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public delegate int DeleGateCalculation(int x, int y);
    public class Calculator
    {
        public DeleGateCalculation FpDelegateCalculation { get; set; }

        public int CallerMethod(int a, int b)
        {
            return FpDelegateCalculation(a, b);
        }
    }
}
