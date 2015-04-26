using System;
using System.Data;
using LinqToDB.Data;
using LinqToDB;
using LinqToDB.DataProvider.MySql;
using MySql.Data.MySqlClient;

namespace MedicalChestProject
{
    public class MedicalChest : Database<MySqlDataProvider, MySqlConnection>
    {
        public ITable<MUser> MUser { get { return GetTable<MUser>(); } }
    }
}
