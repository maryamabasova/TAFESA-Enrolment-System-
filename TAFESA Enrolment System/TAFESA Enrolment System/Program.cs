using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestStudentClass();
        }
        static void TestStudentClass()
        {
            // Create an Address
            Address address = new Address(123, "Main Street", "Cityville", 12345, "State");

            // Create a Person
            Person person = new Person("John Doe", "john@example.com", "123-456-7890", address);

            // Create a Student
            Student student = new Student("Alice Smith", "alice@example.com", "987-654-3210", address, 001, "Computer Science", DateTime.Now);

            // Create a Subject
            Subject subject = new Subject(101, "Introduction to Programming", 500.00f);

            // Create an Enrolment
            Enrolment enrolment = new Enrolment(DateTime.Now, 85.5f, 1);

            // Display information
            Console.WriteLine("Person Information:");
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Email: {person.Email}");
            Console.WriteLine($"Phone Number: {person.PhoneNumber}");
            Console.WriteLine($"Address: {person.Address.StreetNum} {person.Address.StreetName}, {person.Address.Suburb}, {person.Address.Postcode}, {person.Address.State}");
            Console.WriteLine();

            Console.WriteLine("Student Information:");
            Console.WriteLine($"Student ID: {student.StudentID}");
            Console.WriteLine($"Program: {student.Program}");
            Console.WriteLine($"Date Registered: {student.DateRegistered}");
            Console.WriteLine();

            Console.WriteLine("Subject Information:");
            Console.WriteLine($"Subject Code: {subject.SubjectCode}");
            Console.WriteLine($"Subject Name: {subject.SubjectName}");
            Console.WriteLine($"Cost: {subject.Cost:C}");
            Console.WriteLine();

            Console.WriteLine("Enrolment Information:");
            Console.WriteLine($"Date Enrolled: {enrolment.DateEnroled}");
            Console.WriteLine($"Grade: {enrolment.Grade}");
            Console.WriteLine($"Semester: {enrolment.Semester}");

            // Test equality
            Student student2 = new Student("Alice Smith", "alice@example.com", "987-654-3210", address, 001, "Computer Science", DateTime.Now);
            Console.WriteLine($"Are the two students equal? {student == student2}");

            Console.ReadKey();
        }

    }
}
