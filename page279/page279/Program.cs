using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page279
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathopp x = new Mathopp();
            
            Console.WriteLine("pick a number");
            int numbers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x.MAssighnment(numbers));

            Console.WriteLine("pick a number");
            decimal number1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(x.MAssighnment(number1));
            Console.ReadLine();

            Console.WriteLine("pick a number");
            string word1 = Console.ReadLine();

            Console.WriteLine(x.MAssighnment(word1));
            Console.ReadLine();
        }
        
    }
}
