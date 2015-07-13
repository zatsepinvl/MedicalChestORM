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
        public ITable<Drug> Drug { get { return GetTable<Drug>(); } }
        public ITable<Storage> Storage { get { return GetTable<Storage>(); } }
        public ITable<ApplicationType> ApplicationType { get { return GetTable<ApplicationType>(); } }
        public ITable<DrugDisease> DrugDisease { get { return GetTable<DrugDisease>(); } }
        public ITable<Disease> Disease { get { return GetTable<Disease>(); } }
    }
}
