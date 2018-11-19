namespace MichałSurmackiLab2Zad1
{
    partial class FormEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnd));
            this.labelEndOfGame = new System.Windows.Forms.Label();
            this.buttonEndOfGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEndOfGame
            // 
            this.labelEndOfGame.AutoSize = true;
            this.labelEndOfGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEndOfGame.Location = new System.Drawing.Point(12, 31);
            this.labelEndOfGame.Name = "labelEndOfGame";
            this.labelEndOfGame.Size = new System.Drawing.Size(239, 38);
            this.labelEndOfGame.TabIndex = 0;
            this.labelEndOfGame.Text = "PRZEGRAŁEŚ";
            // 
            // buttonEndOfGame
            // 
            this.buttonEndOfGame.Location = new System.Drawing.Point(58, 112);
            this.buttonEndOfGame.Name = "buttonEndOfGame";
            this.buttonEndOfGame.Size = new System.Drawing.Size(149, 69);
            this.buttonEndOfGame.TabIndex = 1;
            this.buttonEndOfGame.Text = "Zakończ";
            this.buttonEndOfGame.UseVisualStyleBackColor = true;
            this.buttonEndOfGame.Click += new System.EventHandler(this.buttonEndOfGame_Click);
            // 
            // FormEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(271, 217);
            this.Controls.Add(this.buttonEndOfGame);
            this.Controls.Add(this.labelEndOfGame);
            this.Name = "FormEnd";
            this.Text = "Koniec GRY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEndOfGame;
        private System.Windows.Forms.Button buttonEndOfGame;
    }
}