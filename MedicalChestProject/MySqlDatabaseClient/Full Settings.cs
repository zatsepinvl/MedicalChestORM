using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalChestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            DoubleBuffered = true;
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            databaseUser.Dispose();
        }
        ConnectionManeger databaseUser = new ConnectionManeger();
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = databaseUser.StringBuilder;
            toolStripStatusLabel1.Text = databaseUser.State;
            databaseUser.StateChange += new Action<string>(databaseUserStateChange);
            databaseUser.ErrorSend += new Action<string>(ErrorSend);
            databaseUser.MessageSend += new Action<string>(databaseUser_MessageSend);
            DatabaseObject.Connector = databaseUser;
        }

        void databaseUser_MessageSend(string obj)
        {
            MessageBox.Show(obj);
        }

        void ErrorSend(string obj)
        {
            toolStripStatusLabel4.Text = obj;
        }

        void databaseUserStateChange(string arg)
        {
            toolStripStatusLabel1.Text = databaseUser.State;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            databaseUser.OpenConnection();
            MySqlDatabaseTreeViewFormatter treeViewFormatter = new MySqlDatabaseTreeViewFormatter(treeView1, dataGridView1);
            treeViewFormatter.ErrorSend+=new Action<string>(ErrorSend);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource=databaseUser.GetDataTable(textBox1.Text);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = databaseUser.GetDataTable(textBox1.Text);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicalChest data = new MedicalChest(databaseUser.Connection);
            MUser user = new MUser();
            var qur = from u in data.MUser
                      select u;
            DataTable datat = new DataTable();

            qur.ToList<MUser>();
        }
    }
}
