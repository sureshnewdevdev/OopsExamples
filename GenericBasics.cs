using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public class GenericBasics
    {
        public static void Main(string[] args)
        {
            int x = 0;
            x=x + 10;
            int[] ints = new int[5]; // strict to data type, limited to 5 elements, rezizable but need more steps 

            ArrayList arrayList = new ArrayList(); // not strict to data type, can hold any type of data, can hold any number of elements, but not type safe

            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(3.14);

            for (int i = 0; i < arrayList.Count-1; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            Stack stack = new Stack(); // not strict to data type, can hold any type of data, can hold any number of elements, but not type safe    
            stack.Push(1);
            stack.Pop();

            // Problem with the collection is boxing and unboxing, boxing is the process of converting a value type to a reference type, unboxing is the process of converting a reference type to a value type, boxing and unboxing can cause performance issues, boxing and unboxing can cause runtime errors, boxing and unboxing can cause memory leaks

            List<int> integerList = new List<int>(); // strict to data type, can hold any number of elements, but type safe



            integerList.Add(133);
            integerList.Add(452);
            integerList.Add(53);
            integerList.Add(64);
            integerList.Add(5555);

            integerList.Sort(); // Sort the list in ascending order

            for (int i = 0; i < integerList.Count; i++)
            {
                Console.WriteLine(integerList[i]);
            }


            List<DateTime> dateTimeList = new List<DateTime>();

            dateTimeList.Add(DateTime.Now);
            dateTimeList.Add(DateTime.Now.AddDays(-3)); 
            dateTimeList.Add(DateTime.Now.AddDays(5));
            dateTimeList.Add(DateTime.Now.AddDays(78));

            dateTimeList.Add(DateTime.Now);

            dateTimeList.Sort(); // Sort the list in ascending order




            List<string> commann = new List<string>();

            commann.Add("Hello");
            commann.Add("World");
            commann.Add("This is a test");

           


            Console.ReadLine();


        }
    }
}
