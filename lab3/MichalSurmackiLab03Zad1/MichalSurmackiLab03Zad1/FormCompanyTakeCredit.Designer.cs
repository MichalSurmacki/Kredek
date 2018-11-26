namespace MichalSurmackiLab03Zad1
{
    partial class FormCompanyTakeCredit
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
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.buttonTakeCredit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelCreditValue = new System.Windows.Forms.Label();
            this.labelCompanyOwner = new System.Windows.Forms.Label();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.textBoxCreditValue = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelUpLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelUpLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(3, 0);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(54, 17);
            this.labelCompanyName.TabIndex = 4;
            this.labelCompanyName.Text = "Nazwa:";
            // 
            // buttonTakeCredit
            // 
            this.buttonTakeCredit.Location = new System.Drawing.Point(12, 158);
            this.buttonTakeCredit.Name = "buttonTakeCredit";
            this.buttonTakeCredit.Size = new System.Drawing.Size(99, 43);
            this.buttonTakeCredit.TabIndex = 1;
            this.buttonTakeCredit.Text = "Weź Kredyt";
            this.buttonTakeCredit.UseVisualStyleBackColor = true;
            this.buttonTakeCredit.Click += new System.EventHandler(this.buttonTakeCredit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(228, 158);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(99, 43);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Cofnij";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
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
            // labelCompanyOwner
            // 
            this.labelCompanyOwner.AutoSize = true;
            this.labelCompanyOwner.Location = new System.Drawing.Point(3, 35);
            this.labelCompanyOwner.Name = "labelCompanyOwner";
            this.labelCompanyOwner.Size = new System.Drawing.Size(74, 17);
            this.labelCompanyOwner.TabIndex = 5;
            this.labelCompanyOwner.Text = "Właściciel:";
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(98, 38);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(208, 22);
            this.textBoxOwner.TabIndex = 1;
            // 
            // textBoxCreditValue
            // 
            this.textBoxCreditValue.Location = new System.Drawing.Point(98, 108);
            this.textBoxCreditValue.Name = "textBoxCreditValue";
            this.textBoxCreditValue.Size = new System.Drawing.Size(208, 22);
            this.textBoxCreditValue.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(98, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(208, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(3, 70);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(34, 17);
            this.labelNumber.TabIndex = 6;
            this.labelNumber.Text = "NIP:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(98, 73);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(208, 22);
            this.textBoxNumber.TabIndex = 2;
            // 
            // tableLayoutPanelUpLayout
            // 
            this.tableLayoutPanelUpLayout.ColumnCount = 2;
            this.tableLayoutPanelUpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanelUpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanelUpLayout.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanelUpLayout.Controls.Add(this.labelCompanyName, 0, 0);
            this.tableLayoutPanelUpLayout.Controls.Add(this.labelNumber, 0, 2);
            this.tableLayoutPanelUpLayout.Controls.Add(this.textBoxNumber, 1, 2);
            this.tableLayoutPanelUpLayout.Controls.Add(this.textBoxOwner, 1, 1);
            this.tableLayoutPanelUpLayout.Controls.Add(this.labelCompanyOwner, 0, 1);
            this.tableLayoutPanelUpLayout.Controls.Add(this.textBoxCreditValue, 1, 3);
            this.tableLayoutPanelUpLayout.Controls.Add(this.labelCreditValue, 0, 3);
            this.tableLayoutPanelUpLayout.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelUpLayout.Name = "tableLayoutPanelUpLayout";
            this.tableLayoutPanelUpLayout.RowCount = 4;
            this.tableLayoutPanelUpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelUpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelUpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelUpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelUpLayout.Size = new System.Drawing.Size(315, 140);
            this.tableLayoutPanelUpLayout.TabIndex = 0;
            // 
            // FormCompanyTakeCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 211);
            this.Controls.Add(this.tableLayoutPanelUpLayout);
            this.Controls.Add(this.buttonTakeCredit);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormCompanyTakeCredit";
            this.Text = "Udzielanie Kredytu";
            this.tableLayoutPanelUpLayout.ResumeLayout(false);
            this.tableLayoutPanelUpLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Button buttonTakeCredit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelCreditValue;
        private System.Windows.Forms.Label labelCompanyOwner;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.TextBox textBoxCreditValue;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUpLayout;
    }
}