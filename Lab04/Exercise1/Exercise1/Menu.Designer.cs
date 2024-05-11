namespace Exercise1
{
    partial class Menu
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
            btnEx1 = new Button();
            btnEx2 = new Button();
            btnEx4 = new Button();
            btnEx3 = new Button();
            btnEx5 = new Button();
            btnEx6 = new Button();
            btnEx7 = new Button();
            SuspendLayout();
            // 
            // btnEx1
            // 
            btnEx1.Location = new Point(172, 87);
            btnEx1.Margin = new Padding(4, 5, 4, 5);
            btnEx1.Name = "btnEx1";
            btnEx1.Size = new Size(244, 104);
            btnEx1.TabIndex = 0;
            btnEx1.Text = "Bai 01";
            btnEx1.UseVisualStyleBackColor = true;
            btnEx1.Click += btnEx1_Click;
            // 
            // btnEx2
            // 
            btnEx2.Location = new Point(662, 87);
            btnEx2.Margin = new Padding(4, 5, 4, 5);
            btnEx2.Name = "btnEx2";
            btnEx2.Size = new Size(244, 104);
            btnEx2.TabIndex = 1;
            btnEx2.Text = "Bai 02";
            btnEx2.UseVisualStyleBackColor = true;
            btnEx2.Click += btnEx2_Click;
            // 
            // btnEx4
            // 
            btnEx4.Location = new Point(662, 249);
            btnEx4.Margin = new Padding(4, 5, 4, 5);
            btnEx4.Name = "btnEx4";
            btnEx4.Size = new Size(244, 104);
            btnEx4.TabIndex = 3;
            btnEx4.Text = "Bai 04";
            btnEx4.UseVisualStyleBackColor = true;
            btnEx4.Click += btnEx4_Click;
            // 
            // btnEx3
            // 
            btnEx3.Location = new Point(172, 249);
            btnEx3.Margin = new Padding(4, 5, 4, 5);
            btnEx3.Name = "btnEx3";
            btnEx3.Size = new Size(244, 104);
            btnEx3.TabIndex = 2;
            btnEx3.Text = "Bai 03";
            btnEx3.UseVisualStyleBackColor = true;
            btnEx3.Click += btnEx3_Click;
            // 
            // btnEx5
            // 
            btnEx5.Location = new Point(172, 410);
            btnEx5.Margin = new Padding(4, 5, 4, 5);
            btnEx5.Name = "btnEx5";
            btnEx5.Size = new Size(244, 104);
            btnEx5.TabIndex = 4;
            btnEx5.Text = "Bai 05";
            btnEx5.UseVisualStyleBackColor = true;
            btnEx5.Click += btnEx5_Click;
            // 
            // btnEx6
            // 
            btnEx6.Location = new Point(662, 410);
            btnEx6.Margin = new Padding(4, 5, 4, 5);
            btnEx6.Name = "btnEx6";
            btnEx6.Size = new Size(244, 104);
            btnEx6.TabIndex = 5;
            btnEx6.Text = "Bai 06";
            btnEx6.UseVisualStyleBackColor = true;
            btnEx6.Click += btnEx6_Click;
            // 
            // btnEx7
            // 
            btnEx7.Location = new Point(417, 566);
            btnEx7.Margin = new Padding(4, 5, 4, 5);
            btnEx7.Name = "btnEx7";
            btnEx7.Size = new Size(244, 104);
            btnEx7.TabIndex = 6;
            btnEx7.Text = "Bai 07";
            btnEx7.UseVisualStyleBackColor = true;
            btnEx7.Click += btnEx7_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 698);
            Controls.Add(btnEx7);
            Controls.Add(btnEx6);
            Controls.Add(btnEx5);
            Controls.Add(btnEx4);
            Controls.Add(btnEx3);
            Controls.Add(btnEx2);
            Controls.Add(btnEx1);
            Font = new Font("Segoe UI Variable Small", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEx1;
        private Button btnEx2;
        private Button btnEx4;
        private Button btnEx3;
        private Button btnEx5;
        private Button btnEx6;
        private Button btnEx7;
    }
}
