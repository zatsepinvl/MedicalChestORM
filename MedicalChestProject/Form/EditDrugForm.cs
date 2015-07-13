using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalChestProject
{
    public partial class EditDrugForm : Form
    {
        const string errorEditString = "Ошибка в заполнении полей.";
        public EditDrugForm(Drug item)
        {
            this.item = item;
            InitializeComponent();
        }
        Drug item;
        List<Storage> storages = MedicalChestManeger.Instance.Storages.GetData();
        List<ApplicationType> appTypes = MedicalChestManeger.Instance.AppTypes.GetData();
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditDrugForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            storageComboBox.Items.Clear();
            appTypeComboBox.Items.Clear();
            storageComboBox.Items.AddRange(storages.ToArray<Storage>());
            appTypeComboBox.Items.AddRange(appTypes.ToArray<ApplicationType>());
        }

        private void EditButtonClick(object sender, EventArgs e)
        {
            if ((storageComboBox.SelectedIndex > -1) && (appTypeComboBox.SelectedIndex > -1) && (nameTextBox.Text != "") && (infoTextBox.Text != ""))
            {
                Storage st = storages[storageComboBox.SelectedIndex];
                ApplicationType appType = appTypes[appTypeComboBox.SelectedIndex];
                item.Name = nameTextBox.Text;
                item.Info = infoTextBox.Text;
                item = Drug.Build(item, st, appType);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(errorEditString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancleButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
