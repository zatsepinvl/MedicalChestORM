using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace MedicalChestProject
{
    public class MySqlDatabaseTreeViewFormatter:ErrorMessageLogger<string>
    {
        public const string showTables = "show tables;";
        public const string showColumns = "show columns from ";
        public const string describeColumns = "describe ";
        public static ConnectionManeger Connector { get; set; }
        TreeView Tree { get; set; }
        DataGridView DataGrid { get; set; }

        public MySqlDatabaseTreeViewFormatter(TreeView tree, DataGridView dataGrid)
        {
            this.Tree = tree;
            this.DataGrid = dataGrid;
            InitTree();
            tree.NodeMouseClick+=new TreeNodeMouseClickEventHandler(TreeNodeMouseClick);
        }
        public void InitTree()
        {
            Tree.Nodes.Clear();
            MySqlDataReader reader = null;
            try
            {
                MySqlCommand getTables = new MySqlCommand(showTables);
                reader = Connector.GetDataReader(getTables);
                int i = 0;
                while (reader.Read())
                {
                    string temp = reader.GetString(i);
                    Tree.Nodes.Add(temp);
                }
                reader.Close();
                foreach (TreeNode node in Tree.Nodes)
                {
                    MySqlCommand getColumns = new MySqlCommand(showColumns + node.Text + ";");
                    reader = Connector.GetDataReader(getColumns);
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
        }

    }
}
