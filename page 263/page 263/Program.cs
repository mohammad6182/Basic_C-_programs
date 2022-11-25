using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_263
{
    class Program
    {
        static void Main(string[] args)
        {
        try
            {
                // making list to start with
                List<int> numbers = new List<int>() { 20, 14, 18, 1 };
                Console.WriteLine("Pick a number to start dividing...");
                // converting to int to start dividing
                int d = Convert.ToInt32(Console.ReadLine());
                for (int n = 0; n < numbers.Count; n++)
                {
                    Console.WriteLine(n / d);
                    Console.ReadLine();
                }
                
                
            }
        catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please dont choose zerto ");
            }
            finally
            {
                Console.ReadLine();
            }          
            
        }
    }
}
