using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample2
{
   public abstract class Employee
    {

        
        public abstract double CalculateSalary();
        public void Display()
        {
            Console.WriteLine("This is the employee class.");
        }
    }
    public class Manager : Employee
    {
        
        public override double CalculateSalary()
        {
            return 10000000.0; // Example salary calculation for a manager
        }
        public void Display()
        {
            base.Display(); // Calls the Display method from the Employee class
            Console.WriteLine("This is the manager class.");
        }


    }
    public class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            (manager as Employee).Display(); // Calls the Display method from the Employee class

        }
    }
}
