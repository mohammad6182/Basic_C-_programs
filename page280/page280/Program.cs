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
            myClass x = new myClass();
            Console.WriteLine("pick 2 numbers");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x.Math1(number1));
            Console.ReadLine();
        }
    }
}
