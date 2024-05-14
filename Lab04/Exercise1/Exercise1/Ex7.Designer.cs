namespace Lab04
{
    partial class Ex7
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
            btnSignUp = new Button();
            pass = new TextBox();
            name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnLogIn = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.ActiveCaption;
            btnSignUp.Location = new Point(316, 207);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(94, 29);
            btnSignUp.TabIndex = 9;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // pass
            // 
            pass.Location = new Point(163, 151);
            pass.Name = "pass";
            pass.Size = new Size(247, 27);
            pass.TabIndex = 8;
            // 
            // name
            // 
            name.Location = new Point(163, 104);
            name.Name = "name";
            name.Size = new Size(247, 27);
            name.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 154);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 107);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(240, 37);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 10;
            label3.Text = "Log In";
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = SystemColors.ActiveCaption;
            btnLogIn.Location = new Point(163, 207);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(94, 29);
            btnLogIn.TabIndex = 11;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 252);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(592, 310);
            textBox1.TabIndex = 12;
            // 
            // Ex7
            // 
            AcceptButton = btnLogIn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(616, 574);
            Controls.Add(textBox1);
            Controls.Add(btnLogIn);
            Controls.Add(label3);
            Controls.Add(btnSignUp);
            Controls.Add(pass);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ex7";
            Text = "Ex7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private TextBox pass;
        private TextBox name;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnLogIn;
        private TextBox textBox1;
    }
}