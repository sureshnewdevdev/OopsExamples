using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AbstractExample
{
    /*Create an interface IDevice with a default method implementation void PowerOn() => Console.WriteLine("Device On");. Create two more interfaces, ILaptop and ITablet, 
     * which both inherit from IDevice and override the PowerOn() default method with their own console outputs. Finally, 
     * write a HybridComputer class that implements both ILaptop and ITablet.
     * Challenge: Write the necessary code inside HybridComputer to resolve the compiler error caused by inheriting two different default implementations of PowerOn().*/

    public interface IDevice
    {
        void PowerOn() => Console.WriteLine("Device On");
    }

    public interface ILaptop : IDevice
    {
        void PowerOn() => Console.WriteLine("Laptop On");
    }

    public interface ITablet : IDevice
    {
        void PowerOn() => Console.WriteLine("Tablet On");
    }

    public class HybridComputer : ILaptop, ITablet
    {
        void ILaptop.PowerOn()
        {
            Console.WriteLine("Hybrid Laptop On");
        }
        void ITablet.PowerOn()
        {
            Console.WriteLine("Hybrid Tablet On");
        }
        public void PowerOn()
        {
            ((ILaptop)this).PowerOn();
            ((ITablet)this).PowerOn();
        }
    }

    // Build an example for type of inhertances

    public class Program2
    {
        static void Main(string[] args)
        {
            HybridComputer hybridComputer = new HybridComputer();
            hybridComputer.PowerOn();
        }
    }

}
