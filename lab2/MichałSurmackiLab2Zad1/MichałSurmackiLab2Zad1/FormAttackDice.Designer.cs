namespace MichałSurmackiLab2Zad1
{
    partial class FormAttackDice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttackDice));
            this.buttonThrowADice = new System.Windows.Forms.Button();
            this.pictureBoxDices = new System.Windows.Forms.PictureBox();
            this.labelPlayersResult = new System.Windows.Forms.Label();
            this.labelPlayersResultValue = new System.Windows.Forms.Label();
            this.labelComputerResult = new System.Windows.Forms.Label();
            this.labelComputerResultValue = new System.Windows.Forms.Label();
            this.buttonBackOrClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDices)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonThrowADice
            // 
            this.buttonThrowADice.Location = new System.Drawing.Point(49, 365);
            this.buttonThrowADice.Name = "buttonThrowADice";
            this.buttonThrowADice.Size = new System.Drawing.Size(121, 39);
            this.buttonThrowADice.TabIndex = 0;
            this.buttonThrowADice.Text = "Rzuć kośćmi!";
            this.buttonThrowADice.UseVisualStyleBackColor = true;
            this.buttonThrowADice.Click += new System.EventHandler(this.buttonThrowADice_Click);
            // 
            // pictureBoxDices
            // 
            this.pictureBoxDices.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDices.Image")));
            this.pictureBoxDices.Location = new System.Drawing.Point(109, 12);
            this.pictureBoxDices.Name = "pictureBoxDices";
            this.pictureBoxDices.Size = new System.Drawing.Size(190, 174);
            this.pictureBoxDices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDices.TabIndex = 1;
            this.pictureBoxDices.TabStop = false;
            // 
            // labelPlayersResult
            // 
            this.labelPlayersResult.AutoSize = true;
            this.labelPlayersResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayersResult.Location = new System.Drawing.Point(133, 241);
            this.labelPlayersResult.Name = "labelPlayersResult";
            this.labelPlayersResult.Size = new System.Drawing.Size(141, 25);
            this.labelPlayersResult.TabIndex = 2;
            this.labelPlayersResult.Text = "Wynik Gracza:";
            // 
            // labelPlayersResultValue
            // 
            this.labelPlayersResultValue.AutoSize = true;
            this.labelPlayersResultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayersResultValue.Location = new System.Drawing.Point(280, 241);
            this.labelPlayersResultValue.Name = "labelPlayersResultValue";
            this.labelPlayersResultValue.Size = new System.Drawing.Size(23, 25);
            this.labelPlayersResultValue.TabIndex = 3;
            this.labelPlayersResultValue.Text = "0";
            // 
            // labelComputerResult
            // 
            this.labelComputerResult.AutoSize = true;
            this.labelComputerResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelComputerResult.ForeColor = System.Drawing.Color.Black;
            this.labelComputerResult.Location = new System.Drawing.Point(100, 296);
            this.labelComputerResult.Name = "labelComputerResult";
            this.labelComputerResult.Size = new System.Drawing.Size(174, 25);
            this.labelComputerResult.TabIndex = 4;
            this.labelComputerResult.Text = "Wynik Komputera:";
            // 
            // labelComputerResultValue
            // 
            this.labelComputerResultValue.AutoSize = true;
            this.labelComputerResultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelComputerResultValue.Location = new System.Drawing.Point(280, 296);
            this.labelComputerResultValue.Name = "labelComputerResultValue";
            this.labelComputerResultValue.Size = new System.Drawing.Size(23, 25);
            this.labelComputerResultValue.TabIndex = 5;
            this.labelComputerResultValue.Text = "0";
            // 
            // buttonBackOrClose
            // 
            this.buttonBackOrClose.Location = new System.Drawing.Point(238, 365);
            this.buttonBackOrClose.Name = "buttonBackOrClose";
            this.buttonBackOrClose.Size = new System.Drawing.Size(121, 39);
            this.buttonBackOrClose.TabIndex = 6;
            this.buttonBackOrClose.Text = "Powrót/Zamknij";
            this.buttonBackOrClose.UseVisualStyleBackColor = true;
            this.buttonBackOrClose.Click += new System.EventHandler(this.buttonBackOrClose_Click);
            // 
            // FormAttackDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(401, 443);
            this.Controls.Add(this.buttonBackOrClose);
            this.Controls.Add(this.labelComputerResultValue);
            this.Controls.Add(this.labelComputerResult);
            this.Controls.Add(this.labelPlayersResultValue);
            this.Controls.Add(this.labelPlayersResult);
            this.Controls.Add(this.pictureBoxDices);
            this.Controls.Add(this.buttonThrowADice);
            this.Name = "FormAttackDice";
            this.Text = "Rzut Kostką";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThrowADice;
        private System.Windows.Forms.PictureBox pictureBoxDices;
        private System.Windows.Forms.Label labelPlayersResult;
        private System.Windows.Forms.Label labelPlayersResultValue;
        private System.Windows.Forms.Label labelComputerResult;
        private System.Windows.Forms.Label labelComputerResultValue;
        private System.Windows.Forms.Button buttonBackOrClose;
    }
}