using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.Entity;
using LinqToDB.Mapping;
namespace MedicalChestProject
{
    [Table]
    public class MUser:DatabaseObject
    {
        [Column]
        public string Name { get; set; }

        [Column]
        public string Surname { get; set; }

        [Column]
        public DateTime Birthday { get; set; }

        public override void LoadData()
        {
            try
            {

            }
            catch { }
        }
    }
}
