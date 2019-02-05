namespace A._2
{
    partial class FormDodaj
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
            this.labelData = new System.Windows.Forms.Label();
            this.labelOcena = new System.Windows.Forms.Label();
            this.labelWynik = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxOcena = new System.Windows.Forms.TextBox();
            this.textBoxWynik = new System.Windows.Forms.TextBox();
            this.buttonCofnij = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(57, 9);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(42, 17);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data:";
            // 
            // labelOcena
            // 
            this.labelOcena.AutoSize = true;
            this.labelOcena.Location = new System.Drawing.Point(48, 38);
            this.labelOcena.Name = "labelOcena";
            this.labelOcena.Size = new System.Drawing.Size(54, 17);
            this.labelOcena.TabIndex = 1;
            this.labelOcena.Text = "Ocena:";
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Location = new System.Drawing.Point(25, 66);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(79, 17);
            this.labelWynik.TabIndex = 2;
            this.labelWynik.Text = "Wynik w %:";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(110, 6);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(100, 22);
            this.textBoxData.TabIndex = 3;
            // 
            // textBoxOcena
            // 
            this.textBoxOcena.Location = new System.Drawing.Point(110, 35);
            this.textBoxOcena.Name = "textBoxOcena";
            this.textBoxOcena.Size = new System.Drawing.Size(100, 22);
            this.textBoxOcena.TabIndex = 4;
            // 
            // textBoxWynik
            // 
            this.textBoxWynik.Location = new System.Drawing.Point(110, 63);
            this.textBoxWynik.Name = "textBoxWynik";
            this.textBoxWynik.Size = new System.Drawing.Size(100, 22);
            this.textBoxWynik.TabIndex = 5;
            // 
            // buttonCofnij
            // 
            this.buttonCofnij.Location = new System.Drawing.Point(8, 91);
            this.buttonCofnij.Name = "buttonCofnij";
            this.buttonCofnij.Size = new System.Drawing.Size(91, 41);
            this.buttonCofnij.TabIndex = 7;
            this.buttonCofnij.Text = "Cofnij";
            this.buttonCofnij.UseVisualStyleBackColor = true;
            this.buttonCofnij.Click += new System.EventHandler(this.buttonCofnij_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(119, 91);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(91, 41);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 152);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCofnij);
            this.Controls.Add(this.textBoxWynik);
            this.Controls.Add(this.textBoxOcena);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.labelOcena);
            this.Controls.Add(this.labelData);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDodaj";
            this.Text = "Dodaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelOcena;
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxOcena;
        private System.Windows.Forms.TextBox textBoxWynik;
        private System.Windows.Forms.Button buttonCofnij;
        private System.Windows.Forms.Button buttonOk;
    }
}