namespace MichalSurmackiZad1
{
    partial class FormHowManyStocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHowManyStocks));
            this.buttonHowManyStocks25 = new System.Windows.Forms.Button();
            this.buttonHowManyStocksBack = new System.Windows.Forms.Button();
            this.buttonHowManyStocks100 = new System.Windows.Forms.Button();
            this.buttonHowManyStocks50 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonHowManyStocks25
            // 
            this.buttonHowManyStocks25.Location = new System.Drawing.Point(144, 211);
            this.buttonHowManyStocks25.Name = "buttonHowManyStocks25";
            this.buttonHowManyStocks25.Size = new System.Drawing.Size(147, 78);
            this.buttonHowManyStocks25.TabIndex = 0;
            this.buttonHowManyStocks25.Text = "25%";
            this.buttonHowManyStocks25.UseVisualStyleBackColor = true;
            this.buttonHowManyStocks25.Click += new System.EventHandler(this.buttonHowManyStocks25_Click);
            // 
            // buttonHowManyStocksBack
            // 
            this.buttonHowManyStocksBack.Location = new System.Drawing.Point(144, 309);
            this.buttonHowManyStocksBack.Name = "buttonHowManyStocksBack";
            this.buttonHowManyStocksBack.Size = new System.Drawing.Size(147, 78);
            this.buttonHowManyStocksBack.TabIndex = 1;
            this.buttonHowManyStocksBack.Text = "Powrót";
            this.buttonHowManyStocksBack.UseVisualStyleBackColor = true;
            this.buttonHowManyStocksBack.Click += new System.EventHandler(this.buttonHowManyStocksBack_Click);
            // 
            // buttonHowManyStocks100
            // 
            this.buttonHowManyStocks100.Location = new System.Drawing.Point(144, 43);
            this.buttonHowManyStocks100.Name = "buttonHowManyStocks100";
            this.buttonHowManyStocks100.Size = new System.Drawing.Size(147, 78);
            this.buttonHowManyStocks100.TabIndex = 2;
            this.buttonHowManyStocks100.Text = "100%";
            this.buttonHowManyStocks100.UseVisualStyleBackColor = true;
            this.buttonHowManyStocks100.Click += new System.EventHandler(this.buttonHowManyStocks100_Click);
            // 
            // buttonHowManyStocks50
            // 
            this.buttonHowManyStocks50.Location = new System.Drawing.Point(144, 127);
            this.buttonHowManyStocks50.Name = "buttonHowManyStocks50";
            this.buttonHowManyStocks50.Size = new System.Drawing.Size(147, 78);
            this.buttonHowManyStocks50.TabIndex = 3;
            this.buttonHowManyStocks50.Text = "50%";
            this.buttonHowManyStocks50.UseVisualStyleBackColor = true;
            this.buttonHowManyStocks50.Click += new System.EventHandler(this.buttonHowManyStocks75_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ile Akcji chcesz kupić?";
            // 
            // FormHowManyStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(426, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHowManyStocks50);
            this.Controls.Add(this.buttonHowManyStocks100);
            this.Controls.Add(this.buttonHowManyStocksBack);
            this.Controls.Add(this.buttonHowManyStocks25);
            this.Name = "FormHowManyStocks";
            this.Text = "FormHowManyStocks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHowManyStocks25;
        private System.Windows.Forms.Button buttonHowManyStocksBack;
        private System.Windows.Forms.Button buttonHowManyStocks100;
        private System.Windows.Forms.Button buttonHowManyStocks50;
        private System.Windows.Forms.Label label1;
    }
}