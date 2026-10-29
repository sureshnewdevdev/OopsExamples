using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample3
{
    public class Parent
    {
        public virtual void Display()
        {
            Console.WriteLine("This is the PolyeeExample class.");
        }
    }

    public class Child : Parent
    {
        public override void Display()
        {
            Console.WriteLine("Modified in Child");
        }
    }
}
