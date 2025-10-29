using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3.Model._2__Online_Course_Enrollment_System
{
    public class LiveSession : Course_Enrollment
    {
        public string DateTime { get; set; }

        public LiveSession(string name, string instructor, Level level, string DateTime) : base(name, instructor, level)
        {
            this.DateTime = DateTime;
        }
    }
}
