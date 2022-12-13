using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Lab5_Hospital.Models
{
    public class Patient
    {
        public int SnnNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int receipt { get; set; }
        public char Gender { get; set; }


        public Nurse Nurse { get; set; }
        public int Id { get; set; }

    }
}
