using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToDB.DataProvider.MySql;


namespace MedicalChestProject
{
    public partial class StartForm : SimpleForm<MUsers, MUser>
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartFormLoad(object sender, EventArgs e)
        {
            Init();
            InitControls();
        }
        protected override void Init()
        {
            formManeger = new FormOrganizator(this);
            tableManeger = DbManeger.Users;
            base.Init();
        }
        protected override void InitControls()
        {
            base.InitControls();
            goBackButton.Visible = false;
            RefreshData();
        }
        
        protected override void RefreshData()
        {
            userComboBox.SelectedIndex = -1;
            userComboBox.Items.Clear();
            int i = 1;
            foreach (MUser u in tableManeger.GetData())
            {
                userComboBox.Items.Add(i++ + ". " + u.Name + " " + u.Surname);
            }
        }
        protected override void AddButtonClick(object sender, EventArgs e)
        {
            MUser m =new MUser();
            AddItemForm addForm  =new AddItemForm(m);
            if(addForm.ShowDialog()==DialogResult.OK)
            {
                tableManeger.Add(m);
                RefreshData();
            }
        }
        protected override void SaveButtonClick(object sender, EventArgs e)
        {
            tableManeger.SaveChanges();
            RefreshData();
        }
        protected override void DeleteButtonClick(object sender, EventArgs e)
        {
            int index = this.userComboBox.SelectedIndex;
            if(index>-1)
            {
                if (MessageBox.Show("Выдйствительно хотите удалить запись?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tableManeger.Remove(tableManeger.GetData()[index]);
                    RefreshData();
                }
            }
        }

        private void LogInButtonClick(object sender, EventArgs e)
        {
            if(userComboBox.SelectedIndex>-1)
            {
                BodyForm body = new BodyForm(tableManeger.GetData()[userComboBox.SelectedIndex]);
                formManeger.GoNext(body);
            }
        }




    }

}
