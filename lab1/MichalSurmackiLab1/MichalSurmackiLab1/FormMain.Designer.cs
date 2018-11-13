namespace MichalSurmackiLab1
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
            this.components = new System.ComponentModel.Container();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelNameSurname = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.buttonIncrease = new System.Windows.Forms.Button();
            this.textBoxMultiplier = new System.Windows.Forms.TextBox();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.labelTimeCounter = new System.Windows.Forms.Label();
            this.textBoxTimerCounter = new System.Windows.Forms.TextBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(612, 351);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(161, 87);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelNameSurname
            // 
            this.labelNameSurname.AutoSize = true;
            this.labelNameSurname.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameSurname.Location = new System.Drawing.Point(12, 9);
            this.labelNameSurname.Name = "labelNameSurname";
            this.labelNameSurname.Size = new System.Drawing.Size(761, 95);
            this.labelNameSurname.TabIndex = 1;
            this.labelNameSurname.Text = "Michal Surmacki";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(28, 131);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(159, 88);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Zmień";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(30, 276);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(119, 22);
            this.textBoxData.TabIndex = 3;
            this.textBoxData.Text = "1";
            // 
            // buttonIncrease
            // 
            this.buttonIncrease.Location = new System.Drawing.Point(155, 276);
            this.buttonIncrease.Name = "buttonIncrease";
            this.buttonIncrease.Size = new System.Drawing.Size(125, 54);
            this.buttonIncrease.TabIndex = 4;
            this.buttonIncrease.Text = "Zwiększ";
            this.buttonIncrease.UseVisualStyleBackColor = true;
            this.buttonIncrease.Click += new System.EventHandler(this.buttonIncrease_Click);
            // 
            // textBoxMultiplier
            // 
            this.textBoxMultiplier.Location = new System.Drawing.Point(30, 363);
            this.textBoxMultiplier.Name = "textBoxMultiplier";
            this.textBoxMultiplier.Size = new System.Drawing.Size(119, 22);
            this.textBoxMultiplier.TabIndex = 5;
            this.textBoxMultiplier.Text = "1";
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(156, 363);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(124, 51);
            this.buttonMultiply.TabIndex = 6;
            this.buttonMultiply.Text = "Pomnóż";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // timerCount
            // 
            this.timerCount.Enabled = true;
            this.timerCount.Interval = 1000;
            this.timerCount.Tick += new System.EventHandler(this.timerCount_Tick);
            // 
            // labelTimeCounter
            // 
            this.labelTimeCounter.AutoSize = true;
            this.labelTimeCounter.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimeCounter.Location = new System.Drawing.Point(367, 189);
            this.labelTimeCounter.Name = "labelTimeCounter";
            this.labelTimeCounter.Size = new System.Drawing.Size(83, 28);
            this.labelTimeCounter.TabIndex = 7;
            this.labelTimeCounter.Text = "Licznik:";
            // 
            // textBoxTimerCounter
            // 
            this.textBoxTimerCounter.Location = new System.Drawing.Point(457, 194);
            this.textBoxTimerCounter.Name = "textBoxTimerCounter";
            this.textBoxTimerCounter.Size = new System.Drawing.Size(100, 22);
            this.textBoxTimerCounter.TabIndex = 8;
            this.textBoxTimerCounter.Text = "0";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(385, 167);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(231, 17);
            this.labelTimer.TabIndex = 9;
            this.labelTimer.Text = "Co dziesięć sekund zmieniam kolor!";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.textBoxTimerCounter);
            this.Controls.Add(this.labelTimeCounter);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.textBoxMultiplier);
            this.Controls.Add(this.buttonIncrease);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.labelNameSurname);
            this.Controls.Add(this.buttonClose);
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "FormMain";
            this.Text = "MichalSurmackiLab1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelNameSurname;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Button buttonIncrease;
        private System.Windows.Forms.TextBox textBoxMultiplier;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Timer timerCount;
        private System.Windows.Forms.Label labelTimeCounter;
        private System.Windows.Forms.TextBox textBoxTimerCounter;
        private System.Windows.Forms.Label labelTimer;
    }
}

