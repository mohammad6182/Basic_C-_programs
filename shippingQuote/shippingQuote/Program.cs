using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcoming and company info
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please answer the questions about your package to recieve your Quote");
            Console.WriteLine("what is your package Weight?");
            // strat asking for exact dimensions and qualifying for next step
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day");
                Console.ReadLine();
            }
            Console.WriteLine("What is your package width?");
            int width = Convert.ToInt32(Console.ReadLine());
            if (width > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day");
                Console.ReadLine();
            }
            Console.WriteLine("What is your Package height?");
            int height = Convert.ToInt32(Console.ReadLine());
            if (height > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day");
                Console.ReadLine();
            }
            Console.WriteLine("What is your package length?");
            int length = Convert.ToInt32(Console.ReadLine());
            if (length > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day");
                Console.ReadLine();
            }
            // calculating the total cost based on the info have been saved 
            Console.WriteLine("Your estimated total for shipping this package is: $" + ((height * width * length) * weight) / 100);
            Console.ReadLine();

        }
    }
}
