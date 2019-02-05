namespace A._2
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
            this.dataGridViewDane = new System.Windows.Forms.DataGridView();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOcena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWynik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDane)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDane
            // 
            this.dataGridViewDane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDane.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnData,
            this.ColumnOcena,
            this.ColumnWynik});
            this.dataGridViewDane.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDane.Name = "dataGridViewDane";
            this.dataGridViewDane.RowTemplate.Height = 24;
            this.dataGridViewDane.Size = new System.Drawing.Size(347, 273);
            this.dataGridViewDane.TabIndex = 0;
            this.dataGridViewDane.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDane_CellContentClick);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(216, 291);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(143, 37);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "A2 Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // ColumnData
            // 
            this.ColumnData.HeaderText = "Data";
            this.ColumnData.Name = "ColumnData";
            // 
            // ColumnOcena
            // 
            this.ColumnOcena.HeaderText = "Ocena";
            this.ColumnOcena.Name = "ColumnOcena";
            // 
            // ColumnWynik
            // 
            this.ColumnWynik.HeaderText = "Wynik w %";
            this.ColumnWynik.Name = "ColumnWynik";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 340);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridViewDane);
            this.Name = "FormMain";
            this.Text = "A.2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDane;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOcena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWynik;
    }
}

