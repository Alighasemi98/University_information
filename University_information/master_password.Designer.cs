namespace University_information
{
    partial class master_password
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
            this.but_ok_password = new System.Windows.Forms.Button();
            this.tex_password_pasword_master = new System.Windows.Forms.TextBox();
            this.tex_password2_password_master = new System.Windows.Forms.TextBox();
            this.tex_username_password_master = new System.Windows.Forms.TextBox();
            this.che_show_password = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_ok_password
            // 
            this.but_ok_password.Location = new System.Drawing.Point(12, 148);
            this.but_ok_password.Name = "but_ok_password";
            this.but_ok_password.Size = new System.Drawing.Size(178, 23);
            this.but_ok_password.TabIndex = 0;
            this.but_ok_password.Text = "ok";
            this.but_ok_password.UseVisualStyleBackColor = true;
            this.but_ok_password.Click += new System.EventHandler(this.but_ok_password_Click);
            // 
            // tex_password_pasword_master
            // 
            this.tex_password_pasword_master.Location = new System.Drawing.Point(12, 73);
            this.tex_password_pasword_master.Name = "tex_password_pasword_master";
            this.tex_password_pasword_master.Size = new System.Drawing.Size(178, 20);
            this.tex_password_pasword_master.TabIndex = 1;
            this.tex_password_pasword_master.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_password_pasword_master.UseSystemPasswordChar = true;
            // 
            // tex_password2_password_master
            // 
            this.tex_password2_password_master.Location = new System.Drawing.Point(12, 99);
            this.tex_password2_password_master.Name = "tex_password2_password_master";
            this.tex_password2_password_master.Size = new System.Drawing.Size(178, 20);
            this.tex_password2_password_master.TabIndex = 2;
            this.tex_password2_password_master.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_password2_password_master.UseSystemPasswordChar = true;
            // 
            // tex_username_password_master
            // 
            this.tex_username_password_master.Location = new System.Drawing.Point(12, 47);
            this.tex_username_password_master.Name = "tex_username_password_master";
            this.tex_username_password_master.Size = new System.Drawing.Size(178, 20);
            this.tex_username_password_master.TabIndex = 1;
            this.tex_username_password_master.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // che_show_password
            // 
            this.che_show_password.AutoSize = true;
            this.che_show_password.Location = new System.Drawing.Point(12, 125);
            this.che_show_password.Name = "che_show_password";
            this.che_show_password.Size = new System.Drawing.Size(99, 17);
            this.che_show_password.TabIndex = 4;
            this.che_show_password.Text = "show password";
            this.che_show_password.UseVisualStyleBackColor = true;
            this.che_show_password.CheckedChanged += new System.EventHandler(this.che_show_password_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "password again";
            // 
            // master_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 198);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.che_show_password);
            this.Controls.Add(this.tex_password2_password_master);
            this.Controls.Add(this.tex_username_password_master);
            this.Controls.Add(this.tex_password_pasword_master);
            this.Controls.Add(this.but_ok_password);
            this.Name = "master_password";
            this.Text = "master_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_ok_password;
        public  System.Windows.Forms.TextBox tex_password_pasword_master;
        private System.Windows.Forms.TextBox tex_password2_password_master;
        public  System.Windows.Forms.TextBox tex_username_password_master;
        private System.Windows.Forms.CheckBox che_show_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}