namespace Lab05
{
    partial class Ex6
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
            lb_Tai_Khoan = new Label();
            lb_Mat_Khau = new Label();
            txt_Tai_Khoan = new TextBox();
            txt_Mat_Khau = new TextBox();
            txt_Port_IMAP = new TextBox();
            txt_IMAP = new TextBox();
            lb_Port_IMAP = new Label();
            lb_IMAP = new Label();
            txt_Port_SMTP = new TextBox();
            txt_SMTP = new TextBox();
            lb_Port_SMTP = new Label();
            lb_SMTP = new Label();
            btn_Login = new Button();
            btn_Logout = new Button();
            btn_Send = new Button();
            btn_Refresh = new Button();
            lv_mails = new ListView();
            No_of_mail = new ColumnHeader();
            Source = new ColumnHeader();
            Title = new ColumnHeader();
            Time = new ColumnHeader();
            SuspendLayout();
            // 
            // lb_Tai_Khoan
            // 
            lb_Tai_Khoan.AutoSize = true;
            lb_Tai_Khoan.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Tai_Khoan.Location = new Point(13, 25);
            lb_Tai_Khoan.Name = "lb_Tai_Khoan";
            lb_Tai_Khoan.Size = new Size(164, 37);
            lb_Tai_Khoan.TabIndex = 0;
            lb_Tai_Khoan.Text = "Tài Khoản";
            // 
            // lb_Mat_Khau
            // 
            lb_Mat_Khau.AutoSize = true;
            lb_Mat_Khau.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Mat_Khau.Location = new Point(19, 91);
            lb_Mat_Khau.Name = "lb_Mat_Khau";
            lb_Mat_Khau.Size = new Size(149, 37);
            lb_Mat_Khau.TabIndex = 1;
            lb_Mat_Khau.Text = "Mật khẩu";
            // 
            // txt_Tai_Khoan
            // 
            txt_Tai_Khoan.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Tai_Khoan.Location = new Point(193, 22);
            txt_Tai_Khoan.Margin = new Padding(3, 4, 3, 4);
            txt_Tai_Khoan.Name = "txt_Tai_Khoan";
            txt_Tai_Khoan.Size = new Size(616, 44);
            txt_Tai_Khoan.TabIndex = 2;
            txt_Tai_Khoan.Text = "wibitoichoi@gmail.com";
            // 
            // txt_Mat_Khau
            // 
            txt_Mat_Khau.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Mat_Khau.Location = new Point(193, 92);
            txt_Mat_Khau.Margin = new Padding(3, 4, 3, 4);
            txt_Mat_Khau.Name = "txt_Mat_Khau";
            txt_Mat_Khau.PasswordChar = '*';
            txt_Mat_Khau.Size = new Size(616, 44);
            txt_Mat_Khau.TabIndex = 3;
            txt_Mat_Khau.Text = "jhyncclcmqriubui";
            // 
            // txt_Port_IMAP
            // 
            txt_Port_IMAP.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Port_IMAP.Location = new Point(1030, 92);
            txt_Port_IMAP.Margin = new Padding(3, 4, 3, 4);
            txt_Port_IMAP.Name = "txt_Port_IMAP";
            txt_Port_IMAP.Size = new Size(368, 44);
            txt_Port_IMAP.TabIndex = 7;
            txt_Port_IMAP.Text = "993";
            // 
            // txt_IMAP
            // 
            txt_IMAP.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_IMAP.Location = new Point(1030, 22);
            txt_IMAP.Margin = new Padding(3, 4, 3, 4);
            txt_IMAP.Name = "txt_IMAP";
            txt_IMAP.Size = new Size(368, 44);
            txt_IMAP.TabIndex = 6;
            txt_IMAP.Text = "imap.gmail.com";
            // 
            // lb_Port_IMAP
            // 
            lb_Port_IMAP.AutoSize = true;
            lb_Port_IMAP.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Port_IMAP.Location = new Point(916, 95);
            lb_Port_IMAP.Name = "lb_Port_IMAP";
            lb_Port_IMAP.Size = new Size(76, 37);
            lb_Port_IMAP.TabIndex = 5;
            lb_Port_IMAP.Text = "Port";
            // 
            // lb_IMAP
            // 
            lb_IMAP.AutoSize = true;
            lb_IMAP.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_IMAP.Location = new Point(916, 29);
            lb_IMAP.Name = "lb_IMAP";
            lb_IMAP.Size = new Size(94, 37);
            lb_IMAP.TabIndex = 4;
            lb_IMAP.Text = "IMAP";
            // 
            // txt_Port_SMTP
            // 
            txt_Port_SMTP.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Port_SMTP.Location = new Point(1607, 95);
            txt_Port_SMTP.Margin = new Padding(3, 4, 3, 4);
            txt_Port_SMTP.Name = "txt_Port_SMTP";
            txt_Port_SMTP.Size = new Size(368, 44);
            txt_Port_SMTP.TabIndex = 11;
            txt_Port_SMTP.Text = "587";
            // 
            // txt_SMTP
            // 
            txt_SMTP.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_SMTP.Location = new Point(1607, 25);
            txt_SMTP.Margin = new Padding(3, 4, 3, 4);
            txt_SMTP.Name = "txt_SMTP";
            txt_SMTP.Size = new Size(368, 44);
            txt_SMTP.TabIndex = 10;
            txt_SMTP.Text = "smtp.gmail.com";
            // 
            // lb_Port_SMTP
            // 
            lb_Port_SMTP.AutoSize = true;
            lb_Port_SMTP.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Port_SMTP.Location = new Point(1483, 91);
            lb_Port_SMTP.Name = "lb_Port_SMTP";
            lb_Port_SMTP.Size = new Size(76, 37);
            lb_Port_SMTP.TabIndex = 9;
            lb_Port_SMTP.Text = "Port";
            // 
            // lb_SMTP
            // 
            lb_SMTP.AutoSize = true;
            lb_SMTP.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_SMTP.Location = new Point(1478, 25);
            lb_SMTP.Name = "lb_SMTP";
            lb_SMTP.Size = new Size(105, 37);
            lb_SMTP.TabIndex = 8;
            lb_SMTP.Text = "SMTP";
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Login.Location = new Point(13, 158);
            btn_Login.Margin = new Padding(3, 4, 3, 4);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(366, 82);
            btn_Login.TabIndex = 12;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Logout
            // 
            btn_Logout.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Logout.Location = new Point(551, 158);
            btn_Logout.Margin = new Padding(3, 4, 3, 4);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(366, 82);
            btn_Logout.TabIndex = 13;
            btn_Logout.Text = "Logout";
            btn_Logout.UseVisualStyleBackColor = true;
            btn_Logout.Visible = false;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // btn_Send
            // 
            btn_Send.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Send.Location = new Point(1076, 158);
            btn_Send.Margin = new Padding(3, 4, 3, 4);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(366, 82);
            btn_Send.TabIndex = 14;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Visible = false;
            btn_Send.Click += btn_Send_Click;
            // 
            // btn_Refresh
            // 
            btn_Refresh.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Refresh.Location = new Point(1607, 158);
            btn_Refresh.Margin = new Padding(3, 4, 3, 4);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(369, 82);
            btn_Refresh.TabIndex = 15;
            btn_Refresh.Text = "Refresh";
            btn_Refresh.UseVisualStyleBackColor = true;
            btn_Refresh.Visible = false;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // lv_mails
            // 
            lv_mails.Alignment = ListViewAlignment.SnapToGrid;
            lv_mails.Columns.AddRange(new ColumnHeader[] { No_of_mail, Source, Title, Time });
            lv_mails.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_mails.FullRowSelect = true;
            lv_mails.Location = new Point(13, 269);
            lv_mails.Margin = new Padding(3, 4, 3, 4);
            lv_mails.Name = "lv_mails";
            lv_mails.Size = new Size(1962, 955);
            lv_mails.TabIndex = 16;
            lv_mails.UseCompatibleStateImageBehavior = false;
            lv_mails.View = View.Details;
            lv_mails.Click += lv_mails_Click;
            // 
            // No_of_mail
            // 
            No_of_mail.Text = "#";
            // 
            // Source
            // 
            Source.Text = "From";
            Source.Width = 432;
            // 
            // Title
            // 
            Title.Text = "Subject";
            Title.Width = 372;
            // 
            // Time
            // 
            Time.Text = "Datetime";
            Time.Width = 293;
            // 
            // Ex6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1170);
            Controls.Add(lv_mails);
            Controls.Add(btn_Refresh);
            Controls.Add(btn_Send);
            Controls.Add(btn_Logout);
            Controls.Add(btn_Login);
            Controls.Add(txt_Port_SMTP);
            Controls.Add(txt_SMTP);
            Controls.Add(lb_Port_SMTP);
            Controls.Add(lb_SMTP);
            Controls.Add(txt_Port_IMAP);
            Controls.Add(txt_IMAP);
            Controls.Add(lb_Port_IMAP);
            Controls.Add(lb_IMAP);
            Controls.Add(txt_Mat_Khau);
            Controls.Add(txt_Tai_Khoan);
            Controls.Add(lb_Mat_Khau);
            Controls.Add(lb_Tai_Khoan);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ex6";
            Text = "Ex6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lb_Tai_Khoan;
        private System.Windows.Forms.Label lb_Mat_Khau;
        private System.Windows.Forms.TextBox txt_Tai_Khoan;
        private System.Windows.Forms.TextBox txt_Mat_Khau;
        private System.Windows.Forms.TextBox txt_Port_IMAP;
        private System.Windows.Forms.TextBox txt_IMAP;
        private System.Windows.Forms.Label lb_Port_IMAP;
        private System.Windows.Forms.Label lb_IMAP;
        private System.Windows.Forms.TextBox txt_Port_SMTP;
        private System.Windows.Forms.TextBox txt_SMTP;
        private System.Windows.Forms.Label lb_Port_SMTP;
        private System.Windows.Forms.Label lb_SMTP;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ListView lv_mails;
        private System.Windows.Forms.ColumnHeader No_of_mail;
        private System.Windows.Forms.ColumnHeader Source;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Time;
    }
}

