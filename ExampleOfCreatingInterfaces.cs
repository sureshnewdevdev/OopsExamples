using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample4
{
    //public abstract class Employee
    //{
    //    public abstract string ListOfHolidays { get; set; }
    //    public abstract double CalculateSalary();
    //    public void Display()
    //    {
    //        Console.WriteLine("This is the employee class.");
    //    }

    //}

    //public class IndianEmployee : Employee
    //{
    //    public override string ListOfHolidays { get; set; }

    //    public override double CalculateSalary()
    //    {
    //        return 50000.0; // Example salary calculation for an Indian employee
    //    }
    //}

    public interface IEmployee
    {
        string ListOfHolidays { get; set; }
        double CalculateSalary();
        void Display();
    }

    public class Employee : IEmployee
    {
        public string ListOfHolidays { get ; set ; }

        public double CalculateSalary()
        {
            return 9000000000;
        }

        public void Display()
        {
            Console.WriteLine("Some Value");
        }
    }
}
