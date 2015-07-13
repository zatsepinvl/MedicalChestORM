namespace MedicalChestProject
{
    partial class SimpleForm<TTableManeger, TTable>
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.goBackButton = new System.Windows.Forms.ToolStripButton();
            this.mainSettingsButton = new System.Windows.Forms.ToolStripButton();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.editButton = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.rollBackButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStaticLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorStaticLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(569, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackButton,
            this.mainSettingsButton,
            this.addButton,
            this.deleteButton,
            this.saveButton,
            this.editButton,
            this.refreshButton,
            this.rollBackButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(569, 32);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // goBackButton
            // 
            this.goBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goBackButton.Image = global::MedicalChestProject.Properties.Resources.goBackButton;
            this.goBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(29, 29);
            this.goBackButton.Text = "Назад";
            this.goBackButton.Click += new System.EventHandler(this.GoBackButtonClick);
            // 
            // mainSettingsButton
            // 
            this.mainSettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainSettingsButton.Image = global::MedicalChestProject.Properties.Resources.settingsButton;
            this.mainSettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainSettingsButton.Name = "mainSettingsButton";
            this.mainSettingsButton.Size = new System.Drawing.Size(29, 29);
            this.mainSettingsButton.Text = "Настройки";
            this.mainSettingsButton.Click += new System.EventHandler(this.MainSettingsButtonClick);
            // 
            // addButton
            // 
            this.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addButton.Image = global::MedicalChestProject.Properties.Resources.addButton;
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(29, 29);
            this.addButton.Text = "Добавить";
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = global::MedicalChestProject.Properties.Resources.deleteButton;
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(29, 29);
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = global::MedicalChestProject.Properties.Resources.saveButton1;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(29, 29);
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // editButton
            // 
            this.editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editButton.Image = global::MedicalChestProject.Properties.Resources.editButton;
            this.editButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(29, 29);
            this.editButton.Text = "Изменить";
            this.editButton.Click += new System.EventHandler(this.EditButtonClick);
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton.Image = global::MedicalChestProject.Properties.Resources.refreshButton;
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(29, 29);
            this.refreshButton.Text = "Обновить";
            this.refreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
            // 
            // rollBackButton
            // 
            this.rollBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rollBackButton.Image = global::MedicalChestProject.Properties.Resources.goBackButton;
            this.rollBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rollBackButton.Name = "rollBackButton";
            this.rollBackButton.Size = new System.Drawing.Size(29, 29);
            this.rollBackButton.Text = "Отменить изменения";
            this.rollBackButton.Click += new System.EventHandler(this.RollBackButtonClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStaticLabel,
            this.statusLabel,
            this.errorStaticLabel,
            this.errorLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 457);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip.Size = new System.Drawing.Size(569, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusStaticLabel
            // 
            this.statusStaticLabel.Name = "statusStaticLabel";
            this.statusStaticLabel.Size = new System.Drawing.Size(52, 20);
            this.statusStaticLabel.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // errorStaticLabel
            // 
            this.errorStaticLabel.Name = "errorStaticLabel";
            this.errorStaticLabel.Size = new System.Drawing.Size(44, 20);
            this.errorStaticLabel.Text = "Error:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoToolTip = true;
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // SimpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(569, 482);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SimpleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleForm";
            this.Load += new System.EventHandler(this.SimpleForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.MenuStrip menuStrip;
        protected System.Windows.Forms.ToolStrip toolStrip;
        protected System.Windows.Forms.StatusStrip statusStrip;
        protected System.Windows.Forms.ToolStripButton mainSettingsButton;
        protected System.Windows.Forms.ToolStripStatusLabel statusLabel;
        protected System.Windows.Forms.ToolStripStatusLabel errorLabel;
        protected System.Windows.Forms.ToolStripButton addButton;
        protected System.Windows.Forms.ToolStripButton deleteButton;
        protected System.Windows.Forms.ToolStripButton saveButton;
        protected System.Windows.Forms.ToolStripStatusLabel statusStaticLabel;
        protected System.Windows.Forms.ToolStripStatusLabel errorStaticLabel;
        protected System.Windows.Forms.ToolStripButton goBackButton;
        protected System.Windows.Forms.ToolStripButton editButton;
        protected System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStripButton rollBackButton;
    }
}