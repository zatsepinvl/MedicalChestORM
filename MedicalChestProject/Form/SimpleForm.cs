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
    public partial class SimpleForm : Form
    {
        public SimpleForm()
        {
            InitializeComponent();
        }
        protected MedicalChestManeger DManeger = MedicalChestManeger.Instance;
        private void MainSettingsButtonClick(object sender, EventArgs e)
        {
            FullSettingsForm settingsForm = new FullSettingsForm();
            settingsForm.Show();
        }
        private void SimpleFormLoad(object sender, EventArgs e)
        {
            Init();
        }
        protected virtual void Init()
        {
            statusLabel.Text = DManeger.State;
            DManeger.ErrorSend += DManegerErrorSend;
            DManeger.MessageSend += DManegerMessageSend;
            DManeger.StateChange += DManegerStateChange;
        }
        private void DManegerStateChange(string obj)
        {
            statusLabel.Text = obj;
        }
        private void DManegerMessageSend(string obj)
        {
            MessageBox.Show(obj);
        }
        private void DManegerErrorSend(string obj)
        {
            errorLabel.Text = obj;
        }

        protected virtual void AddButtonClick(object sender, EventArgs e)
        {
            
        }

        protected virtual void DeleteButtonClick(object sender, EventArgs e)
        {

        }

        protected virtual void SaveButtonClick(object sender, EventArgs e)
        {

        }

    }
}
