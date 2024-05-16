namespace Lab04
{
    partial class _7_FormDangNhap
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
            label4 = new Label();
            btnLogIn = new Button();
            label3 = new Label();
            pass = new TextBox();
            name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            labelSignUp = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(205, 123);
            label4.Name = "label4";
            label4.Size = new Size(186, 28);
            label4.TabIndex = 21;
            label4.Text = "Chưa tạo tài khoản?";
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(255, 128, 0);
            btnLogIn.Location = new Point(397, 46);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(102, 60);
            btnLogIn.TabIndex = 20;
            btnLogIn.Text = "Đăng nhập";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(187, 9);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 19;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // pass
            // 
            pass.Location = new Point(135, 79);
            pass.Name = "pass";
            pass.Size = new Size(256, 27);
            pass.TabIndex = 17;
            // 
            // name
            // 
            name.Location = new Point(135, 46);
            name.Name = "name";
            name.Size = new Size(256, 27);
            name.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 82);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 15;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 53);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 14;
            label1.Text = "Tên đăng nhập";
            // 
            // labelSignUp
            // 
            labelSignUp.AutoSize = true;
            labelSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSignUp.ForeColor = Color.Blue;
            labelSignUp.Location = new Point(397, 123);
            labelSignUp.Name = "labelSignUp";
            labelSignUp.Size = new Size(84, 28);
            labelSignUp.TabIndex = 22;
            labelSignUp.Text = "Đăng ký";
            labelSignUp.Click += labelSignUp_Click;
            // 
            // _7_FormDangNhap
            // 
            AcceptButton = btnLogIn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(513, 174);
            Controls.Add(labelSignUp);
            Controls.Add(label4);
            Controls.Add(btnLogIn);
            Controls.Add(label3);
            Controls.Add(pass);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "_7_FormDangNhap";
            Text = "Hôm nay ăn gì? - Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnLogIn;
        private Label label3;
        private TextBox pass;
        private TextBox name;
        private Label label2;
        private Label label1;
        private Label labelSignUp;
    }
}