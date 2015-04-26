using System;
using System.Collections.Generic;
using LinqToDB.DataProvider.MySql;
using MySql.Data.MySqlClient;

namespace MedicalChestProject
{
    public class MedicalChestManeger : DatabaseManeger<MedicalChestManeger,MedicalChest, MySqlDataProvider, MySqlConnection>
    {
        public MUsers Users { get; protected set; }

        protected MedicalChestManeger()
        {
            Init();
        }

        protected override void InitDatabase()
        {
            MedicalChest.DataProvider = new MySqlDataProvider();
            MedicalChest.Connection = ConnectionManeger.Connection;
        }
        protected override void InitTableManegers()
        {
            Users = new MUsers();
            SingUpForPublisher(new ErrorMessageLogger<string>[] { Users });
        }

        public DataCollection<MUser> GetUsers()
        {
            return Users.GetData();
        }

    }
}
