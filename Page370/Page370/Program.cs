using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Page370
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("pick a number between 1 and 20");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("in {0} hours, the time will be " + DateTime.Now.AddHours(x) , x);
            Console.ReadLine();
        }
    }
}
