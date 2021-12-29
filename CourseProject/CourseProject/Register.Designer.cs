namespace CourseProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_login = new System.Windows.Forms.TextBox();
            this.textBox2_pass = new System.Windows.Forms.TextBox();
            this.textBox3_conf_pass = new System.Windows.Forms.TextBox();
            this.textBox4_city = new System.Windows.Forms.TextBox();
            this.textBox5_phone = new System.Windows.Forms.TextBox();
            this.textBox6_Name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // textBox1_login
            // 
            this.textBox1_login.Location = new System.Drawing.Point(142, 51);
            this.textBox1_login.Name = "textBox1_login";
            this.textBox1_login.Size = new System.Drawing.Size(158, 20);
            this.textBox1_login.TabIndex = 1;
            this.textBox1_login.TextChanged += new System.EventHandler(this.textBox1_login_TextChanged);
            // 
            // textBox2_pass
            // 
            this.textBox2_pass.Location = new System.Drawing.Point(142, 77);
            this.textBox2_pass.Name = "textBox2_pass";
            this.textBox2_pass.PasswordChar = '*';
            this.textBox2_pass.Size = new System.Drawing.Size(158, 20);
            this.textBox2_pass.TabIndex = 1;
            // 
            // textBox3_conf_pass
            // 
            this.textBox3_conf_pass.Location = new System.Drawing.Point(142, 104);
            this.textBox3_conf_pass.Name = "textBox3_conf_pass";
            this.textBox3_conf_pass.PasswordChar = '*';
            this.textBox3_conf_pass.Size = new System.Drawing.Size(158, 20);
            this.textBox3_conf_pass.TabIndex = 1;
            // 
            // textBox4_city
            // 
            this.textBox4_city.Location = new System.Drawing.Point(142, 130);
            this.textBox4_city.Name = "textBox4_city";
            this.textBox4_city.Size = new System.Drawing.Size(158, 20);
            this.textBox4_city.TabIndex = 1;
            // 
            // textBox5_phone
            // 
            this.textBox5_phone.Location = new System.Drawing.Point(142, 156);
            this.textBox5_phone.Name = "textBox5_phone";
            this.textBox5_phone.Size = new System.Drawing.Size(158, 20);
            this.textBox5_phone.TabIndex = 1;
            // 
            // textBox6_Name
            // 
            this.textBox6_Name.Location = new System.Drawing.Point(142, 182);
            this.textBox6_Name.Name = "textBox6_Name";
            this.textBox6_Name.Size = new System.Drawing.Size(158, 20);
            this.textBox6_Name.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Создать учёную запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Уже есть учётная запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Подтверждение пароля";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Город";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Номер телефона";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "ФИО";
            // 
            // textBox7_email
            // 
            this.textBox7_email.Location = new System.Drawing.Point(142, 208);
            this.textBox7_email.Name = "textBox7_email";
            this.textBox7_email.Size = new System.Drawing.Size(158, 20);
            this.textBox7_email.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Email";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 362);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7_email);
            this.Controls.Add(this.textBox6_Name);
            this.Controls.Add(this.textBox5_phone);
            this.Controls.Add(this.textBox4_city);
            this.Controls.Add(this.textBox3_conf_pass);
            this.Controls.Add(this.textBox2_pass);
            this.Controls.Add(this.textBox1_login);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Register";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_login;
        private System.Windows.Forms.TextBox textBox2_pass;
        private System.Windows.Forms.TextBox textBox3_conf_pass;
        private System.Windows.Forms.TextBox textBox4_city;
        private System.Windows.Forms.TextBox textBox5_phone;
        private System.Windows.Forms.TextBox textBox6_Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7_email;
        private System.Windows.Forms.Label label8;
    }
}