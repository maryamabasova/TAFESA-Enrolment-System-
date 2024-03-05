using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System
{
    internal class Address
    {
        public int StreetNum { get; set; }

        public string StreetName { get; set; }

        public string Suburb { get; set; }
        public int Postcode { get; set; }
        public string State { get; set; }
        public Address(int streetNum, string streetName, string suburb, int postcode, string state)
        {
            StreetNum = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }
    }
}
