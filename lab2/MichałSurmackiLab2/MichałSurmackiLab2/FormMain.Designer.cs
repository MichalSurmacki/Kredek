namespace MichałSurmackiLab2
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
            this.labelAuthorsName = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxHorseName = new System.Windows.Forms.TextBox();
            this.textBoxHorseFavouriteNumber = new System.Windows.Forms.TextBox();
            this.labelHorseFavouriteNumber = new System.Windows.Forms.Label();
            this.labelHorseName = new System.Windows.Forms.Label();
            this.textBoxHornColor = new System.Windows.Forms.TextBox();
            this.labelHornColor = new System.Windows.Forms.Label();
            this.buttonAddUnicorn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAuthorsName
            // 
            this.labelAuthorsName.AutoSize = true;
            this.labelAuthorsName.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthorsName.Location = new System.Drawing.Point(12, 9);
            this.labelAuthorsName.Name = "labelAuthorsName";
            this.labelAuthorsName.Size = new System.Drawing.Size(776, 95);
            this.labelAuthorsName.TabIndex = 0;
            this.labelAuthorsName.Text = "Michal Surmacki";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(70, 311);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(287, 60);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Dodaj Konia";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxHorseName
            // 
            this.textBoxHorseName.Location = new System.Drawing.Point(150, 197);
            this.textBoxHorseName.Name = "textBoxHorseName";
            this.textBoxHorseName.Size = new System.Drawing.Size(207, 22);
            this.textBoxHorseName.TabIndex = 2;
            // 
            // textBoxHorseFavouriteNumber
            // 
            this.textBoxHorseFavouriteNumber.Location = new System.Drawing.Point(257, 246);
            this.textBoxHorseFavouriteNumber.Name = "textBoxHorseFavouriteNumber";
            this.textBoxHorseFavouriteNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxHorseFavouriteNumber.TabIndex = 3;
            // 
            // labelHorseFavouriteNumber
            // 
            this.labelHorseFavouriteNumber.AutoSize = true;
            this.labelHorseFavouriteNumber.Location = new System.Drawing.Point(67, 249);
            this.labelHorseFavouriteNumber.Name = "labelHorseFavouriteNumber";
            this.labelHorseFavouriteNumber.Size = new System.Drawing.Size(184, 17);
            this.labelHorseFavouriteNumber.TabIndex = 4;
            this.labelHorseFavouriteNumber.Text = "Podaj ulubioną liczbę konia:";
            // 
            // labelHorseName
            // 
            this.labelHorseName.AutoSize = true;
            this.labelHorseName.Location = new System.Drawing.Point(67, 197);
            this.labelHorseName.Name = "labelHorseName";
            this.labelHorseName.Size = new System.Drawing.Size(77, 17);
            this.labelHorseName.TabIndex = 5;
            this.labelHorseName.Text = "Podaj imię:";
            // 
            // textBoxHornColor
            // 
            this.textBoxHornColor.Location = new System.Drawing.Point(593, 191);
            this.textBoxHornColor.Name = "textBoxHornColor";
            this.textBoxHornColor.Size = new System.Drawing.Size(100, 22);
            this.textBoxHornColor.TabIndex = 6;
            // 
            // labelHornColor
            // 
            this.labelHornColor.AutoSize = true;
            this.labelHornColor.Location = new System.Drawing.Point(509, 194);
            this.labelHornColor.Name = "labelHornColor";
            this.labelHornColor.Size = new System.Drawing.Size(78, 17);
            this.labelHornColor.TabIndex = 7;
            this.labelHornColor.Text = "Kolor rogu:";
            // 
            // buttonAddUnicorn
            // 
            this.buttonAddUnicorn.Location = new System.Drawing.Point(500, 237);
            this.buttonAddUnicorn.Name = "buttonAddUnicorn";
            this.buttonAddUnicorn.Size = new System.Drawing.Size(240, 65);
            this.buttonAddUnicorn.TabIndex = 8;
            this.buttonAddUnicorn.Text = "Dodaj Jednorożca";
            this.buttonAddUnicorn.UseVisualStyleBackColor = true;
            this.buttonAddUnicorn.Click += new System.EventHandler(this.buttonAddUnicorn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 552);
            this.Controls.Add(this.buttonAddUnicorn);
            this.Controls.Add(this.labelHornColor);
            this.Controls.Add(this.textBoxHornColor);
            this.Controls.Add(this.labelHorseName);
            this.Controls.Add(this.labelHorseFavouriteNumber);
            this.Controls.Add(this.textBoxHorseFavouriteNumber);
            this.Controls.Add(this.textBoxHorseName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelAuthorsName);
            this.Name = "FormMain";
            this.Text = "Lab2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAuthorsName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxHorseName;
        private System.Windows.Forms.TextBox textBoxHorseFavouriteNumber;
        private System.Windows.Forms.Label labelHorseFavouriteNumber;
        private System.Windows.Forms.Label labelHorseName;
        private System.Windows.Forms.TextBox textBoxHornColor;
        private System.Windows.Forms.Label labelHornColor;
        private System.Windows.Forms.Button buttonAddUnicorn;
    }
}

