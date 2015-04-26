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
    public partial class AddItemForm: Form
    {
        public AddItemForm(Object item)
        {
            InitializeComponent();
            this.item = item;
            propertyGrid1.SelectedObject = item;
        }

        Object item;

        private void SaveButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
