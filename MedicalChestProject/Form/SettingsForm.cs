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
    public partial class FullSettingsForm : Form
    {
        MySqlDatabaseTreeViewFormatter treeViewFormatter;
        public FullSettingsForm()
        {
            connectionManeger = ConnectionManeger.Instance;
            MySqlDatabaseTreeViewFormatter.Connector = connectionManeger;
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            DoubleBuffered = true;
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connectionManeger.Dispose();
        }
        ConnectionManeger connectionManeger;
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = connectionManeger.StringBuilder;
            toolStripStatusLabel1.Text = connectionManeger.State;
            connectionManeger.StateChange += new Action<string>(databaseUserStateChange);
            connectionManeger.ErrorSend += new Action<string>(ErrorSend);
            connectionManeger.MessageSend += new Action<string>(databaseUser_MessageSend);
            treeViewFormatter = new MySqlDatabaseTreeViewFormatter(treeView1, dataGridView1);
            treeViewFormatter.ErrorSend += new Action<string>(ErrorSend);
            this.FormClosing += FullSettingsForm_FormClosing;

            foreach (ErrorMessageLogger<string> eml in MedicalChestManeger.Instance.Loggers)
            {
                listBox1.Items.Add(eml.ToString());
            }
        }

        void FullSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connectionManeger.CloseConnection();
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
            toolStripStatusLabel1.Text = connectionManeger.State;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            connectionManeger.OpenConnection();
            treeViewFormatter.InitTree();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = connectionManeger.GetDataTable(textBox1.Text);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = connectionManeger.GetDataTable(textBox1.Text);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("Errors", "Errors");
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foreach (string s in MedicalChestManeger.Instance.Loggers[listBox1.SelectedIndex].ErrorList)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void refreshLogButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Errors", "Errors");
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foreach (string s in MedicalChestManeger.Instance.Loggers[listBox1.SelectedIndex].ErrorList)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

    }
}
