using System;
using LinqToDB.Mapping;
using System.ComponentModel;


namespace MedicalChestProject
{
    [Table(Name="drug_applicationtype")]
    public class ApplicationType
    {
        [Column(Name = "apptype_id", IsPrimaryKey = true)]
        public int AppTypeId { get; set; }

        [Column(Name="apptype")]
        public string AppType { get; set; }

        public override string ToString()
        {
            return AppType;
        }
    }
}
