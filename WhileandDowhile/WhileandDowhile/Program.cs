using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileandDowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pick a number bertween 3 and 7.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPicked = number ==5;

            do
            {
                switch (number)
                {
                    case 3:
                        Console.WriteLine("Wrong Choice!");
                        Console.WriteLine("pick a number bertween 3 and 7.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Wrong Choice!");
                        Console.WriteLine("pick a number bertween 3 and 7.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Great Choice");
                        isPicked = true;
                        break;
                    case 6:
                        Console.WriteLine("Wrong Choice!");
                        Console.WriteLine("pick a number bertween 3 and 7.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Wrong Choice!");
                        Console.WriteLine("pick a number bertween 3 and 7.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Please Between 3 and 7, Come one now !!");
                        Console.WriteLine("pick a number bertween 3 and 7.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }

            while (!isPicked);
            
            Console.ReadLine();
        }
    }
}
