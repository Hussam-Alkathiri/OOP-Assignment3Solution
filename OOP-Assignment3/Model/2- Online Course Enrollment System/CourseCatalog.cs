using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3.Model._2__Online_Course_Enrollment_System
{
    public class CourseCatalog
    {
        private List<Course_Enrollment> courses = new List<Course_Enrollment>();

        public void AddCourse(Course_Enrollment course)
        {
            courses.Add(course);
        }
        public List<Course_Enrollment> this[Level lvl]
        {
            get
            {
                List<Course_Enrollment> result = new List<Course_Enrollment>();

                foreach (Course_Enrollment c in courses)
                {
                    if (c.level == lvl)
                    {
                        result.Add(c);
                    }
                }
                return result;
            }
        }
    }
}
