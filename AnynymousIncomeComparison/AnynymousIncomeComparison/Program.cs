using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnynymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");        
            Console.WriteLine("Person 1");
            Console.WriteLine("What is you Hourly Rate?");
            int hourlyOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how many hours do you work each week?");
            int weeklyOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Good Job! So You are working " + weeklyOne + " hours and getting paid " + hourlyOne + "$ per hour");
            
            Console.WriteLine("Person 2");
            Console.WriteLine("What is you Hourly Rate?");
            int hourlyTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how many hours do you work each week?");
            int weeklyTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Good Job! So You are working " + weeklyTwo + " hours and getting paid " + hourlyTwo + "$ per hour");
            
            Console.WriteLine("Annual Salary of person 1:");
            Console.WriteLine("$" + weeklyOne * hourlyOne * 52);
            Console.WriteLine("Annual Salary of person 12:");
            Console.WriteLine("$" + weeklyTwo * hourlyTwo * 52);
            Console.WriteLine(" Does Person 1 make more money than Person 2 ?");
            
            if (weeklyOne * hourlyOne > weeklyTwo * hourlyTwo )
            {
                Console.WriteLine("True");
            }
            else if (weeklyOne * hourlyOne  < weeklyTwo * hourlyTwo)
                Console.WriteLine("False");
                Console.ReadLine();


        }
    }
}
