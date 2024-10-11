using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_V1
{

    public class CourseManager
    {
        private List<Course> courses = new List<Course>();

        // Add a new course
        public void CreateCourse(Course course)
        {
            courses.Add(course);
            Console.WriteLine("Course added successfully.");
        }

        // View all courses
        public void ReadCourse()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("No courses available.");
            }
            else
            {
                foreach (var course in courses)
                {
                    Console.WriteLine(course.ToString());
                }
            }
        }

        // Edit an existing course
        public void UpdateCourse(string courseId, string newTitle, string newDuration, decimal newPrice)
        {
            Course course = courses.Find(c => c.CourseId == courseId);
            if (course != null)
            {
                course.Title = newTitle;
                course.Duration = newDuration;
                course.Price = newPrice;
                Console.WriteLine("Course updated successfully.");
            }
            else
            {
                Console.WriteLine("Course not found.");
            }
        }

        // Remove a course
        public void DeleteCourse(string courseId)
        {
            Course course = courses.Find(c => c.CourseId == courseId);
            if (course != null)
            {
                courses.Remove(course);
                Console.WriteLine("Course deleted successfully.");
            }
            else
            {
                Console.WriteLine("Course not found.");
            }
        }
    }
}
