using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page281
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment x = new Assignment();
            Console.WriteLine("pick two numbers");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            x.Math(number1, number2);
            x.Math(number1 = 5, number2 = 6);
            Console.ReadLine();
        }
    }
}
