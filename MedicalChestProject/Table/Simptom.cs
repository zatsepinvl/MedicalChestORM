using System;
using LinqToDB.Mapping;
using System.ComponentModel;

namespace MedicalChestProject
{
    [Table]
    public class Simptom
    {
        [Column(Name="simptom_id", IsPrimaryKey=true)]
        public int SimptomId { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public string Info { get; set; }
    }
}
