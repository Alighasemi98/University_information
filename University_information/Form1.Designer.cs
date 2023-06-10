namespace University_information
{
    partial class loading
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
            this.tex_username_lod = new System.Windows.Forms.TextBox();
            this.tex_password_lod = new System.Windows.Forms.TextBox();
            this.but_login_lod = new System.Windows.Forms.Button();
            this.but_ok_lod = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tex_username_lod
            // 
            this.tex_username_lod.Location = new System.Drawing.Point(122, 12);
            this.tex_username_lod.Name = "tex_username_lod";
            this.tex_username_lod.Size = new System.Drawing.Size(166, 20);
            this.tex_username_lod.TabIndex = 0;
            this.tex_username_lod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tex_password_lod
            // 
            this.tex_password_lod.Location = new System.Drawing.Point(122, 38);
            this.tex_password_lod.Name = "tex_password_lod";
            this.tex_password_lod.Size = new System.Drawing.Size(166, 20);
            this.tex_password_lod.TabIndex = 1;
            this.tex_password_lod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tex_password_lod.UseSystemPasswordChar = true;
            // 
            // but_login_lod
            // 
            this.but_login_lod.Location = new System.Drawing.Point(12, 119);
            this.but_login_lod.Name = "but_login_lod";
            this.but_login_lod.Size = new System.Drawing.Size(100, 23);
            this.but_login_lod.TabIndex = 2;
            this.but_login_lod.Text = "log in";
            this.but_login_lod.UseVisualStyleBackColor = true;
            this.but_login_lod.Click += new System.EventHandler(this.but_login_lod_Click);
            // 
            // but_ok_lod
            // 
            this.but_ok_lod.Location = new System.Drawing.Point(13, 61);
            this.but_ok_lod.Name = "but_ok_lod";
            this.but_ok_lod.Size = new System.Drawing.Size(275, 23);
            this.but_ok_lod.TabIndex = 3;
            this.but_ok_lod.Text = "ok";
            this.but_ok_lod.UseVisualStyleBackColor = true;
            this.but_ok_lod.Click += new System.EventHandler(this.but_ok_lod_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(294, 15);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(53, 13);
            this.username.TabIndex = 5;
            this.username.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "password";
            // 
            // loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 152);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.but_ok_lod);
            this.Controls.Add(this.but_login_lod);
            this.Controls.Add(this.tex_password_lod);
            this.Controls.Add(this.tex_username_lod);
            this.Name = "loading";
            this.Text = "Loading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.TextBox tex_username_lod;
        public  System.Windows.Forms.TextBox tex_password_lod;
        private System.Windows.Forms.Button but_login_lod;
        private System.Windows.Forms.Button but_ok_lod;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label2;
    }
}

