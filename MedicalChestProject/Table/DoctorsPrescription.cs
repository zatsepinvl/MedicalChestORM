using System;
using LinqToDB.Mapping;
using System.ComponentModel;

namespace MedicalChestProject
{
    public class DoctorsPrescription
    {
        [Browsable(false)]
        [Column(Name = "user_id", IsPrimaryKey = true)]
        public int UserId { get; set; }

        [Browsable(false)]
        public string UserName { get; set; }
        [Browsable(false)]
        public string UserSurname { get; set; }

        public string User { get { return UserName + " " + UserSurname; } }

        [Browsable(false)]
        [Column(Name = "doctor_id", IsPrimaryKey = true)]
        public int DoctorId { get; set; }

        [Browsable(false)]
        public string DoctorName { get; set; }
        [Browsable(false)]
        public string DoctorSurname { get; set; }

        public string Doctor { get { return DoctorName + " " + DoctorSurname; } }

        [Browsable(false)]
        [Column(Name = "drug_id", IsPrimaryKey = true)]
        public int DrugId { get; set; }

        [Column(Name = "daytime", IsPrimaryKey = true)]
        public DateTime Date { get; set; }

        public string Info { get; set; }

        public DoctorsPrescription Build(DoctorsPrescription dp, MUser user, Doctor doctor)
        {
            if(dp!=null)
            {
                dp.UserName = user.Name;
                dp.UserSurname = user.Surname;
                dp.DoctorName = doctor.Name;
                dp.DoctorSurname = doctor.Surname;
            }
            return dp;
        }
    }
}
