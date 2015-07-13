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
    public partial class DrugDiseaseEditForm : Form
    {
        const string errorEditString = "Ошибка в заполнении полей.";
        public DrugDiseaseEditForm(DrugDisease drugDisease)
        {
            this.drugDisease = drugDisease;
            InitializeComponent();
        }
        DrugDisease drugDisease;
        Diseases diseases;
        Drugs drugs;
        private void DrugDiseaseEditForm_Load(object sender, EventArgs e)
        {
            Init();
            InitControls();
        }

        private void Init()
        {
            diseases = MedicalChestManeger.Instance.Diseases;
            drugs = MedicalChestManeger.Instance.Drugs;
        }

        private void InitControls()
        {
            drugComboBox.Items.AddRange(drugs.GetData().ToArray());
            diseaseComboBox.Items.AddRange(diseases.GetData().ToArray());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if ((drugComboBox.SelectedIndex>-1)&&(diseaseComboBox.SelectedIndex>-1))
            {
                Drug d = drugs.GetData()[drugComboBox.SelectedIndex];
                Disease dis = diseases.GetData()[diseaseComboBox.SelectedIndex];
                drugDisease = DrugDisease.Build(drugDisease, d, dis);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(errorEditString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
