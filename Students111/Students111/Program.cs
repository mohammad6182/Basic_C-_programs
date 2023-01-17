﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students111
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "ALEX" };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
            Console.WriteLine("Job Has Been Done.");
            Console.ReadLine();
        }
    }
}