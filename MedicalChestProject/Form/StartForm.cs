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
    public partial class StartForm : SimpleForm
    {
        public StartForm()
        {
            InitializeComponent();
        }
        DataCollection<MUser> users;
        private void StartFormLoad(object sender, EventArgs e)
        {
        }

        protected override void Init()
        {
            base.Init();
            users = DbManeger.GetUsers();
            LoadUsers();
        }
        private void LoadUsers()
        {
            userComboBox.Items.Clear();
            int i = 1;
            foreach (MUser u in users)
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
                users.Add(m);
                LoadUsers();
            }
        }
        protected override void SaveButtonClick(object sender, EventArgs e)
        {
            DbManeger.Users.SaveChanges();
        }
    }

}
