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
    public partial class BodyForm : SimpleForm<MUsers, MUser>
    {
        public BodyForm(MUser user)
        {
            InitializeComponent();
            this.user = user;
        }
        MUser user;
        const string wordUser = "Пользователь";
        private void BodyForm_Load(object sender, EventArgs e)
        {
            Init();
            InitControls();
        }

        protected override void InitControls()
        {
            base.InitControls();
            toolStrip.Visible = true;
            errorStaticLabel.Visible = false;
            statusStaticLabel.Visible = false;
            statusLabel.Visible = false;
            errorLabel.Visible = false;
            statusStrip.Items.Add(wordUser + ": " + user.Name + " " + user.Surname);
        }

        private void DrugsButtonClick(object sender, EventArgs e)
        {
            DrugsForm view = new DrugsForm();
            view.Owner = this;
            formManeger.GoNext(view);
        }

        private void diseaseButton_Click(object sender, EventArgs e)
        {
            DiseaseForm view = new DiseaseForm();
            view.Owner = this;
            formManeger.GoNext(view);
        }



    }
}
