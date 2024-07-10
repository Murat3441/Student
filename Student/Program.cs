using Student;
using System;
using System.Data.Entity;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new SchoolInitializer());

            using (var context = new SchoolContext())
            {
                var student = new Student
                {
                    FirstName = "Jane",
                    LastName = "Smith"
                };

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added successfully.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
