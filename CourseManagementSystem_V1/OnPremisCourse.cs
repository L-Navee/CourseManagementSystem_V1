using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_V1
{
    internal class OnPremisCourse:Course
    {
        public string Schedule;
        public int ClassroomCapacity;

        public OnPremisCourse(string courseId, string title, string duration, decimal price, string schedule, int classroomCapacity) : base(courseId, title, duration, price)
        {
            this.Schedule = schedule;
            this.ClassroomCapacity = classroomCapacity; 
        }
        //public DisplayOnPremisCourseInfo()
        //{
        //    return $"CourseId:{CourseId},Title:{Title},Duration:{Duration},Price:{Price},Schedule:{Schedule},Classroomcapacity:{ClassroomCapacity}";
        //}
    }
}
