using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceForm
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcoming and and showing a note
            Console.WriteLine("Welcome to Car Insurance!");
            Console.WriteLine("Please answer to the following questions and make sure to provide all the requird detaild.");
            
            // asking for int and later on convert to int32
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            // boolian logic, to make sure typing wont effect, will convert to lower()
            Console.WriteLine("Have you ever hd a DUI? Yes/No");
            string dui = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("How many speeding Tickets do you have?");
            int ticket = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified");
            // calculating the qualifications to see 
            if (age > 15 && dui != "yes" && ticket < 4)
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");
                Console.ReadLine();
        }   

    }
}
