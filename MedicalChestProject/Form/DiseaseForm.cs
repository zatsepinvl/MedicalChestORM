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
    public partial class DiseaseForm : SimpleForm<Diseases, Disease>
    {
        public DiseaseForm()
            : base()
        {
            InitializeComponent();
        }
        private void DiseaseForm_Load(object sender, EventArgs e)
        {
            Init();
            InitControls();
            dataGridView.CellMouseClick += DataGridViewCellMouseClick;
        }

        private void DataGridViewCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        protected override void Init()
        {
            tableManeger = DbManeger.Diseases;
            base.Init();
        }
        protected override void InitControls()
        {
            base.InitControls();
            RefreshData();
        }

        protected override void RefreshData()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = tableManeger.GetData();
        }
    }
}
