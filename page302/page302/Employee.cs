using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page302
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("name : " + this.FirstName + " " + this.LastName) ; 
        }
        public void Quit()
        {
            Console.WriteLine("I Quit");
            
        }

    }

    

    
}
