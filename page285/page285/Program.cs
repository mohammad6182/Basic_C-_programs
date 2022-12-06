using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page285
{
    class Program
    {
        static void Main(string[] args)
        {
            math x = new math();
            Console.WriteLine("pick a number");
            int number = Convert.ToInt32(Console.ReadLine());
            x.myAssignment(number, out int a);
            Console.WriteLine(a);
            Console.ReadLine();
            x.myAssignment(number);
            Console.ReadLine();

        }
    }
}
