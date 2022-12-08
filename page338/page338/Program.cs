using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page338
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>()
            {
                new Employee() {id=1 , FirstName= "Mike", LastName= "Colone"},
                new Employee() {id=2 , FirstName="Dan" , LastName="Colone" },
                new Employee() {id=3, FirstName="Tom" , LastName="Colone" },
                new Employee() {id=4 , FirstName="Joe" , LastName="Colone" },
                new Employee() {id=5 , FirstName="Joe" , LastName= "Colone"},
                new Employee() {id=6 , FirstName="nick" , LastName="Colone" },
                new Employee() {id= 7, FirstName= "Mark", LastName="Colone" },
                new Employee() {id=8 , FirstName= "Sam", LastName="Colone" },
                new Employee() {id= 9, FirstName= "Nigel", LastName= "Colone"},
                new Employee() {id=10 , FirstName="Brandon" , LastName= "Colone"}

            };
            List<Employee> employee2 = new List<Employee>();
            foreach(Employee e in employee)
            {
                if( e.FirstName == "Joe")
                {
                    employee2.Add(e);
                }
               
            }
            List<Employee> employee3 = employee.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> employee4 = employee.Where(x => x.id == 5).ToList();
        }
    }
}
