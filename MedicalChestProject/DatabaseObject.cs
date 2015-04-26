using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MedicalChestProject
{
    public abstract class DatabaseObject:ErrorMessageLogger<string>
    {
        public static ConnectionManeger Connector;
        public abstract void LoadData();
    }
}
