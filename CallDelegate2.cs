using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public class CallDelegate2
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.FpDelegateCalculation = new DeleGateCalculation(SomeMethod);
            var result=calculator.CallerMethod(99, 77);
            Console.WriteLine(result);

            //Calculator calculator = new Calculator();
            //calculator.FpDelegateCalculation = new DeleGateCalculation(AddMethod);
            //var ans = calculator.CallerMethod(10, 30);
            //Console.WriteLine($"The result of the delegate calculation is: {ans}");
        }

        private static int SomeMethod(int x, int y)
        {
            return x + 2 * y;
        }

        private static int AddMethod(int x, int y)
        {
            return x + y;
        }
    }
}
