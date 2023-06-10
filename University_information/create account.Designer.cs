namespace University_information
{
    partial class create
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.but_previous_lod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Student",
            "Master",
            "Employees"});
            this.comboBox1.Location = new System.Drawing.Point(33, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "choose one";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_previous_lod
            // 
            this.but_previous_lod.BackColor = System.Drawing.SystemColors.Window;
            this.but_previous_lod.ForeColor = System.Drawing.Color.Red;
            this.but_previous_lod.Location = new System.Drawing.Point(88, 75);
            this.but_previous_lod.Name = "but_previous_lod";
            this.but_previous_lod.Size = new System.Drawing.Size(105, 23);
            this.but_previous_lod.TabIndex = 2;
            this.but_previous_lod.Text = "previous";
            this.but_previous_lod.UseVisualStyleBackColor = false;
            this.but_previous_lod.Click += new System.EventHandler(this.but_previous_lod_Click);
            // 
            // create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 110);
            this.Controls.Add(this.but_previous_lod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "create";
            this.Text = "create_account";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button but_previous_lod;
    }
}