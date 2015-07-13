using System;
using System.Collections.Generic;
using System.Threading;
using System.Data;
using MySql.Data.MySqlClient;

namespace MedicalChestProject
{
    public class ConnectionManeger : Singleton<ConnectionManeger,string>, IDisposable
    {

        public MySqlConnectionStringBuilder StringBuilder { get; protected set; }
        public MySqlConnection Connection { get; set; }

        public override string State
        {
            get { return Connection.State.ToString(); }
        }
        protected ConnectionManeger()
        {
            Connection = new MySqlConnection();
            StringBuilder = new MySqlConnectionStringBuilder();
            Connection.StateChange += new System.Data.StateChangeEventHandler(ConnectionStateChange);
            InitDefaultConnectionString();
        }
        private void InitDefaultConnectionString()
        {
            StringBuilder.Server = "localhost";
            StringBuilder.Port = 3306;
            StringBuilder.Database = "medicalchest";
            StringBuilder.UserID = "root";
            StringBuilder.Password = "admin";
            Connection.ConnectionString = StringBuilder.ConnectionString;
        }
        private void ConnectionStateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            InformStateChanged(e.CurrentState.ToString());
        }
        public void OpenConnection()
        {
            try
            {
                Connection.Close();
            }
            finally
            {

                Connection.ConnectionString = StringBuilder.ConnectionString;
                try
                {
                    Connection.Open();
                }
                catch (MySqlException ex)
                {
                    SendMessage(ex.Message);
                }
            }

        }
        public void CloseConnection()
        {
            try
            {
                Connection.Close();
            }
            catch (MySqlException ex)
            {
                SendMessage(ex.Message);
            }
        }
        public MySqlDataReader GetDataReader(MySqlCommand request)
        {
           MySqlDataReader reader = null;
           try
           {
               request.Connection = Connection;
               reader = request.ExecuteReader();
           }
           catch (MySqlException ex)
           {
               SendError(ex.Message);
           }
           finally
           {
           }
           return reader;
        }
        public DataTable GetDataTable(MySqlCommand request)
        {
            DataTable data = new DataTable();
            MySqlDataReader reader = null;
            try
            {
                request.Connection=Connection;
                reader = request.ExecuteReader();
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
            return data;
        }
        public DataTable GetDataTable(string request)
        {
            return GetDataTable(new MySqlCommand(request));
        }
        public void Dispose()
        {
            CloseConnection();
        }
        public void SetConnectionStringBuilder(MySqlConnectionStringBuilder stringBuilder)
        {
            Connection.ConnectionString = stringBuilder.ConnectionString;
            this.StringBuilder = stringBuilder;
        }

    }
}
