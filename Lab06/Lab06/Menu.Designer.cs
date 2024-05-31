namespace Lab06
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
            btnEx3 = new Button();
            btnEx2 = new Button();
            btnEx1 = new Button();
            SuspendLayout();
            // 
            // btnEx3
            // 
            btnEx3.Location = new Point(344, 289);
            btnEx3.Name = "btnEx3";
            btnEx3.Size = new Size(112, 34);
            btnEx3.TabIndex = 5;
            btnEx3.Text = "Bai 3";
            btnEx3.UseVisualStyleBackColor = true;
            btnEx3.Click += btnEx3_Click;
            // 
            // btnEx2
            // 
            btnEx2.Location = new Point(344, 207);
            btnEx2.Name = "btnEx2";
            btnEx2.Size = new Size(112, 34);
            btnEx2.TabIndex = 4;
            btnEx2.Text = "Bai 2";
            btnEx2.UseVisualStyleBackColor = true;
            btnEx2.Click += btnEx2_Click;
            // 
            // btnEx1
            // 
            btnEx1.Location = new Point(344, 128);
            btnEx1.Name = "btnEx1";
            btnEx1.Size = new Size(112, 34);
            btnEx1.TabIndex = 3;
            btnEx1.Text = "Bai 1";
            btnEx1.UseVisualStyleBackColor = true;
            btnEx1.Click += btnEx1_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEx3);
            Controls.Add(btnEx2);
            Controls.Add(btnEx1);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEx3;
        private Button btnEx2;
        private Button btnEx1;
    }
}
