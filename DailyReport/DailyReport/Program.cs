using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome sentence and asking for name and returning the string as a welcome 
            Console.WriteLine("The Tech Academy!");
            Console.WriteLine("Student Daily Report");  
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine(yourName  +  ", Welcome to The Tech Academy!");
            Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("You will enjoy " + yourCourse);
            Console.ReadLine();
            Console.WriteLine("What page number?");
            int currPage =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your progress is appreciated");
            Console.ReadLine();
            // keeping the old code as DONT DO THIS :)
            //Console.WriteLine("Do you need help with anything?");
            //bool needHelp = true;
            //bool noHelp = false;
            //Console.WriteLine(needHelp);
            //Console.WriteLine(noHelp);
            //Console.ReadLine();

            Console.WriteLine("Do you need help with anything(Yes/No)?");
            string answer = Console.ReadLine().Trim().ToLower();
            if(answer == "yes")
            {
                Console.WriteLine("We can help you, Please call us");
            } else if(answer == "no")
            {
                Console.WriteLine("Good job, keep up the good work");
            }

            Console.WriteLine("Where There any experience you'd like to share? Please give specifics.");
            string experience = Console.ReadLine();
            Console.WriteLine(yourName + ", We appreciate your feedback ");
            Console.ReadLine();
            Console.WriteLine("Is there any other feedback you's like to provide? Please give specifics.");
            string feedback = Console.ReadLine();
            Console.WriteLine(yourName + ", We appreciate your feedback ");
            Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHour = Console.ReadLine();
            Console.WriteLine("wow!" + studyHour + " is some real work, Good job" + yourName);
            Console.ReadLine();
            Console.WriteLine(" Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();


            //Console.WriteLine("Is there any other feedback you'd like to provide? please be specific.");
            //Console.WriteLine("How many hours did you study today?");
            //Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day");
            //Console.ReadLine();

        }
    }
}
