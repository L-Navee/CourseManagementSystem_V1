using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_V1
{

    class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseManager = new CourseManager();
            int option;

            do
            {
                Console.WriteLine("\nCourse Management System:");
                Console.WriteLine("1. Add a Course");
                Console.WriteLine("2. View All Courses");
                Console.WriteLine("3. Update a Course");
                Console.WriteLine("4. Delete a Course");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        // Add Course
                        Console.Write("Enter Course ID: ");
                        string id = (Console.ReadLine());
                        Console.Write("Enter Course Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Course Duration: ");
                        string duration = Console.ReadLine();
                        Console.Write("Enter Course Price: ");
                        decimal price = Convert.ToDecimal(Console.ReadLine());

                        Course course = new Course(id, title, duration, price);
                        courseManager.CreateCourse(course);
                        break;

                    case 2:
                        // View Courses
                        courseManager.ReadCourse();
                        break;

                    case 3:
                        // Update Course
                        Console.Write("Enter Course ID to update: ");
                        string updateId = (Console.ReadLine());
                        Console.Write("Enter new Title: ");
                        string newTitle = Console.ReadLine();
                        Console.Write("Enter new Duration: ");
                        string newDuration = Console.ReadLine();
                        Console.Write("Enter new Price: ");
                        decimal newPrice = Convert.ToDecimal(Console.ReadLine());

                        courseManager.UpdateCourse(updateId, newTitle, newDuration, newPrice);
                        break;

                    case 4:
                        // Delete Course
                        Console.Write("Enter Course ID to delete: ");
                        string deleteId = (Console.ReadLine());
                        courseManager.DeleteCourse(deleteId);
                        break;

                    case 5:
                        // Exit
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            } while (option != 5);
        }
    }
}
