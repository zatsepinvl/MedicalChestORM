using System;
using LinqToDB.Mapping;
using System.ComponentModel;

namespace MedicalChestProject
{
    [Table]
    public class Doctor
    {
        [Column(Name = "doctor_id", IsPrimaryKey = true)]
        public int DoctorId { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public string Surname { get; set; }

        [Column]
        public string Specialty { get; set; }

        [Column(Name="phone_number")]
        public string PhoneNumber { get; set; }

        [Column]
        public string Address { get; set; }

        [Column]
        public string Info { get; set; }
    }
}
