namespace MichalSurmackiZad1
{
    partial class FormNotEnoughtMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotEnoughtMoney));
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelNoMoney1 = new System.Windows.Forms.Label();
            this.labelNoMoney2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(67, 187);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(149, 54);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelNoMoney1
            // 
            this.labelNoMoney1.AutoSize = true;
            this.labelNoMoney1.ForeColor = System.Drawing.Color.Red;
            this.labelNoMoney1.Location = new System.Drawing.Point(42, 36);
            this.labelNoMoney1.Name = "labelNoMoney1";
            this.labelNoMoney1.Size = new System.Drawing.Size(203, 17);
            this.labelNoMoney1.TabIndex = 1;
            this.labelNoMoney1.Text = "NIE MASZ WYSTARCZAJĄCEJ";
            // 
            // labelNoMoney2
            // 
            this.labelNoMoney2.AutoSize = true;
            this.labelNoMoney2.ForeColor = System.Drawing.Color.Red;
            this.labelNoMoney2.Location = new System.Drawing.Point(73, 53);
            this.labelNoMoney2.Name = "labelNoMoney2";
            this.labelNoMoney2.Size = new System.Drawing.Size(139, 17);
            this.labelNoMoney2.TabIndex = 2;
            this.labelNoMoney2.Text = "ILOŚCI PIENIĘDZY !!!";
            // 
            // FormNotEnoughtMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.labelNoMoney2);
            this.Controls.Add(this.labelNoMoney1);
            this.Controls.Add(this.buttonOK);
            this.Name = "FormNotEnoughtMoney";
            this.Text = "FormNotEnoughtMoney";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelNoMoney1;
        private System.Windows.Forms.Label labelNoMoney2;
    }
}