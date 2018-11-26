namespace MichalSurmackiLab03Zad1
{
    partial class FormDoPayment
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPaymentValue = new System.Windows.Forms.TextBox();
            this.comboBoxChoose = new System.Windows.Forms.ComboBox();
            this.labelPaymentValue = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonDoPayment = new System.Windows.Forms.Button();
            this.labelChoose = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelUpLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelUpLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(71, 17);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Nazwisko:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(102, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(186, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxPaymentValue
            // 
            this.textBoxPaymentValue.Location = new System.Drawing.Point(102, 108);
            this.textBoxPaymentValue.Name = "textBoxPaymentValue";
            this.textBoxPaymentValue.Size = new System.Drawing.Size(186, 22);
            this.textBoxPaymentValue.TabIndex = 3;
            // 
            // comboBoxChoose
            // 
            this.comboBoxChoose.FormattingEnabled = true;
            this.comboBoxChoose.Location = new System.Drawing.Point(102, 3);
            this.comboBoxChoose.Name = "comboBoxChoose";
            this.comboBoxChoose.Size = new System.Drawing.Size(148, 24);
            this.comboBoxChoose.TabIndex = 0;
            this.comboBoxChoose.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoose_SelectedIndexChanged);
            // 
            // labelPaymentValue
            // 
            this.labelPaymentValue.AutoSize = true;
            this.labelPaymentValue.Location = new System.Drawing.Point(3, 105);
            this.labelPaymentValue.Name = "labelPaymentValue";
            this.labelPaymentValue.Size = new System.Drawing.Size(50, 17);
            this.labelPaymentValue.TabIndex = 7;
            this.labelPaymentValue.Text = "Kwota:";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(197, 185);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(113, 51);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Cofnij";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonDoPayment
            // 
            this.buttonDoPayment.Location = new System.Drawing.Point(12, 185);
            this.buttonDoPayment.Name = "buttonDoPayment";
            this.buttonDoPayment.Size = new System.Drawing.Size(113, 51);
            this.buttonDoPayment.TabIndex = 1;
            this.buttonDoPayment.Text = "Wpłać";
            this.buttonDoPayment.UseVisualStyleBackColor = true;
            this.buttonDoPayment.Click += new System.EventHandler(this.buttonDoPayment_Click);
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Location = new System.Drawing.Point(3, 0);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(53, 17);
            this.labelChoose.TabIndex = 4;
            this.labelChoose.Text = "Wybór:";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(3, 70);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(56, 17);
            this.labelNumber.TabIndex = 6;
            this.labelNumber.Text = "PESEL:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(102, 73);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(186, 22);
            this.textBoxNumber.TabIndex = 2;
            // 
            // tableLayoutPanelUpLayout
            // 
            this.tableLayoutPanelUpLayout.ColumnCount = 2;
            this.tableLayoutPanelUpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.54839F));
            this.tableLayoutPanelUpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.45161F));
            this.tableLayoutPanelUpLayout.Controls.Add(this.labelChoose, 0, 0);
            this.tableLayoutPanelUpLayout.Controls.Add(this.labelNumber, 0, 2);
            this.tableLayoutPanelUpLayout.Controls.Add(this.comboBoxChoose, 1, 0);
            this.tableLayoutPanelUpLayout.Controls.Add(this.textBoxPaymentValue, 1, 3);
            this.tableLayoutPanelUpLayout.Controls.Add(this.labelPaymentValue, 0, 3);
            this.tableLayoutPanelUpLayout.Controls.Add(this.textBoxNumber, 1, 2);
            this.tableLayoutPanelUpLayout.Controls.Add(this.textBoxName, 1, 1);
            this.tableLayoutPanelUpLayout.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanelUpLayout.Location = new System.Drawing.Point(12, 22);
            this.tableLayoutPanelUpLayout.Name = "tableLayoutPanelUpLayout";
            this.tableLayoutPanelUpLayout.RowCount = 4;
            this.tableLayoutPanelUpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelUpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelUpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelUpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelUpLayout.Size = new System.Drawing.Size(297, 136);
            this.tableLayoutPanelUpLayout.TabIndex = 0;
            // 
            // FormDoPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 262);
            this.Controls.Add(this.tableLayoutPanelUpLayout);
            this.Controls.Add(this.buttonDoPayment);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormDoPayment";
            this.Text = "Wpłacanie Raty";
            this.tableLayoutPanelUpLayout.ResumeLayout(false);
            this.tableLayoutPanelUpLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPaymentValue;
        private System.Windows.Forms.ComboBox comboBoxChoose;
        private System.Windows.Forms.Label labelPaymentValue;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDoPayment;
        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUpLayout;
    }
}