namespace Lab04
{
    partial class Ex5
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
            txtboxData = new TextBox();
            btnLogIn = new Button();
            label3 = new Label();
            btnSignUp = new Button();
            pass = new TextBox();
            name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(223, 132);
            label4.Name = "label4";
            label4.Size = new Size(191, 28);
            label4.TabIndex = 22;
            label4.Text = "Chưa tạo tài khoản ?";
            // 
            // txtboxData
            // 
            txtboxData.Location = new Point(12, 176);
            txtboxData.Multiline = true;
            txtboxData.Name = "txtboxData";
            txtboxData.Size = new Size(587, 183);
            txtboxData.TabIndex = 21;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = SystemColors.ActiveCaption;
            btnLogIn.Location = new Point(429, 45);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(102, 67);
            btnLogIn.TabIndex = 20;
            btnLogIn.Text = "Đăng nhập";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(251, 11);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 19;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.ActiveCaption;
            btnSignUp.Location = new Point(429, 129);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(102, 41);
            btnSignUp.TabIndex = 18;
            btnSignUp.Text = "Đăng ký";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // pass
            // 
            pass.Location = new Point(167, 89);
            pass.Name = "pass";
            pass.Size = new Size(247, 27);
            pass.TabIndex = 17;
            // 
            // name
            // 
            name.Location = new Point(167, 42);
            name.Name = "name";
            name.Size = new Size(247, 27);
            name.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 92);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 15;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 45);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 14;
            label1.Text = "Username";
            // 
            // Ex5
            // 
            AcceptButton = btnLogIn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(611, 371);
            Controls.Add(label4);
            Controls.Add(txtboxData);
            Controls.Add(btnLogIn);
            Controls.Add(label3);
            Controls.Add(btnSignUp);
            Controls.Add(pass);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ex5";
            Text = "Ex5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtboxData;
        private Button btnLogIn;
        private Label label3;
        private Button btnSignUp;
        private TextBox pass;
        private TextBox name;
        private Label label2;
        private Label label1;
    }
}