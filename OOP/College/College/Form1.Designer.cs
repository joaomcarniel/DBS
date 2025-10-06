namespace College
{
    partial class Form1
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
            this.AddStudent = new System.Windows.Forms.GroupBox();
            this.AddLecturer = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // AddStudent
            // 
            this.AddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddStudent.Location = new System.Drawing.Point(28, 27);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(318, 363);
            this.AddStudent.TabIndex = 0;
            this.AddStudent.TabStop = false;
            this.AddStudent.Text = "Add Student";
            // 
            // AddLecturer
            // 
            this.AddLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddLecturer.Location = new System.Drawing.Point(449, 27);
            this.AddLecturer.Name = "AddLecturer";
            this.AddLecturer.Size = new System.Drawing.Size(318, 363);
            this.AddLecturer.TabIndex = 1;
            this.AddLecturer.TabStop = false;
            this.AddLecturer.Text = "Add Lecturer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddLecturer);
            this.Controls.Add(this.AddStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddStudent;
        private System.Windows.Forms.GroupBox AddLecturer;
    }
}

