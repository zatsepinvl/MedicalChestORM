using System;
using System.Collections.Generic;
using System.Threading;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace MedicalChestProject
{
    public class MySqlDatabaseUser : StateObject<string>, IDisposable
    {

        MySqlConnectionStringBuilder stringBuilder;
        MySqlConnection connection;

        public List<string> requestList = new List<string>();
        public MySqlConnectionStringBuilder StringBuilder { get { return stringBuilder; } }
        public MySqlConnection Connection { get { return connection; } }

        public override string State
        {
            get { return connection.State.ToString(); }
        }
        public MySqlDatabaseUser()
        {
            connection = new MySqlConnection();
            stringBuilder = new MySqlConnectionStringBuilder();
            connection.StateChange += new System.Data.StateChangeEventHandler(ConnectionStateChange);
            InitDefaultConnectionString();
        }

        private void InitDefaultConnectionString()
        {
            stringBuilder.Server = "localhost";
            stringBuilder.Port = 3306;
            stringBuilder.Database = "medicinechest";
            stringBuilder.UserID = "root";
            stringBuilder.Password = "admin";

        }
        private void ConnectionStateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            ChangeState();
        }

        public void ConnectToDatabase()
        {
            try
            {
                connection.Close();
            }

            finally
            {

                connection.ConnectionString = stringBuilder.ConnectionString;
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    SendError(ex.Message);
                }
            }

        }

        public DataTable GetResult(string request)
        {
            DataTable data = new DataTable();
            MySqlDataReader reader = null;
            try
            {
                MySqlCommand command = new MySqlCommand(request, connection);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    data.Load(reader);
                }

            }
            catch (MySqlException ex)
            {
                SendError(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                SendError(ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            requestList.Add(request);
            return data;
        }

     
        public void Dispose()
        {
            try
            {
                connection.Close();
            }
            catch { }
        }
    }
}
