namespace Lab04
{
    partial class _7_FormDangKy
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
            label2 = new Label();
            name = new TextBox();
            pass = new TextBox();
            btnSignUp = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 85);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 132);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // name
            // 
            name.Location = new Point(170, 82);
            name.Name = "name";
            name.Size = new Size(247, 27);
            name.TabIndex = 2;
            // 
            // pass
            // 
            pass.Location = new Point(170, 129);
            pass.Name = "pass";
            pass.Size = new Size(247, 27);
            pass.TabIndex = 3;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.ActiveCaption;
            btnSignUp.Location = new Point(170, 181);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(94, 29);
            btnSignUp.TabIndex = 4;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(247, 24);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 5;
            label3.Text = "Sign In";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 182);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 115);
            textBox1.TabIndex = 6;
            // 
            // _7_FormDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(659, 349);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(btnSignUp);
            Controls.Add(pass);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "_7_FormDangKy";
            Text = "_7_FormDangKy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox name;
        private TextBox pass;
        private Button btnSignUp;
        private Label label3;
        private TextBox textBox1;
    }
}