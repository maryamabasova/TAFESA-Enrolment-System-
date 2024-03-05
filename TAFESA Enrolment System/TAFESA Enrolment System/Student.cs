using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System
{
    internal class Student : Person 
    {
        public int StudentID { get; set; }

        public string Program { get; set; }

        public DateTime DateRegistered { get; set; }

        public Student(string name, string email, string phoneNumber, Address address, int studentID, string program, DateTime dateRegistered)
            : base(name, email, phoneNumber, address)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
        }

        public override bool Equals(object obj)
        {
            if (obj is Student otherStudent)
            {
                // Compare relevant properties for equality
                return this.StudentID == otherStudent.StudentID && this.Program == otherStudent.Program;
            }
            return false;
        }

        // Overload == operator
        public static bool operator ==(Student s1, Student s2)
        {
            return s1.Equals(s2);
        }

        // Overload != operator
        public static bool operator !=(Student s1, Student s2)
        {
            return !s1.Equals(s2);
        }

        // Override GetHashCode for hashing
        public override int GetHashCode()
        {
            return StudentID.GetHashCode() ^ Program.GetHashCode();
        }
    }
}
