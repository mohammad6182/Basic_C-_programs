using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace StudentsAssignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
    }

    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var student = new Student() { StudentName = "John Doe" };
                context.Students.Add(student);
                context.SaveChanges();

                var students = context.Students.ToList();
                foreach (var std in students)
                {
                    Console.WriteLine("Student ID: {0}, Student Name: {1}", std.StudentId, std.StudentName);
                }
            }
            Console.ReadLine();
        }
    }
}

}