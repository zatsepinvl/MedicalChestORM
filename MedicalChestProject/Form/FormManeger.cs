using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalChestProject
{
    public class FormOrganizator
    {
        public Form PreviousForm { get; private set; }
        public Form CurrentForm { get; private set; }
        public Form StarForm { get; private set; }
        public FormOrganizator(Form starForm)
        {
            PreviousForm = null;
            CurrentForm = starForm;
            this.StarForm = starForm;
        }

        public void GoNext(Form nextForm)
        {
            if (nextForm != null)
            {
               if(CurrentForm!=StarForm)
               {
                   CurrentForm.FormClosed -= CurrentFormFormClosed;
               }
                CurrentForm.Hide();
                PreviousForm = CurrentForm;
                CurrentForm = nextForm;
                nextForm.Show();
                CurrentForm.FormClosed += CurrentFormFormClosed;
            }
        }
        private void CurrentFormFormClosed(object sender, FormClosedEventArgs e)
        {
            if ((!PreviousForm.Visible))
            {
                CurrentForm.FormClosed -= CurrentFormFormClosed;
                Close();
            }
        }
        public void GoBack()
        {
            if (PreviousForm != null)
            {
                Form temp = CurrentForm.Owner;
                PreviousForm.Show();
                CurrentForm.Close();
                CurrentForm = PreviousForm;
                PreviousForm = temp;
                CurrentForm.FormClosed += CurrentFormFormClosed;
            }
        }
        private void Close()
        {
            StarForm.Close();
        }
    }
}
