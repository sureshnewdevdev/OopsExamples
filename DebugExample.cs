using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AbstractExample
{
    public class DebugExample
    {
        public static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z = 0;


            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Please enter value for x : ");

                    x = int.Parse(Console.ReadLine());
                    x = int.MaxValue;

                    //checked
                    //{
                    //    z = x + 1;

                    //}

                    Console.WriteLine("Please enter value for y : ");
                    y = int.Parse(Console.ReadLine());

                     z = x + y;

                    Console.WriteLine("Ans = ", z);
                     
                    x = int.Parse(Console.ReadLine());
                }

            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Please enter valid input " );
            }
            catch (FormatException ex)
            {
                Console.WriteLine(" Please check the data format  " );
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Overflow Exception: "  );
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Zero is not a valid excpetion");
            }
            catch (Exception ex)
            {
                Console.WriteLine( "There is an error");
            }
            finally
            {
                x = 0; y = 0; z = 0;
                Console.WriteLine("Finally block executed");
            }

 
            Console.ReadKey();
        }
    }
}
