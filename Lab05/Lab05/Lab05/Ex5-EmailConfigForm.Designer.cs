namespace Lab05
{
    partial class Ex5_EmailConfigForm
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            txtSmtpPort = new TextBox();
            txtSmtpServer = new TextBox();
            txtImapPort = new TextBox();
            txtImapServer = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnSaveExit = new Button();
            btnTestConnection = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 38);
            label1.TabIndex = 0;
            label1.Text = "Email Config";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(txtSmtpPort);
            groupBox1.Controls.Add(txtSmtpServer);
            groupBox1.Controls.Add(txtImapPort);
            groupBox1.Controls.Add(txtImapServer);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(617, 178);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Email Server Configuration";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Enabled = false;
            checkBox2.Location = new Point(395, 128);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(105, 24);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "RequireSSL";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(100, 128);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(109, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Require SSL";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtSmtpPort
            // 
            txtSmtpPort.Location = new Point(395, 76);
            txtSmtpPort.Name = "txtSmtpPort";
            txtSmtpPort.ReadOnly = true;
            txtSmtpPort.Size = new Size(192, 27);
            txtSmtpPort.TabIndex = 7;
            txtSmtpPort.Text = "587";
            // 
            // txtSmtpServer
            // 
            txtSmtpServer.Location = new Point(395, 31);
            txtSmtpServer.Name = "txtSmtpServer";
            txtSmtpServer.ReadOnly = true;
            txtSmtpServer.Size = new Size(192, 27);
            txtSmtpServer.TabIndex = 6;
            txtSmtpServer.Text = "smtp@gmail.com";
            // 
            // txtImapPort
            // 
            txtImapPort.Location = new Point(100, 76);
            txtImapPort.Name = "txtImapPort";
            txtImapPort.ReadOnly = true;
            txtImapPort.Size = new Size(192, 27);
            txtImapPort.TabIndex = 5;
            txtImapPort.Text = "993";
            // 
            // txtImapServer
            // 
            txtImapServer.Location = new Point(100, 35);
            txtImapServer.Name = "txtImapServer";
            txtImapServer.ReadOnly = true;
            txtImapServer.Size = new Size(192, 27);
            txtImapServer.TabIndex = 4;
            txtImapServer.Text = "imap@gmail.com";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(313, 38);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 3;
            label5.Text = "SMTP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(313, 79);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 2;
            label4.Text = "SMTP Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 79);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 1;
            label3.Text = "IMAP Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 38);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 0;
            label2.Text = "IMAP";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(txtUsername);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 265);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(416, 178);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Account";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(94, 135);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(316, 27);
            txtPassword.TabIndex = 10;
            txtPassword.Text = "jhyncclcmqriubui";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(94, 86);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(316, 27);
            txtUsername.TabIndex = 9;
            txtUsername.Text = "wibitoichoi@gmail.com";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(94, 36);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(316, 27);
            textBox5.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 138);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 2;
            label8.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 89);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 1;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 39);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 0;
            label6.Text = "Nickname";
            // 
            // btnSaveExit
            // 
            btnSaveExit.BackColor = Color.FromArgb(255, 128, 0);
            btnSaveExit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveExit.Location = new Point(434, 380);
            btnSaveExit.Name = "btnSaveExit";
            btnSaveExit.Size = new Size(195, 63);
            btnSaveExit.TabIndex = 8;
            btnSaveExit.Text = "Save and Exit";
            btnSaveExit.UseVisualStyleBackColor = false;
            // 
            // btnTestConnection
            // 
            btnTestConnection.BackColor = Color.Yellow;
            btnTestConnection.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTestConnection.Location = new Point(434, 333);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(195, 41);
            btnTestConnection.TabIndex = 9;
            btnTestConnection.Text = "Test connection";
            btnTestConnection.UseVisualStyleBackColor = false;
            // 
            // Ex5_EmailConfigForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            CancelButton = btnSaveExit;
            ClientSize = new Size(641, 457);
            Controls.Add(btnTestConnection);
            Controls.Add(btnSaveExit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Ex5_EmailConfigForm";
            Text = "Ex5_EmailConfigForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtImapServer;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtSmtpPort;
        private TextBox txtSmtpServer;
        private TextBox txtImapPort;
        private Button btnSaveExit;
        private Button btnTestConnection;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox textBox5;
        private Label label8;
        private Label label7;
        private Label label6;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}