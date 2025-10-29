using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3.Model._2__Online_Course_Enrollment_System
{
    public class VideoCourse : Course_Enrollment
    {
        public int Duration { get; set; }

        public VideoCourse(string name, string instructor, Level level, int Duration) : base(name, instructor, level)
        {
            this.Duration = Duration;
        }
    }
}
