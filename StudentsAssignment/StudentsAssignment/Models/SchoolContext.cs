using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentsAssignment.Models;

namespace YourProjectName.DataAccess
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}