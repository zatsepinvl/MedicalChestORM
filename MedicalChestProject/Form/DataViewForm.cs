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
    public partial class DataViewForm: SimpleForm
    {
        public DataViewForm():base()
        {
            InitializeComponent();
        }
        Drugs drugs;
        private void DataViewForm_Load(object sender, EventArgs e)
        {
            drugs = DbManeger.Drugs;
            dataGridView.DataSource = drugs.GetData();
        }
    }
}
