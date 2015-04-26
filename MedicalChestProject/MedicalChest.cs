using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB.Data;
using LinqToDB.Mapping;
using LinqToDB;
using MySql.Data.MySqlClient;
using LinqToDB.DataProvider.MySql;
namespace MedicalChestProject
{
    public class MedicalChest : DataConnection
    {
        public MedicalChest(MySqlConnection connection)
            : base(new MySqlDataProvider(), connection)
        {

        }

        public ITable<MUser> MUser { get { return GetTable<MUser>(); } }
    }
}
