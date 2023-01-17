using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students111
{
    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public TeachingMode ModeOfTeaching { get; set; }
    }

    public enum TeachingMode
    {
        Online,
        ClassRoom,
        LiveOnline
    }
}
