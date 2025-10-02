namespace AnotherForm
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
            this.gb = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfn = new System.Windows.Forms.TextBox();
            this.txtsn = new System.Windows.Forms.TextBox();
            this.cboCounties = new System.Windows.Forms.ComboBox();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.button1);
            this.gb.Controls.Add(this.rbfemale);
            this.gb.Controls.Add(this.rbmale);
            this.gb.Controls.Add(this.dtpdob);
            this.gb.Controls.Add(this.cboCounties);
            this.gb.Controls.Add(this.txtsn);
            this.gb.Controls.Add(this.txtfn);
            this.gb.Controls.Add(this.label5);
            this.gb.Controls.Add(this.label4);
            this.gb.Controls.Add(this.label3);
            this.gb.Controls.Add(this.label2);
            this.gb.Controls.Add(this.label1);
            this.gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.gb.Location = new System.Drawing.Point(37, 31);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(697, 365);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            this.gb.Text = "Student Information";
            this.gb.Enter += new System.EventHandler(this.gb_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(84, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(100, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(101, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Counties";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(129, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOB";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(112, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // txtfn
            // 
            this.txtfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtfn.Location = new System.Drawing.Point(182, 94);
            this.txtfn.Name = "txtfn";
            this.txtfn.Size = new System.Drawing.Size(303, 26);
            this.txtfn.TabIndex = 5;
            // 
            // txts
            // 
            this.txtsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtsn.Location = new System.Drawing.Point(182, 137);
            this.txtsn.Name = "txts";
            this.txtsn.Size = new System.Drawing.Size(303, 26);
            this.txtsn.TabIndex = 6;
            // 
            // cboCounties
            // 
            this.cboCounties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboCounties.FormattingEnabled = true;
            this.cboCounties.Location = new System.Drawing.Point(182, 181);
            this.cboCounties.Name = "cboCounties";
            this.cboCounties.Size = new System.Drawing.Size(303, 28);
            this.cboCounties.TabIndex = 7;
            this.cboCounties.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            // 
            // dtpdob
            // 
            this.dtpdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpdob.Location = new System.Drawing.Point(182, 224);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(303, 26);
            this.dtpdob.TabIndex = 8;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Checked = true;
            this.rbmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbmale.Location = new System.Drawing.Point(182, 266);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(66, 24);
            this.rbmale.TabIndex = 9;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbfemale.Location = new System.Drawing.Point(254, 266);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(80, 24);
            this.rbfemale.TabIndex = 10;
            this.rbfemale.Text = "female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(362, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.ComboBox cboCounties;
        private System.Windows.Forms.TextBox txtsn;
        private System.Windows.Forms.TextBox txtfn;
        private System.Windows.Forms.Button button1;
    }
}

