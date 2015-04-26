using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace MedicalChestProject
{
    public class MySqlDatabaseTreeViewFormatter:DatabaseObject
    {
        public const string showTables = "show tables;";
        public const string showColumns = "show columns from ";
        public const string describeColumns = "describe ";
        TreeView Tree { get; set; }
        DataGridView DataGrid { get; set; }

        public MySqlDatabaseTreeViewFormatter(MySqlConnection connection, TreeView tree, DataGridView dataGrid):base(connection)
        {
            this.Connection = connection;
            this.Tree = tree;
            this.DataGrid = dataGrid;
            InitTree();
            tree.NodeMouseClick+=new TreeNodeMouseClickEventHandler(TreeNodeMouseClick);
        }
        public void InitTree()
        {
            MySqlDataReader reader = null;
            try
            {
                MySqlCommand getTables = new MySqlCommand(showTables, Connection);
                reader = getTables.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    string temp = reader.GetString(i);
                    Tree.Nodes.Add(temp);
                }
                reader.Close();
                foreach (TreeNode node in Tree.Nodes)
                {
                    MySqlCommand getColumns = new MySqlCommand(showColumns + node.Text + ";", Connection);
                    reader = getColumns.ExecuteReader();
                    while (reader.Read())
                    {
                        string temp = reader.GetString(0);
                        node.Nodes.Add(temp);
                    }
                    reader.Close();
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
        }

        private void TreeNodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                if(e.Node.Text == "doctor")
                {
                   Doctor doctor = new Doctor(Connection);
                   DataGrid.DataSource = doctor.GetData();
                }
            }
        }
    }
}
