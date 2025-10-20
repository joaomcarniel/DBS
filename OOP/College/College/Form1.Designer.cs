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
            this.btnStu = new System.Windows.Forms.Button();
            this.stuNumberStu = new System.Windows.Forms.TextBox();
            this.dobStudent = new System.Windows.Forms.DateTimePicker();
            this.countyStud = new System.Windows.Forms.ComboBox();
            this.surnameStud = new System.Windows.Forms.TextBox();
            this.firstNameStu = new System.Windows.Forms.TextBox();
            this.femaleStud = new System.Windows.Forms.RadioButton();
            this.maleStu = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddLecturer = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.payLec = new System.Windows.Forms.TextBox();
            this.btnLec = new System.Windows.Forms.Button();
            this.firstNameLec = new System.Windows.Forms.TextBox();
            this.modulesLec = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dobLec = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.countyLec = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.surnameLec = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.femaleLec = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.maleLec = new System.Windows.Forms.RadioButton();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.btnShowLecturer = new System.Windows.Forms.Button();
            this.btnShowGen = new System.Windows.Forms.Button();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.btnStuFrom = new System.Windows.Forms.Button();
            this.cboStuFrom = new System.Windows.Forms.ComboBox();
            this.AddStudent.SuspendLayout();
            this.AddLecturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStudent
            // 
            this.AddStudent.Controls.Add(this.btnStu);
            this.AddStudent.Controls.Add(this.stuNumberStu);
            this.AddStudent.Controls.Add(this.dobStudent);
            this.AddStudent.Controls.Add(this.countyStud);
            this.AddStudent.Controls.Add(this.surnameStud);
            this.AddStudent.Controls.Add(this.firstNameStu);
            this.AddStudent.Controls.Add(this.femaleStud);
            this.AddStudent.Controls.Add(this.maleStu);
            this.AddStudent.Controls.Add(this.label6);
            this.AddStudent.Controls.Add(this.label5);
            this.AddStudent.Controls.Add(this.label4);
            this.AddStudent.Controls.Add(this.label3);
            this.AddStudent.Controls.Add(this.label2);
            this.AddStudent.Controls.Add(this.label1);
            this.AddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddStudent.Location = new System.Drawing.Point(12, 27);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(504, 419);
            this.AddStudent.TabIndex = 0;
            this.AddStudent.TabStop = false;
            this.AddStudent.Text = "Add Student";
            // 
            // btnStu
            // 
            this.btnStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStu.Location = new System.Drawing.Point(154, 363);
            this.btnStu.Name = "btnStu";
            this.btnStu.Size = new System.Drawing.Size(140, 48);
            this.btnStu.TabIndex = 13;
            this.btnStu.Text = "Add Student";
            this.btnStu.UseVisualStyleBackColor = true;
            this.btnStu.Click += new System.EventHandler(this.btnStu_Click);
            // 
            // stuNumberStu
            // 
            this.stuNumberStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stuNumberStu.Location = new System.Drawing.Point(154, 309);
            this.stuNumberStu.Name = "stuNumberStu";
            this.stuNumberStu.Size = new System.Drawing.Size(100, 26);
            this.stuNumberStu.TabIndex = 12;
            // 
            // dobStudent
            // 
            this.dobStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dobStudent.Location = new System.Drawing.Point(154, 176);
            this.dobStudent.Name = "dobStudent";
            this.dobStudent.Size = new System.Drawing.Size(277, 26);
            this.dobStudent.TabIndex = 11;
            // 
            // countyStud
            // 
            this.countyStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.countyStud.FormattingEnabled = true;
            this.countyStud.Location = new System.Drawing.Point(154, 131);
            this.countyStud.Name = "countyStud";
            this.countyStud.Size = new System.Drawing.Size(121, 28);
            this.countyStud.TabIndex = 10;
            // 
            // surnameStud
            // 
            this.surnameStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.surnameStud.Location = new System.Drawing.Point(154, 89);
            this.surnameStud.Name = "surnameStud";
            this.surnameStud.Size = new System.Drawing.Size(100, 26);
            this.surnameStud.TabIndex = 9;
            // 
            // firstNameStu
            // 
            this.firstNameStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firstNameStu.Location = new System.Drawing.Point(154, 46);
            this.firstNameStu.Name = "firstNameStu";
            this.firstNameStu.Size = new System.Drawing.Size(100, 26);
            this.firstNameStu.TabIndex = 8;
            // 
            // femaleStud
            // 
            this.femaleStud.AutoSize = true;
            this.femaleStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.femaleStud.Location = new System.Drawing.Point(154, 265);
            this.femaleStud.Name = "femaleStud";
            this.femaleStud.Size = new System.Drawing.Size(85, 24);
            this.femaleStud.TabIndex = 7;
            this.femaleStud.TabStop = true;
            this.femaleStud.Text = "Female";
            this.femaleStud.UseVisualStyleBackColor = true;
            // 
            // maleStu
            // 
            this.maleStu.AutoSize = true;
            this.maleStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maleStu.Location = new System.Drawing.Point(154, 223);
            this.maleStu.Name = "maleStu";
            this.maleStu.Size = new System.Drawing.Size(66, 24);
            this.maleStu.TabIndex = 6;
            this.maleStu.TabStop = true;
            this.maleStu.Text = "Male";
            this.maleStu.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(-1, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Student Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(65, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(82, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(68, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "County";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(53, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(37, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddLecturer
            // 
            this.AddLecturer.Controls.Add(this.label13);
            this.AddLecturer.Controls.Add(this.payLec);
            this.AddLecturer.Controls.Add(this.btnLec);
            this.AddLecturer.Controls.Add(this.firstNameLec);
            this.AddLecturer.Controls.Add(this.modulesLec);
            this.AddLecturer.Controls.Add(this.label12);
            this.AddLecturer.Controls.Add(this.dobLec);
            this.AddLecturer.Controls.Add(this.label11);
            this.AddLecturer.Controls.Add(this.countyLec);
            this.AddLecturer.Controls.Add(this.label10);
            this.AddLecturer.Controls.Add(this.surnameLec);
            this.AddLecturer.Controls.Add(this.label9);
            this.AddLecturer.Controls.Add(this.label8);
            this.AddLecturer.Controls.Add(this.femaleLec);
            this.AddLecturer.Controls.Add(this.label7);
            this.AddLecturer.Controls.Add(this.maleLec);
            this.AddLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddLecturer.Location = new System.Drawing.Point(617, 27);
            this.AddLecturer.Name = "AddLecturer";
            this.AddLecturer.Size = new System.Drawing.Size(543, 419);
            this.AddLecturer.TabIndex = 1;
            this.AddLecturer.TabStop = false;
            this.AddLecturer.Text = "Add Lecturer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(100, 335);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 29);
            this.label13.TabIndex = 29;
            this.label13.Text = "Pay";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // payLec
            // 
            this.payLec.Location = new System.Drawing.Point(182, 330);
            this.payLec.Name = "payLec";
            this.payLec.Size = new System.Drawing.Size(100, 34);
            this.payLec.TabIndex = 28;
            // 
            // btnLec
            // 
            this.btnLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLec.Location = new System.Drawing.Point(182, 366);
            this.btnLec.Name = "btnLec";
            this.btnLec.Size = new System.Drawing.Size(140, 48);
            this.btnLec.TabIndex = 27;
            this.btnLec.Text = "Add Lecturer";
            this.btnLec.UseVisualStyleBackColor = true;
            this.btnLec.Click += new System.EventHandler(this.btnLec_Click);
            // 
            // firstNameLec
            // 
            this.firstNameLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firstNameLec.Location = new System.Drawing.Point(182, 49);
            this.firstNameLec.Name = "firstNameLec";
            this.firstNameLec.Size = new System.Drawing.Size(100, 26);
            this.firstNameLec.TabIndex = 22;
            // 
            // modulesLec
            // 
            this.modulesLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.modulesLec.Location = new System.Drawing.Point(182, 298);
            this.modulesLec.Name = "modulesLec";
            this.modulesLec.Size = new System.Drawing.Size(100, 26);
            this.modulesLec.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(65, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "First Name";
            // 
            // dobLec
            // 
            this.dobLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dobLec.Location = new System.Drawing.Point(182, 179);
            this.dobLec.Name = "dobLec";
            this.dobLec.Size = new System.Drawing.Size(276, 26);
            this.dobLec.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(81, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Surname";
            // 
            // countyLec
            // 
            this.countyLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.countyLec.FormattingEnabled = true;
            this.countyLec.Location = new System.Drawing.Point(182, 134);
            this.countyLec.Name = "countyLec";
            this.countyLec.Size = new System.Drawing.Size(121, 28);
            this.countyLec.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(96, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "County";
            // 
            // surnameLec
            // 
            this.surnameLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.surnameLec.Location = new System.Drawing.Point(182, 92);
            this.surnameLec.Name = "surnameLec";
            this.surnameLec.Size = new System.Drawing.Size(100, 26);
            this.surnameLec.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(110, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "DOB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(93, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Gender";
            // 
            // femaleLec
            // 
            this.femaleLec.AutoSize = true;
            this.femaleLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.femaleLec.Location = new System.Drawing.Point(182, 268);
            this.femaleLec.Name = "femaleLec";
            this.femaleLec.Size = new System.Drawing.Size(85, 24);
            this.femaleLec.TabIndex = 21;
            this.femaleLec.TabStop = true;
            this.femaleLec.Text = "Female";
            this.femaleLec.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(81, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Modules";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // maleLec
            // 
            this.maleLec.AutoSize = true;
            this.maleLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maleLec.Location = new System.Drawing.Point(182, 226);
            this.maleLec.Name = "maleLec";
            this.maleLec.Size = new System.Drawing.Size(66, 24);
            this.maleLec.TabIndex = 20;
            this.maleLec.TabStop = true;
            this.maleLec.Text = "Male";
            this.maleLec.UseVisualStyleBackColor = true;
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(357, 461);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(803, 213);
            this.DGV.TabIndex = 2;
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.Location = new System.Drawing.Point(53, 482);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(135, 23);
            this.btnShowStudents.TabIndex = 3;
            this.btnShowStudents.Text = "Show Students";
            this.btnShowStudents.UseVisualStyleBackColor = true;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // btnShowLecturer
            // 
            this.btnShowLecturer.Location = new System.Drawing.Point(53, 523);
            this.btnShowLecturer.Name = "btnShowLecturer";
            this.btnShowLecturer.Size = new System.Drawing.Size(135, 23);
            this.btnShowLecturer.TabIndex = 5;
            this.btnShowLecturer.Text = "Show Lecturers";
            this.btnShowLecturer.UseVisualStyleBackColor = true;
            this.btnShowLecturer.Click += new System.EventHandler(this.btnShowLecturer_Click);
            // 
            // btnShowGen
            // 
            this.btnShowGen.Location = new System.Drawing.Point(53, 564);
            this.btnShowGen.Name = "btnShowGen";
            this.btnShowGen.Size = new System.Drawing.Size(135, 23);
            this.btnShowGen.TabIndex = 6;
            this.btnShowGen.Text = "Show Gender";
            this.btnShowGen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowGen.UseVisualStyleBackColor = true;
            this.btnShowGen.Click += new System.EventHandler(this.btnShowGen_Click);
            // 
            // cboGender
            // 
            this.cboGender.Location = new System.Drawing.Point(195, 562);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(121, 24);
            this.cboGender.TabIndex = 7;
            // 
            // btnStuFrom
            // 
            this.btnStuFrom.Location = new System.Drawing.Point(53, 604);
            this.btnStuFrom.Name = "btnStuFrom";
            this.btnStuFrom.Size = new System.Drawing.Size(135, 23);
            this.btnStuFrom.TabIndex = 8;
            this.btnStuFrom.Text = "Students From";
            this.btnStuFrom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStuFrom.UseVisualStyleBackColor = true;
            this.btnStuFrom.Click += new System.EventHandler(this.btnStuFrom_Click);
            // 
            // cboStuFrom
            // 
            this.cboStuFrom.FormattingEnabled = true;
            this.cboStuFrom.Location = new System.Drawing.Point(195, 602);
            this.cboStuFrom.Name = "cboStuFrom";
            this.cboStuFrom.Size = new System.Drawing.Size(121, 24);
            this.cboStuFrom.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 686);
            this.Controls.Add(this.cboStuFrom);
            this.Controls.Add(this.btnStuFrom);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.btnShowGen);
            this.Controls.Add(this.btnShowLecturer);
            this.Controls.Add(this.btnShowStudents);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.AddLecturer);
            this.Controls.Add(this.AddStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AddStudent.ResumeLayout(false);
            this.AddStudent.PerformLayout();
            this.AddLecturer.ResumeLayout(false);
            this.AddLecturer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddStudent;
        private System.Windows.Forms.GroupBox AddLecturer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton femaleStud;
        private System.Windows.Forms.RadioButton maleStu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dobStudent;
        private System.Windows.Forms.ComboBox countyStud;
        private System.Windows.Forms.TextBox surnameStud;
        private System.Windows.Forms.TextBox firstNameStu;
        private System.Windows.Forms.TextBox stuNumberStu;
        private System.Windows.Forms.Button btnStu;
        private System.Windows.Forms.Button btnLec;
        private System.Windows.Forms.TextBox firstNameLec;
        private System.Windows.Forms.TextBox modulesLec;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dobLec;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox countyLec;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox surnameLec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton femaleLec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton maleLec;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox payLec;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btnShowStudents;
        private System.Windows.Forms.Button btnShowLecturer;
        private System.Windows.Forms.Button btnShowGen;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Button btnStuFrom;
        private System.Windows.Forms.ComboBox cboStuFrom;
    }
}

