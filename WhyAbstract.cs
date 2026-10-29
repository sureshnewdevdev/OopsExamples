using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public class Parent
    {

        public void MainDisplay()
        {
            Console.WriteLine("This is the main display method in the parent class.");
        }
        public void Display()
        {
            Console.WriteLine("This is the parent class.");
        }
    }

    public class Child : Parent
    {
        public void Display()
        {
            Console.WriteLine("This is the child class.");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.MainDisplay();

            Child child = new Child();
            child.MainDisplay();

            parent.Display();
            child.Display();
            //parent.Display();
            //Child child = new Child();
            //child.MainDisplay();
            //child.Display();
            Console.ReadLine();
        }
    }
}
