using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System
{
    internal class Enrolment
    {
        public DateTime DateEnroled { get; set; }

        public float Grade { get; set; }

        public int Semester { get; set; }

        public Enrolment(DateTime dateEnroled, float grade, int semester)
        {
            DateEnroled = dateEnroled;
            Grade = grade;
            Semester = semester;
        }
    }
}
