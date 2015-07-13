using System;
using LinqToDB.Mapping;
using System.ComponentModel;

namespace MedicalChestProject
{
    [Table(Name="drug_disease")]
    public class DrugDisease
    {
        [Browsable(false)]
        [Column(Name = "drug_id", IsPrimaryKey = true)]
        public int DrugId { get; set; }

        [DisplayName("Лекарство")]
        public string DrugName { get; set; }

        [Browsable(false)]
        [Column(Name = "disease_id", IsPrimaryKey = true)]
        public int DiseaseId { get; set; }

        [DisplayName("Болезнь")]
        public string DiseaseName { get; set; }

        public string DiseaseInfo { get; set; }
        public static DrugDisease Build(DrugDisease dd, Drug drug, Disease disease)
        {
            if(dd!=null)
            {
                dd.DiseaseId = disease.DiseaseId;
                dd.DrugId = drug.DrugId;
                dd.DrugName = drug.Name;
                dd.DiseaseName = disease.Name;
                dd.DiseaseInfo = disease.Info;
            }
            return dd;
        }
    }
}
