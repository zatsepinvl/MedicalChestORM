using System;
using LinqToDB.Mapping;
using System.ComponentModel;
namespace MedicalChestProject
{
    [Table]
    public class MUser
    {
        [Column(IsPrimaryKey=true, Name="user_id")]
        public int UserId { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public string Surname { get; set; }

        [Column]
        public DateTime Birthday { get; set; }

    }
}
