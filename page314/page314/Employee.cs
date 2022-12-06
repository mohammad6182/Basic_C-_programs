using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page314
{
    class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int iD { get; set; }

        public static bool operator == (Employee e1, Employee e2)
        {
            return e1.iD == e2.iD;
        }
        public static bool operator !=(Employee e1, Employee e2)
        {
            return e1.iD != e2.iD;
        }
    }
}
