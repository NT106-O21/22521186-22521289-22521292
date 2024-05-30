namespace Lab05
{
    partial class Ex2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_mail = new Label();
            lb_pass = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnLogin = new Button();
            lb_total = new Label();
            lb_recent = new Label();
            lb_show_total = new Label();
            lb_show_recent = new Label();
            cbShowPass = new CheckBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lb_mail
            // 
            lb_mail.AutoSize = true;
            lb_mail.Location = new Point(22, 27);
            lb_mail.Name = "lb_mail";
            lb_mail.Size = new Size(58, 25);
            lb_mail.TabIndex = 0;
            lb_mail.Text = "Email:";
            // 
            // lb_pass
            // 
            lb_pass.AutoSize = true;
            lb_pass.Location = new Point(22, 79);
            lb_pass.Name = "lb_pass";
            lb_pass.Size = new Size(91, 25);
            lb_pass.TabIndex = 1;
            lb_pass.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(115, 73);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(297, 31);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "jhyncclcmqriubui";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(115, 21);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(297, 31);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "wibitoichoi@gmail.com";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(560, 30);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(147, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.Location = new Point(22, 156);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(53, 25);
            lb_total.TabIndex = 5;
            lb_total.Text = "Total:";
            // 
            // lb_recent
            // 
            lb_recent.AutoSize = true;
            lb_recent.Location = new Point(207, 156);
            lb_recent.Name = "lb_recent";
            lb_recent.Size = new Size(68, 25);
            lb_recent.TabIndex = 6;
            lb_recent.Text = "Recent:";
            // 
            // lb_show_total
            // 
            lb_show_total.AutoSize = true;
            lb_show_total.Location = new Point(104, 156);
            lb_show_total.Name = "lb_show_total";
            lb_show_total.Size = new Size(0, 25);
            lb_show_total.TabIndex = 8;
            // 
            // lb_show_recent
            // 
            lb_show_recent.AutoSize = true;
            lb_show_recent.Location = new Point(304, 156);
            lb_show_recent.Name = "lb_show_recent";
            lb_show_recent.Size = new Size(0, 25);
            lb_show_recent.TabIndex = 9;
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.Location = new Point(115, 110);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(164, 29);
            cbShowPass.TabIndex = 10;
            cbShowPass.Text = "Show password";
            cbShowPass.UseVisualStyleBackColor = true;
            cbShowPass.CheckedChanged += cbShowPass_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(753, 225);
            dataGridView1.TabIndex = 15;
            // 
            // Ex2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 450);
            Controls.Add(dataGridView1);
            Controls.Add(cbShowPass);
            Controls.Add(lb_show_recent);
            Controls.Add(lb_show_total);
            Controls.Add(lb_recent);
            Controls.Add(lb_total);
            Controls.Add(btnLogin);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(lb_pass);
            Controls.Add(lb_mail);
            Name = "Ex2";
            Text = "Ex2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_mail;
        private Label lb_pass;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnLogin;
        private Label lb_total;
        private Label lb_recent;
        private Label lb_show_total;
        private Label lb_show_recent;
        private CheckBox cbShowPass;
        private DataGridView dataGridView1;
    }
}