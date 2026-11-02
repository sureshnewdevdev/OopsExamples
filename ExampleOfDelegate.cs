using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public delegate int ScienceCal(int x, int y);
    public class ExampleOfDelegate
    {
        public static void Main(string[] args)
        {
            #region Example Basic
            //int x = 10;

            //Console.WriteLine( x);

            //ScienceCal researcher1 =  new ScienceCal(ResearchFunction2);

            //int result = researcher1(10, 90);

            //Console.WriteLine(result);
            #endregion

            Calculator calculator = new Calculator();
            calculator.FpDelegateCalculation = new DeleGateCalculation(AddMethod);
            var ans =calculator.CallerMethod(10, 30);
        }

        private static int AddMethod(int x, int y)
        {
            return x + y;
        }



        private static int ResearchFunction1(int x, int y)
        {
            return x + y + 100; // Jan 1st
        }

        private static int ResearchFunction2(int x, int y)  
        {
            return x + y + 300; // feb 2nd
        }
    }
}
