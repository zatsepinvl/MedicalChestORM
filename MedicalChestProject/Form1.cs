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
        MySqlDatabaseConnector databaseUser = new MySqlDatabaseConnector();
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = databaseUser.StringBuilder;
            toolStripStatusLabel1.Text = databaseUser.State;
            databaseUser.StateChange += new Action(databaseUser_StateChange);
            databaseUser.ErrorSend += new Action<string>(ErrorSend);
            databaseUser.MessageSend += new Action<string>(databaseUser_MessageSend);
        }

        void databaseUser_MessageSend(string obj)
        {
            MessageBox.Show(obj);
        }

        void ErrorSend(string obj)
        {
            toolStripStatusLabel4.Text = obj;
        }

        void databaseUser_StateChange()
        {
            toolStripStatusLabel1.Text = databaseUser.State;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            databaseUser.ConnectToDatabase();
            MySqlDatabaseTreeViewFormatter treeViewFormatter = new MySqlDatabaseTreeViewFormatter(databaseUser.Connection, treeView1, dataGridView1);
            treeViewFormatter.ErrorSend+=new Action<string>(ErrorSend);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource=databaseUser.GetResult(textBox1.Text);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = databaseUser.GetResult(textBox1.Text);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
