using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System
{
    internal class Subject
    {
        public int SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public float Cost { get; set; }
        public Subject(int subjectCode, string subjectName, float cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;
        }
    }
}
