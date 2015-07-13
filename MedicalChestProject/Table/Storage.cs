using System;
using LinqToDB.Mapping;
using System.ComponentModel;

namespace MedicalChestProject
{
    [Table]
    public class Storage
    {
        [Browsable(false)]
        [Column(Name = "storage_id", IsPrimaryKey = true)]
        public int StorageId { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public string Place { get; set; }

        public override string ToString()
        {
            return Name + " ( " + Place + " )";
        }
    }

}
