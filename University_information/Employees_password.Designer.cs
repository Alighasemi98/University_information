namespace University_information
{
    partial class Employees_password
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.che_show_password = new System.Windows.Forms.CheckBox();
            this.tex_password2_password_emp = new System.Windows.Forms.TextBox();
            this.tex_username_password_emp = new System.Windows.Forms.TextBox();
            this.tex_password_pasword_emp = new System.Windows.Forms.TextBox();
            this.but_ok_password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "password again";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "username";
            // 
            // che_show_password
            // 
            this.che_show_password.AutoSize = true;
            this.che_show_password.Location = new System.Drawing.Point(12, 90);
            this.che_show_password.Name = "che_show_password";
            this.che_show_password.Size = new System.Drawing.Size(99, 17);
            this.che_show_password.TabIndex = 20;
            this.che_show_password.Text = "show password";
            this.che_show_password.UseVisualStyleBackColor = true;
            this.che_show_password.CheckedChanged += new System.EventHandler(this.che_show_password_CheckedChanged);
            // 
            // tex_password2_password_emp
            // 
            this.tex_password2_password_emp.Location = new System.Drawing.Point(12, 64);
            this.tex_password2_password_emp.Name = "tex_password2_password_emp";
            this.tex_password2_password_emp.Size = new System.Drawing.Size(178, 20);
            this.tex_password2_password_emp.TabIndex = 19;
            this.tex_password2_password_emp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_password2_password_emp.UseSystemPasswordChar = true;
            // 
            // tex_username_password_emp
            // 
            this.tex_username_password_emp.Location = new System.Drawing.Point(12, 12);
            this.tex_username_password_emp.Name = "tex_username_password_emp";
            this.tex_username_password_emp.Size = new System.Drawing.Size(178, 20);
            this.tex_username_password_emp.TabIndex = 17;
            this.tex_username_password_emp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tex_password_pasword_emp
            // 
            this.tex_password_pasword_emp.Location = new System.Drawing.Point(12, 38);
            this.tex_password_pasword_emp.Name = "tex_password_pasword_emp";
            this.tex_password_pasword_emp.Size = new System.Drawing.Size(178, 20);
            this.tex_password_pasword_emp.TabIndex = 18;
            this.tex_password_pasword_emp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_password_pasword_emp.UseSystemPasswordChar = true;
            // 
            // but_ok_password
            // 
            this.but_ok_password.Location = new System.Drawing.Point(12, 113);
            this.but_ok_password.Name = "but_ok_password";
            this.but_ok_password.Size = new System.Drawing.Size(178, 23);
            this.but_ok_password.TabIndex = 16;
            this.but_ok_password.Text = "ok";
            this.but_ok_password.UseVisualStyleBackColor = true;
            this.but_ok_password.Click += new System.EventHandler(this.but_ok_password_Click);
            // 
            // Employees_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 144);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.che_show_password);
            this.Controls.Add(this.tex_password2_password_emp);
            this.Controls.Add(this.tex_username_password_emp);
            this.Controls.Add(this.tex_password_pasword_emp);
            this.Controls.Add(this.but_ok_password);
            this.Name = "Employees_password";
            this.Text = "Employees_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox che_show_password;
        private System.Windows.Forms.TextBox tex_password2_password_emp;
        public System.Windows.Forms.TextBox tex_username_password_emp;
        public System.Windows.Forms.TextBox tex_password_pasword_emp;
        private System.Windows.Forms.Button but_ok_password;
    }
}