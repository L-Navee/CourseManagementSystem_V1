using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_V1
{
    internal class DigitalCourse:Course

    {

        public string CourseLink;
        public double FileSize;

        public DigitalCourse(string courseId, string title, string duration, decimal price, string courseLink, double fileSize) : base(courseId, title, duration, price)
        {
            this.CourseLink = courseLink;
            this.FileSize = fileSize;
        }
        
    }
}
