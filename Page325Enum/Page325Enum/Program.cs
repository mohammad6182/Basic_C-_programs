using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page325Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day it is?");
            string input = Console.ReadLine();
            try
            {
                DayOfWeek MyDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input);
                Console.WriteLine("Have a Nice " + MyDay);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week");

            }
       Console.ReadLine();
        }
    }
}
