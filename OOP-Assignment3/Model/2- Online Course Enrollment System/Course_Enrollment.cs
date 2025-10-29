using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3.Model._2__Online_Course_Enrollment_System
{
    public class Course_Enrollment
    {
        public Course_Enrollment(string name, string instructor, Level level)
        {
            Name = name;
            Instructor = instructor;
            this.level = level;
        }

        public string Name { get; set; }
        public string Instructor { get; set; }
        public Level level { get; set; }
    }
}
