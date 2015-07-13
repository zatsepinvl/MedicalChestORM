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
    public partial class DrugDiseaseForm : SimpleForm<DrugDiseases, DrugDisease>

    {
        public DrugDiseaseForm(bool needGoBack)
        {
            this.needGoBack = needGoBack;
            InitializeComponent();
        }

        bool needGoBack;
        private void DrugDiseaseForm_Load(object sender, EventArgs e)
        {
            Init();
            InitControls();
        }

        protected override void Init()
        {
            tableManeger = DbManeger.DrugDiseases;
            SetDrugId(-1);
            base.Init();
        }
        protected override void InitControls()
        {
            base.InitControls();
            if (!needGoBack)
            {
                goBackButton.Visible = false;
            }
            RefreshData();
        }
        public void SetDrugId(int index)
        {
            tableManeger.Index = index;
            RefreshData();
        }
        protected override void RefreshData()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = tableManeger.GetData();
        }
        protected override void AddButtonClick(object sender, EventArgs e)
        {
            DrugDisease dd = new DrugDisease();
            DrugDiseaseEditForm addForm = new DrugDiseaseEditForm(dd);
            if(addForm.ShowDialog()==DialogResult.OK)
            {
                tableManeger.Add(dd);
                RefreshData();
            }
        }
    }
}
