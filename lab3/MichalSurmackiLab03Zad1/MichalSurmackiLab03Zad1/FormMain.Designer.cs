namespace MichalSurmackiLab03Zad1
{
    partial class FormMain
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
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.comboBoxData = new System.Windows.Forms.ComboBox();
            this.buttonPersonTakeCredit = new System.Windows.Forms.Button();
            this.buttonCompanyTakeCredit = new System.Windows.Forms.Button();
            this.buttonDoPayment = new System.Windows.Forms.Button();
            this.tableLayoutPanelUpLayout = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.tableLayoutPanelUpLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(36, 88);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(724, 321);
            this.dataGridViewData.TabIndex = 0;
            // 
            // comboBoxData
            // 
            this.comboBoxData.FormattingEnabled = true;
            this.comboBoxData.Location = new System.Drawing.Point(3, 3);
            this.comboBoxData.Name = "comboBoxData";
            this.comboBoxData.Size = new System.Drawing.Size(192, 24);
            this.comboBoxData.TabIndex = 0;
            this.comboBoxData.SelectedIndexChanged += new System.EventHandler(this.comboBoxData_SelectedIndexChanged);
            // 
            // buttonPersonTakeCredit
            // 
            this.buttonPersonTakeCredit.Location = new System.Drawing.Point(288, 3);
            this.buttonPersonTakeCredit.Name = "buttonPersonTakeCredit";
            this.buttonPersonTakeCredit.Size = new System.Drawing.Size(141, 40);
            this.buttonPersonTakeCredit.TabIndex = 1;
            this.buttonPersonTakeCredit.Text = "Kredyt na Osobę";
            this.buttonPersonTakeCredit.UseVisualStyleBackColor = true;
            this.buttonPersonTakeCredit.Click += new System.EventHandler(this.buttonPersonTakeCredit_Click);
            // 
            // buttonCompanyTakeCredit
            // 
            this.buttonCompanyTakeCredit.Location = new System.Drawing.Point(438, 3);
            this.buttonCompanyTakeCredit.Name = "buttonCompanyTakeCredit";
            this.buttonCompanyTakeCredit.Size = new System.Drawing.Size(141, 40);
            this.buttonCompanyTakeCredit.TabIndex = 2;
            this.buttonCompanyTakeCredit.Text = "Kredyt na Firmę";
            this.buttonCompanyTakeCredit.UseVisualStyleBackColor = true;
            this.buttonCompanyTakeCredit.Click += new System.EventHandler(this.buttonCompanyTakeCredit_Click);
            // 
            // buttonDoPayment
            // 
            this.buttonDoPayment.Location = new System.Drawing.Point(588, 3);
            this.buttonDoPayment.Name = "buttonDoPayment";
            this.buttonDoPayment.Size = new System.Drawing.Size(133, 40);
            this.buttonDoPayment.TabIndex = 3;
            this.buttonDoPayment.Text = "Wpłać Ratę";
            this.buttonDoPayment.UseVisualStyleBackColor = true;
            this.buttonDoPayment.Click += new System.EventHandler(this.buttonDoPayment_Click);
            // 
            // tableLayoutPanelUpLayout
            // 
            this.tableLayoutPanelUpLayout.ColumnCount = 4;
            this.tableLayoutPanelUpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285F));
            this.tableLayoutPanelUpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelUpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelUpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelUpLayout.Controls.Add(this.buttonDoPayment, 3, 0);
            this.tableLayoutPanelUpLayout.Controls.Add(this.comboBoxData, 0, 0);
            this.tableLayoutPanelUpLayout.Controls.Add(this.buttonCompanyTakeCredit, 2, 0);
            this.tableLayoutPanelUpLayout.Controls.Add(this.buttonPersonTakeCredit, 1, 0);
            this.tableLayoutPanelUpLayout.Location = new System.Drawing.Point(36, 30);
            this.tableLayoutPanelUpLayout.Name = "tableLayoutPanelUpLayout";
            this.tableLayoutPanelUpLayout.RowCount = 1;
            this.tableLayoutPanelUpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUpLayout.Size = new System.Drawing.Size(724, 52);
            this.tableLayoutPanelUpLayout.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelUpLayout);
            this.Controls.Add(this.dataGridViewData);
            this.Name = "FormMain";
            this.Text = "System Zarządzania Kredytami";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.tableLayoutPanelUpLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.ComboBox comboBoxData;
        private System.Windows.Forms.Button buttonPersonTakeCredit;
        private System.Windows.Forms.Button buttonCompanyTakeCredit;
        private System.Windows.Forms.Button buttonDoPayment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUpLayout;
    }
}

