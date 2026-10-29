using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{

    public class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Business = "Business";
            child.ManagingFinance = "Managing Finance";
            child.DisplayName = "Child Display Name";
            ((IMan)child).Greeting = "Hello from IMan";
            ((IWoman)child).Greeting = "Hello from IWoman";

            Console.WriteLine($"Business: {child.Business}");
            Console.WriteLine($"Managing Finance: {child.ManagingFinance}");
            Console.WriteLine($"Display Name: {child.DisplayName}");
            Console.WriteLine($"IMan Greeting: {((IMan)child).Greeting}");
            Console.WriteLine($"IWoman Greeting: {((IWoman)child).Greeting}");


        }
    }

    //public class Man : IMan
    //{

    //    public string Business { get; set; }
    //    public string DisplayName { get ; set; }
    //}

    //public class Woman : IWoman
    //{
    //    public string ManagingFinance { get; set; }
    //    public string DisplayName { get; set; }

    //}

    //public class Child : Man, Woman
    //{
    //    public string Name { get; set; }
    //}

    public class Child : IMan, IWoman
    {
        public string Business { get; set; }
        public string ManagingFinance { get; set; }
        public string DisplayName { get; set; }
        string IMan.Greeting { get; set; }
        string IWoman.Greeting { get; set; }
    }
}



