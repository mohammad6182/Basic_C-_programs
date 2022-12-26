using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page385
{
    public class NewEmployee
    {
        public string firstName;
        public string lastName;
        public string empID;
        public string position;
        public string team;
        public NewEmployee() : this("Default firstName", "Default lastName")
        {
            Console.WriteLine("Reserving new record for the upcoming employee.");
        }
        public NewEmployee(string firstName) : this(firstName, "Default lastName")
        {
            this.firstName = firstName;
            Console.WriteLine("Creating new record for the upcoming employee, with firstName!");
        }
        public NewEmployee(string firstName, string lastName) : this(firstName, lastName, "XC007", "Java Developer", "The JAVA team")
        {
            this.lastName = lastName;
            this.firstName = firstName;
            Console.WriteLine("Creating new record for the upcoming employee, with firstName and lastName!");
        }
        public NewEmployee(string firstName, string lastName, string empID, string position, string team)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.empID = empID;
            this.position = position;
            this.team = team;
            Console.WriteLine("Creating new record for the upcoming employee, with firstName, lastName, empID, position and team!");
        }
    }
}

