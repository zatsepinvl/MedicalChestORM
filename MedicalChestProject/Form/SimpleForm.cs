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
    public partial class SimpleForm<TTableManeger, TTable> : Form where TTableManeger : TableManeger<MedicalChest,TTable>
    {
        public SimpleForm()
        {
            InitializeComponent();
        }
        public static FormOrganizator formManeger;
        public const string AddingError = "Не удалось добавить новый элемент";
        public const string DeletingError = "Не удалось удалить выбранный элемент";
        public const string SavingError = "Не удалось сохранить изменения";

        protected MedicalChestManeger DbManeger = MedicalChestManeger.Instance;

        public TTableManeger tableManeger;
        
        private void MainSettingsButtonClick(object sender, EventArgs e)
        {
            FullSettingsForm settingsForm = new FullSettingsForm();
            settingsForm.Show();
        }

        //Init your tableManger;
        protected virtual void Init()
        {
            if (tableManeger != null)
            {
                Listen(tableManeger);
            }
            //Init your tableManger;
        }

        //Init all your controls;
        protected virtual void InitControls()
        {
            //Init all your controls;
        }

        //Listen for being informed about errors;
        protected virtual void Listen(ErrorMessageLogger<string> logger)
        {
            statusLabel.Text = logger.State;
            logger.ErrorSend += EMLErrorSend;
            logger.MessageSend += EMLMessageSend;
            logger.StateChange += EMLStateChange;
        }
        protected virtual void EMLStateChange(string obj)
        {
            if (this.Visible)
            {
                statusLabel.Text = obj;
            }
        }
        protected virtual void EMLMessageSend(string obj)
        {
            if (this.Visible)
            {
                MessageBox.Show(obj);
            }
        }
        protected virtual void EMLErrorSend(string obj)
        {
            if (this.Visible)
            {
                errorLabel.Text = obj;
            }
        }

        //Refresh showing data
        protected virtual void RefreshData()
        {

        }

        //Tool buttons event handlers

        //Should override
        protected virtual void AddButtonClick(object sender, EventArgs e)
        {

        }
        protected virtual void DeleteButtonClick(object sender, EventArgs e)
        {

        }
        protected virtual void SaveButtonClick(object sender, EventArgs e)
        {
            tableManeger.SaveChanges();
        }
        protected virtual void EditButtonClick(object sender, EventArgs e)
        {

        }

        //Shouldn't override
        protected virtual void RefreshButtonClick(object sender, EventArgs e)
        {
            RefreshData();
        }
        protected virtual void RollBackButtonClick(object sender, EventArgs e)
        {
            if (tableManeger != null)
            {
                tableManeger.Reload();
                RefreshData();
            }
        }
        protected virtual void GoBackButtonClick(object sender, EventArgs e)
        {
            formManeger.GoBack();
        }

        private void SimpleForm_Load(object sender, EventArgs e)
        {

        }

    }
}
