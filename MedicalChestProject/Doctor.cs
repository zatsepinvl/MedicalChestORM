using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace MedicalChestProject
{
    public class Doctor:DatabaseObject, IData
    {
        public const string mainSelect = "Select * from doctor;";
        public Doctor(MySqlConnection connection)
            : base(connection)
        {

        }


        public DataTable GetData()
        {
            DataTable data = new DataTable();
            MySqlCommand command = new MySqlCommand(mainSelect, Connection);
            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    data.Load(reader);
                    data.Columns.Remove(data.Columns[0]);
                }
            }
            catch (Exception ex)
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
    }
}
