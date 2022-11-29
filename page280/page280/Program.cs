using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page280
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                myClass x = new myClass();
                Console.WriteLine("pick 2 numbers");
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x.Math1(number1, number2));
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                // this is an automatic massage 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

    }

}

