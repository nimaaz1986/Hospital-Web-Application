// Name : Nima Azadikhah
// Lab5 Assignment
// Date : 12 December 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5_Hospital.Models
{
    
    public class Nurse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public char Gender { get; set; }

        public ICollection<Patient> Patients { get; set; }

    }
}
