using System;
using LinqToDB.Mapping;
using System.ComponentModel;

namespace MedicalChestProject
{
    [Table]
    public class Disease
    {
        [Browsable(false)]
        [Column(Name = "disease_id", IsPrimaryKey = true)]
        public int DiseaseId { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public string Info { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
