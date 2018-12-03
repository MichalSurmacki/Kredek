namespace MichalSurmackiLab04
{
    partial class FormRegister
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
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxStudentsNumber = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelStudentsNumber = new System.Windows.Forms.Label();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.tableLayoutPanelMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanelMainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(185, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(171, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(185, 33);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(171, 22);
            this.textBoxSurname.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(185, 63);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(171, 22);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxStudentsNumber
            // 
            this.textBoxStudentsNumber.Location = new System.Drawing.Point(185, 93);
            this.textBoxStudentsNumber.Name = "textBoxStudentsNumber";
            this.textBoxStudentsNumber.Size = new System.Drawing.Size(171, 22);
            this.textBoxStudentsNumber.TabIndex = 3;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(185, 123);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(171, 22);
            this.textBoxUserName.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 17);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "NAME:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(3, 30);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(80, 17);
            this.labelSurname.TabIndex = 6;
            this.labelSurname.Text = "SURNAME:";
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(185, 153);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(171, 22);
            this.textBoxUserPassword.TabIndex = 7;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(3, 60);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 17);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "EMAIL:";
            // 
            // labelStudentsNumber
            // 
            this.labelStudentsNumber.AutoSize = true;
            this.labelStudentsNumber.Location = new System.Drawing.Point(3, 90);
            this.labelStudentsNumber.Name = "labelStudentsNumber";
            this.labelStudentsNumber.Size = new System.Drawing.Size(150, 17);
            this.labelStudentsNumber.TabIndex = 9;
            this.labelStudentsNumber.Text = "STUDENTS NUMBER:";
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Location = new System.Drawing.Point(3, 150);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(92, 17);
            this.labelUserPassword.TabIndex = 10;
            this.labelUserPassword.Text = "PASSWORD:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(3, 120);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(89, 17);
            this.labelUserName.TabIndex = 11;
            this.labelUserName.Text = "USERNAME:";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(185, 183);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(110, 44);
            this.buttonRegister.TabIndex = 12;
            this.buttonRegister.Text = "REGISTER";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // tableLayoutPanelMainLayout
            // 
            this.tableLayoutPanelMainLayout.ColumnCount = 2;
            this.tableLayoutPanelMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainLayout.Controls.Add(this.buttonCancel, 0, 6);
            this.tableLayoutPanelMainLayout.Controls.Add(this.buttonRegister, 1, 6);
            this.tableLayoutPanelMainLayout.Controls.Add(this.labelUserPassword, 0, 5);
            this.tableLayoutPanelMainLayout.Controls.Add(this.labelUserName, 0, 4);
            this.tableLayoutPanelMainLayout.Controls.Add(this.textBoxUserPassword, 1, 5);
            this.tableLayoutPanelMainLayout.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanelMainLayout.Controls.Add(this.textBoxSurname, 1, 1);
            this.tableLayoutPanelMainLayout.Controls.Add(this.labelStudentsNumber, 0, 3);
            this.tableLayoutPanelMainLayout.Controls.Add(this.textBoxUserName, 1, 4);
            this.tableLayoutPanelMainLayout.Controls.Add(this.labelSurname, 0, 1);
            this.tableLayoutPanelMainLayout.Controls.Add(this.labelEmail, 0, 2);
            this.tableLayoutPanelMainLayout.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanelMainLayout.Controls.Add(this.textBoxStudentsNumber, 1, 3);
            this.tableLayoutPanelMainLayout.Controls.Add(this.textBoxEmail, 1, 2);
            this.tableLayoutPanelMainLayout.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelMainLayout.Name = "tableLayoutPanelMainLayout";
            this.tableLayoutPanelMainLayout.RowCount = 7;
            this.tableLayoutPanelMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanelMainLayout.Size = new System.Drawing.Size(364, 231);
            this.tableLayoutPanelMainLayout.TabIndex = 13;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(3, 183);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 44);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 255);
            this.Controls.Add(this.tableLayoutPanelMainLayout);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.tableLayoutPanelMainLayout.ResumeLayout(false);
            this.tableLayoutPanelMainLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxStudentsNumber;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelStudentsNumber;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainLayout;
        private System.Windows.Forms.Button buttonCancel;
    }
}