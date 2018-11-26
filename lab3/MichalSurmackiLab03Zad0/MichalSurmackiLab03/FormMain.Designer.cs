namespace MichalSurmackiLab03
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.buttonViewGrade = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.buttonCourses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MICHAL SURMACKI";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(9, 57);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(529, 317);
            this.dataGridViewData.TabIndex = 1;
            // 
            // buttonViewGrade
            // 
            this.buttonViewGrade.Location = new System.Drawing.Point(615, 57);
            this.buttonViewGrade.Name = "buttonViewGrade";
            this.buttonViewGrade.Size = new System.Drawing.Size(111, 23);
            this.buttonViewGrade.TabIndex = 2;
            this.buttonViewGrade.Text = "View Grade";
            this.buttonViewGrade.UseVisualStyleBackColor = true;
            this.buttonViewGrade.Click += new System.EventHandler(this.buttonViewGrade_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(578, 130);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Location = new System.Drawing.Point(578, 172);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(100, 22);
            this.textBoxCourse.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(685, 134);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(688, 172);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(53, 17);
            this.labelCourse.TabIndex = 6;
            this.labelCourse.Text = "Course";
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(603, 265);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(138, 52);
            this.buttonAddCourse.TabIndex = 7;
            this.buttonAddCourse.Text = "Dodaj nowy kurs";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // buttonCourses
            // 
            this.buttonCourses.Location = new System.Drawing.Point(578, 355);
            this.buttonCourses.Name = "buttonCourses";
            this.buttonCourses.Size = new System.Drawing.Size(138, 52);
            this.buttonCourses.TabIndex = 8;
            this.buttonCourses.Text = "Viev Courses";
            this.buttonCourses.UseVisualStyleBackColor = true;
            this.buttonCourses.Click += new System.EventHandler(this.buttonCourses_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCourses);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonViewGrade);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Button buttonViewGrade;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCourse;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.Button buttonCourses;
    }
}

