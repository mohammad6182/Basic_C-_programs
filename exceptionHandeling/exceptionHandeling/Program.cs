using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandeling
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can put the wholw code under "TRY" and thiswa y we can add exceptions Later one, Exceptions can be general or more specific
            try
            {
                Console.WriteLine("Pick a number: ");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a asecond number:");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two....");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                // this is an automatic massage 
                Console.WriteLine(ex.Message);

                // or we can print our own massage 
                // Console.WriteLine(" Please type a whole number ");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by zero");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
