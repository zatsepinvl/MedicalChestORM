namespace MedicalChestProject
{
    partial class BodyForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.drugsButton = new System.Windows.Forms.Button();
            this.doctorButton = new System.Windows.Forms.Button();
            this.diseaseButton = new System.Windows.Forms.Button();
            this.simptomButton = new System.Windows.Forms.Button();
            this.mtoolButton = new System.Windows.Forms.Button();
            this.prescriprionButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.drugsButton, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.doctorButton, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.diseaseButton, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.simptomButton, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.mtoolButton, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.prescriprionButton, 1, 1);
            this.tableLayoutPanel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel.Location = new System.Drawing.Point(10, 58);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1013, 406);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // drugsButton
            // 
            this.drugsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drugsButton.AutoSize = true;
            this.drugsButton.Location = new System.Drawing.Point(3, 2);
            this.drugsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drugsButton.Name = "drugsButton";
            this.drugsButton.Size = new System.Drawing.Size(247, 199);
            this.drugsButton.TabIndex = 0;
            this.drugsButton.Text = "Лекарства";
            this.drugsButton.UseVisualStyleBackColor = true;
            this.drugsButton.Click += new System.EventHandler(this.DrugsButtonClick);
            // 
            // doctorButton
            // 
            this.doctorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doctorButton.AutoSize = true;
            this.doctorButton.Location = new System.Drawing.Point(256, 2);
            this.doctorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doctorButton.Name = "doctorButton";
            this.doctorButton.Size = new System.Drawing.Size(247, 199);
            this.doctorButton.TabIndex = 1;
            this.doctorButton.Text = "Доктора";
            this.doctorButton.UseVisualStyleBackColor = true;
            // 
            // diseaseButton
            // 
            this.diseaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diseaseButton.Location = new System.Drawing.Point(509, 3);
            this.diseaseButton.Name = "diseaseButton";
            this.diseaseButton.Size = new System.Drawing.Size(247, 197);
            this.diseaseButton.TabIndex = 2;
            this.diseaseButton.Text = "Болезни";
            this.diseaseButton.UseVisualStyleBackColor = true;
            this.diseaseButton.Click += new System.EventHandler(this.diseaseButton_Click);
            // 
            // simptomButton
            // 
            this.simptomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simptomButton.Location = new System.Drawing.Point(762, 3);
            this.simptomButton.Name = "simptomButton";
            this.simptomButton.Size = new System.Drawing.Size(248, 197);
            this.simptomButton.TabIndex = 3;
            this.simptomButton.Text = "Симптомы";
            this.simptomButton.UseVisualStyleBackColor = true;
            // 
            // mtoolButton
            // 
            this.mtoolButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtoolButton.Location = new System.Drawing.Point(3, 206);
            this.mtoolButton.Name = "mtoolButton";
            this.mtoolButton.Size = new System.Drawing.Size(247, 197);
            this.mtoolButton.TabIndex = 4;
            this.mtoolButton.Text = "Медицинские принадлежности";
            this.mtoolButton.UseVisualStyleBackColor = true;
            // 
            // prescriprionButton
            // 
            this.prescriprionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prescriprionButton.Location = new System.Drawing.Point(256, 206);
            this.prescriprionButton.Name = "prescriprionButton";
            this.prescriprionButton.Size = new System.Drawing.Size(247, 197);
            this.prescriprionButton.TabIndex = 5;
            this.prescriprionButton.Text = "Назначения врача";
            this.prescriprionButton.UseVisualStyleBackColor = true;
            // 
            // BodyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 491);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "BodyForm";
            this.Text = "Домашняя аптечка";
            this.Load += new System.EventHandler(this.BodyForm_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel, 0);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button drugsButton;
        private System.Windows.Forms.Button doctorButton;
        private System.Windows.Forms.Button diseaseButton;
        private System.Windows.Forms.Button simptomButton;
        private System.Windows.Forms.Button mtoolButton;
        private System.Windows.Forms.Button prescriprionButton;
    }
}