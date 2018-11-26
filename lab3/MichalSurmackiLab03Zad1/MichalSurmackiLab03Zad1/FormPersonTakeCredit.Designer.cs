namespace MichalSurmackiLab03Zad1
{
    partial class FormPersonTakeCredit
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCreditValue = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelCreditValue = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonTakeCredit = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelUpLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelUpLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(102, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(154, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxCreditValue
            // 
            this.textBoxCreditValue.Location = new System.Drawing.Point(102, 108);
            this.textBoxCreditValue.Name = "textBoxCreditValue";
            this.textBoxCreditValue.Size = new System.Drawing.Size(154, 22);
            this.textBoxCreditValue.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(102, 38);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(154, 22);
            this.textBoxSurname.TabIndex = 1;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(3, 35);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(71, 17);
            this.labelSurname.TabIndex = 5;
            this.labelSurname.Text = "Nazwisko:";
            // 
            // labelCreditValue
            // 
            this.labelCreditValue.AutoSize = true;
            this.labelCreditValue.Location = new System.Drawing.Point(3, 105);
            this.labelCreditValue.Name = "labelCreditValue";
            this.labelCreditValue.Size = new System.Drawing.Size(50, 17);
            this.labelCreditValue.TabIndex = 7;
            this.labelCreditValue.Text = "Kwota:";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(181, 175);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(99, 43);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Cofnij";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonTakeCredit
            // 
            this.buttonTakeCredit.Location = new System.Drawing.Point(21, 175);
            this.buttonTakeCredit.Name = "buttonTakeCredit";
            this.buttonTakeCredit.Size = new System.Drawing.Size(92, 43);
            this.buttonTakeCredit.TabIndex = 1;
            this.buttonTakeCredit.Text = "Weź Kredyt";
            this.buttonTakeCredit.UseVisualStyleBackColor = true;
            this.buttonTakeCredit.Click += new System.EventHandler(this.buttonTakeCredit_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 17);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Imię:";
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
            this.textBoxNumber.Size = new System.Drawing.Size(154, 22);
            this.textBoxNumber.TabIndex = 2;
            // 
            // tableLayoutPanelUpLayout
            // 
            this.tableLayoutPanelUpLayout.ColumnCount = 2;
            this.tableLayoutPanelUpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.22394F));
            this.tableLayoutPanelUpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.77606F));
            this.tableLayoutPanelUpLayout.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanelUpLayout.Controls.Add(this.textBoxNumber, 1, 2);
            this.tableLayoutPanelUpLayout.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanelUpLayout.Controls.Add(this.textBoxCreditValue, 1, 3);
            this.tableLayoutPanelUpLayout.Controls.Add(this.textBoxSurname, 1, 1);
            this.tableLayoutPanelUpLayout.Controls.Add(this.labelSurname, 0, 1);
            this.tableLayoutPanelUpLayout.Controls.Add(this.labelCreditValue, 0, 3);
            this.tableLayoutPanelUpLayout.Controls.Add(this.labelNumber, 0, 2);
            this.tableLayoutPanelUpLayout.Location = new System.Drawing.Point(21, 28);
            this.tableLayoutPanelUpLayout.Name = "tableLayoutPanelUpLayout";
            this.tableLayoutPanelUpLayout.RowCount = 4;
            this.tableLayoutPanelUpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelUpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelUpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelUpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelUpLayout.Size = new System.Drawing.Size(259, 141);
            this.tableLayoutPanelUpLayout.TabIndex = 0;
            // 
            // FormPersonTakeCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 233);
            this.Controls.Add(this.tableLayoutPanelUpLayout);
            this.Controls.Add(this.buttonTakeCredit);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormPersonTakeCredit";
            this.Text = "Udzielanie Kredytu";
            this.tableLayoutPanelUpLayout.ResumeLayout(false);
            this.tableLayoutPanelUpLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCreditValue;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelCreditValue;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonTakeCredit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUpLayout;
    }
}