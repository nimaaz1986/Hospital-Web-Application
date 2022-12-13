using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// add
using Microsoft.EntityFrameworkCore;
using Lab5_Hospital.Models;

namespace Lab5_Hospital.Models
{
    public class PatientContext : DbContext
    {

        public PatientContext(DbContextOptions<PatientContext> options) : base(options)

        {



        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Lab5_Hospital.Models.Nurse> Nurse { get; set; }
        

    }
}
