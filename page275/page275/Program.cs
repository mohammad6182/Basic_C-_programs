using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page275
{
    class Program
    {
        static void Main(string[] args)
        {
            Math x = new Math();

            Console.WriteLine("pick a number");
            int numbers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x.mathAssignment(numbers));

            Console.WriteLine("pick a number");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x.mathAssignmnet1(number1));

            Console.WriteLine("pick a number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x.mathAssignment2(number2));
            Console.ReadLine();
        }
    }
}
