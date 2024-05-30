namespace Lab05
{
    partial class Ex3
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
            lbEmail = new Label();
            lbPassword = new Label();
            lbTotal = new Label();
            lbRecent = new Label();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            dataGridView1 = new DataGridView();
            cbShowPass = new CheckBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(25, 35);
            lbEmail.Margin = new Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(54, 25);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(25, 89);
            lbPassword.Margin = new Padding(4, 0, 4, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(87, 25);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(26, 177);
            lbTotal.Margin = new Padding(4, 0, 4, 0);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(49, 25);
            lbTotal.TabIndex = 2;
            lbTotal.Text = "Total";
            // 
            // lbRecent
            // 
            lbRecent.AutoSize = true;
            lbRecent.Location = new Point(279, 177);
            lbRecent.Margin = new Padding(4, 0, 4, 0);
            lbRecent.Name = "lbRecent";
            lbRecent.Size = new Size(64, 25);
            lbRecent.TabIndex = 3;
            lbRecent.Text = "Recent";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(117, 25);
            tbEmail.Margin = new Padding(4, 5, 4, 5);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(319, 32);
            tbEmail.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(117, 80);
            tbPassword.Margin = new Padding(4, 5, 4, 5);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(319, 32);
            tbPassword.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 213);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(847, 314);
            dataGridView1.TabIndex = 7;
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.Location = new Point(117, 120);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(164, 29);
            cbShowPass.TabIndex = 11;
            cbShowPass.Text = "Show password";
            cbShowPass.UseVisualStyleBackColor = true;
            cbShowPass.CheckedChanged += cbShowPass_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(541, 46);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(147, 45);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // Ex3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 541);
            Controls.Add(btnLogin);
            Controls.Add(cbShowPass);
            Controls.Add(dataGridView1);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(lbRecent);
            Controls.Add(lbTotal);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Ex3";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbRecent;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CheckBox cbShowPass;
        private Button btnLogin;
    }
}

