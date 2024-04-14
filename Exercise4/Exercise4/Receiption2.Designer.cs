namespace Exercise4
{
    partial class Receiption2
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
            btnBuy = new Button();
            txtCheckedBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnBuy
            // 
            btnBuy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuy.Location = new Point(12, 212);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(331, 39);
            btnBuy.TabIndex = 14;
            btnBuy.Text = "Đặt mua";
            btnBuy.UseVisualStyleBackColor = true;
            // 
            // txtCheckedBox
            // 
            txtCheckedBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCheckedBox.Location = new Point(12, 175);
            txtCheckedBox.Name = "txtCheckedBox";
            txtCheckedBox.Size = new Size(331, 31);
            txtCheckedBox.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 12;
            label3.Text = "C";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 11;
            label2.Text = "B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(24, 25);
            label1.TabIndex = 10;
            label1.Text = "A";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(333, 34);
            textBox1.TabIndex = 9;
            textBox1.Text = "Screen";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Receiption2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 281);
            Controls.Add(btnBuy);
            Controls.Add(txtCheckedBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Receiption2";
            Text = "Receiption2";
            Load += Rct2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuy;
        private TextBox txtCheckedBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
    }
}