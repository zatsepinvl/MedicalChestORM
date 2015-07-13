using System;
using System.Collections.Generic;
using LinqToDB.DataProvider.MySql;
using MySql.Data.MySqlClient;

namespace MedicalChestProject
{
    public class MedicalChestManeger : DatabaseManeger<MedicalChestManeger,MedicalChest, MySqlDataProvider, MySqlConnection>
    {
        public MUsers Users { get; protected set; }
        public Drugs Drugs { get; protected set; }
        public Storages Storages { get; protected set; }
        public AppTypes AppTypes { get; protected set; }
        public DrugDiseases DrugDiseases { get; protected set; }
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
            Loggers.Add(Users);

            Drugs = new Drugs();
            Loggers.Add(Drugs);

            Storages = new Storages();
            Loggers.Add(Storages);

            AppTypes = new AppTypes();
            Loggers.Add(AppTypes);

            DrugDiseases = new DrugDiseases();
            Loggers.Add(DrugDiseases);

            SingUpForPublisher(new ErrorMessageLogger<string>[] { Users, Drugs, Storages, AppTypes, DrugDiseases });
        }


    }
}
