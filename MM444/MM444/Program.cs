using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MM444
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                // Create and save a new Blog
                Console.WriteLine("Please enter new student information: ");
                Student s = new Student();

                bool invalidInput = true;
                invalidInput = true;

                do
                {
                    Console.Write("Please enter the student's first name: ");
                    string studentFirst = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(studentFirst))
                    {
                        Console.WriteLine("Invalid first name, please try again.");
                        continue;
                    }
                    s.FirstName = studentFirst;
                    invalidInput = false;
                } while (invalidInput);

                invalidInput = true;
                do
                {
                    Console.Write("Please enter the student's last name: ");
                    string studentLast = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(studentLast))
                    {
                        Console.WriteLine("Invalid last name, please try again.");
                        continue;
                    }
                    s.LastName = studentLast;
                    invalidInput = false;
                } while (invalidInput);

                invalidInput = true;
                do
                {
                    Console.Write("Please enter the student's address: ");
                    string studentAddress = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(studentAddress))
                    {
                        Console.WriteLine("Invalid address, please try again.");
                        continue;
                    }
                    s.Address = studentAddress;
                    invalidInput = false;
                } while (invalidInput);

                invalidInput = true;
                do
                {
                    Console.Write("Please enter the student's phone number: ");
                    string studentPhone = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(studentPhone))
                    {
                        Console.WriteLine("Invalid phone number, please try again.");
                        continue;
                    }
                    s.Phone = studentPhone;
                    invalidInput = false;
                } while (invalidInput);

                invalidInput = true;
                do
                {
                    Console.Write("Please enter the student's GPA: ");
                    string studentGPA = Console.ReadLine();
                    Decimal.TryParse(studentGPA, out decimal decStudentGPA);
                    if (decStudentGPA < 0m || decStudentGPA > 4.0m)
                    {
                        Console.WriteLine("Invalid GPA (must be between 0.0 and 4.0), please try again.");
                        continue;
                    }
                    s.GPA = decStudentGPA;
                    invalidInput = false;
                } while (invalidInput);


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please wait while we save the student to the database....");

                db.Students.Add(s);
                db.SaveChanges();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Loading all currents students");
                Console.WriteLine();
                Console.WriteLine();

                // Display all Blogs from the database
                var query = from b in db.Students
                            orderby b.Id
                            select b;

                Console.WriteLine("All students in the database:");
                Console.Write(("Student ID").PadRight(30));
                Console.Write(("Firstname").PadRight(30));
                Console.Write(("Lastname").PadRight(30));
                Console.Write(("GPA").PadRight(30));
                foreach (var item in query)
                {
                    Console.Write(item.Id.ToString().PadRight(30));
                    Console.Write(item.FirstName.PadRight(30));
                    Console.Write(item.LastName.PadRight(30));
                    Console.Write(item.GPA.ToString("n2").PadRight(30));
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
            }
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal GPA { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

}
