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
    public partial class DrugsForm : SimpleForm<Drugs, Drug>
    {
        const string diseaseButtonText = "Болезни";
        const string simptomButtonText = "Симптомы";
        public DrugsForm()
        {
            InitializeComponent();
        }
        DrugDiseaseForm drugDiseaseForm;
        private void DataViewForm_Load(object sender, EventArgs e)
        {
            Init();
            InitControls();
        }
        protected override void Init()
        {
            tableManeger = DbManeger.Drugs;
            base.Init();
        }
        protected override void InitControls()
        {
            base.InitControls();
            dataGridView.RowHeaderMouseClick += DataGridViewRowHeaderMouseClick;
            ToolStripButton diseaseButton = new ToolStripButton(diseaseButtonText);
            diseaseButton.CheckOnClick = true;
            diseaseButton.Click += DiseaseButtonClick;
            diseaseButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStrip.Items.Add(diseaseButton);
            RefreshData();
        }

        private void DataGridViewRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((drugDiseaseForm != null) && (drugDiseaseForm.Visible))
            {
                drugDiseaseForm.SetDrugId(tableManeger.GetData()[dataGridView.SelectedRows[0].Index].DrugId);
            }
        }
        private void DiseaseButtonClick(object sender, EventArgs e)
        {
            if (drugDiseaseForm == null)
            {
                drugDiseaseForm = new DrugDiseaseForm(false);
                drugDiseaseForm.Show();
            }
            else
            {
                drugDiseaseForm.Close();
                drugDiseaseForm = null;
            }
        }
        protected override void RefreshData()
        {
            dataGridView.DataSource = null;
            dataGridView.Refresh();
            dataGridView.DataSource = tableManeger.GetData();
        }
        protected override void AddButtonClick(object sender, EventArgs e)
        {
            Drug d = new Drug();
            EditDrugForm editDrugForm = new EditDrugForm(d);
            if (editDrugForm.ShowDialog() == DialogResult.OK)
            {
                tableManeger.Add(d);
                RefreshData();
            }
        }
        protected override void SaveButtonClick(object sender, EventArgs e)
        {
            if (tableManeger.NeedSaveChanges)
            {
                tableManeger.SaveChanges();
                RefreshData();
            }
            else
            {
                MessageBox.Show("Измнений нет.");
            }
        }
        protected override void DeleteButtonClick(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Выдйствительно хотите удалить запись?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tableManeger.Remove(tableManeger.GetData()[dataGridView.SelectedRows[0].Index]);
                    RefreshData();
                }
            }
        }
        
    }
}
