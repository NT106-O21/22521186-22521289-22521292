﻿namespace Exercise4
{
    partial class Receiption
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCheckedBox = new TextBox();
            btnBuy = new Button();
            cbbFilmName = new ComboBox();
            cbbRoom = new ComboBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(333, 34);
            textBox1.TabIndex = 0;
            textBox1.Text = "Screen";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(24, 25);
            label1.TabIndex = 1;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 2;
            label2.Text = "B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 3;
            label3.Text = "C";
            // 
            // txtCheckedBox
            // 
            txtCheckedBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCheckedBox.Location = new Point(12, 216);
            txtCheckedBox.Name = "txtCheckedBox";
            txtCheckedBox.ReadOnly = true;
            txtCheckedBox.Size = new Size(333, 31);
            txtCheckedBox.TabIndex = 7;
            // 
            // btnBuy
            // 
            btnBuy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuy.Location = new Point(12, 324);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(333, 39);
            btnBuy.TabIndex = 8;
            btnBuy.Text = "Đặt mua";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // cbbFilmName
            // 
            cbbFilmName.FormattingEnabled = true;
            cbbFilmName.Location = new Point(12, 253);
            cbbFilmName.Name = "cbbFilmName";
            cbbFilmName.Size = new Size(160, 28);
            cbbFilmName.TabIndex = 9;
            cbbFilmName.TextChanged += cbbFilmName_TextChanged;
            // 
            // cbbRoom
            // 
            cbbRoom.FormattingEnabled = true;
            cbbRoom.Location = new Point(176, 253);
            cbbRoom.Name = "cbbRoom";
            cbbRoom.Size = new Size(169, 28);
            cbbRoom.TabIndex = 10;
            cbbRoom.SelectedValueChanged += cbbRoom_SelectedValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 11;
            label4.Text = "Số ghế đã chọn";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(101, 287);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(242, 31);
            txtPrice.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 290);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 13;
            label5.Text = "Giá tiền:";
            // 
            // Receiption
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 406);
            Controls.Add(label5);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(cbbRoom);
            Controls.Add(cbbFilmName);
            Controls.Add(btnBuy);
            Controls.Add(txtCheckedBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Receiption";
            Text = "Quầy";
            FormClosing += Receiption1_FormClosing;
            Load += Rct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        /*private CheckBox A1;
        private CheckBox B1;
        private CheckBox C1;*/
        private TextBox txtCheckedBox;
        private Button btnBuy;
        private ComboBox cbbFilmName;
        private ComboBox cbbRoom;
        private Label label4;
        private TextBox txtPrice;
        private Label label5;
    }
}