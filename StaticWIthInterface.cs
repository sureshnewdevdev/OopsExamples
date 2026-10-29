using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public  interface IPrint
    {
        public string Print();
    }

    public  class Printer : IPrint
    {
        public static string PrintStatic()
        {
            return "Printing from static class";
        }
        public  string Print()
        {
            return "Printing from static class";
        }
    }
  
}
