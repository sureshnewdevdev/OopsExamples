using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AbstractExample
{
    public class RegexExample
    {

        public static void Main(string[] args)
        {
            RegexExample regexExample = new RegexExample();
            regexExample.MyRegrex();
            regexExample.ExampleOfExtensionmethods();


            string name = "Ramasway, I am learning C# extension methods.\"";
            int wCount= name.WordCount();
        }

        public void MyRegrex()
        {
            string employeeId = "EMP-1001";
            string pattern = @"\AEMP-[0-9]{4}\z";
            Regex employeeIdRegex = new Regex(pattern, RegexOptions.None, TimeSpan.FromSeconds(1));

            bool isValid = employeeIdRegex.IsMatch(employeeId);
            Console.WriteLine($"Employee ID: {employeeId}");
            Console.WriteLine($"Valid: {isValid}");
        }

        /// <summary>
        /// Demonstrates the use of an anonymous type in C#.
        /// </summary>
        public void ExampleOfAnonymousType()
        {
            var employee = new { Id = 1, Name = "John Doe", Department = "IT" };
            Console.WriteLine($"Employee ID: {employee.Id}, Name: {employee.Name}, Department: {employee.Department}");
        }

        //Example of Auto Implemented properties
        // Auto-implemented properties allow you to quickly define a property without having to
        // write the backing field explicitly.
        // The compiler automatically creates a private, anonymous backing field that can only
        // be accessed through the property's get and set accessors.
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
        }

        public void ExampleOfExtensionmethods()
        {
            string str = "Hello, World!";
            int wordCount = str.WordCount();
            Console.WriteLine($"Word Count: {wordCount}");
        }

        public  void CalculateG()
        {
            var planet = new { PlanetName = "Moon", GF = 8.0 };
            Console.WriteLine($"Planet: {planet.PlanetName}, Gravitational Force: {planet.GF}");
        }
    }

    public static class StringExtensions
    {
        /// <summary>
        /// Extension method to count the number of words in a string.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>The word count.</returns>
        public static int WordCount(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            //return input.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return input.Select(c=> c.Equals(" ")).Count()+1;
        }

     
    }
}
