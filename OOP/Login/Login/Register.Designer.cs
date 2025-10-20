namespace Login
{
    partial class Register
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(36, 44);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(68, 16);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(36, 83);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(76, 16);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(36, 125);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(67, 16);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(157, 44);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(222, 22);
            this.txtFullName.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(157, 83);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(222, 22);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(157, 125);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(222, 22);
            this.txtPass.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(39, 193);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(99, 34);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 319);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblFullName);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnRegister;
    }
}