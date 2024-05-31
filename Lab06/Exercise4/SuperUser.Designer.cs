namespace Exercise4
{
    partial class SuperUser
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
            label5 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            cbbRoom = new ComboBox();
            cbbFilmName = new ComboBox();
            btnBuy = new Button();
            txtCheckedBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            clbListUser = new CheckedListBox();
            btnLock = new Button();
            btnUnlock = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 290);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 24;
            label5.Text = "Giá tiền:";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(101, 287);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(242, 31);
            txtPrice.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 22;
            label4.Text = "Số ghế đã chọn";
            // 
            // cbbRoom
            // 
            cbbRoom.FormattingEnabled = true;
            cbbRoom.Location = new Point(176, 253);
            cbbRoom.Name = "cbbRoom";
            cbbRoom.Size = new Size(169, 28);
            cbbRoom.TabIndex = 21;
            cbbRoom.SelectedValueChanged += cbbRoom_SelectedValueChanged;
            // 
            // cbbFilmName
            // 
            cbbFilmName.FormattingEnabled = true;
            cbbFilmName.Location = new Point(12, 253);
            cbbFilmName.Name = "cbbFilmName";
            cbbFilmName.Size = new Size(160, 28);
            cbbFilmName.TabIndex = 20;
            cbbFilmName.TextChanged += cbbFilmName_TextChanged;
            // 
            // btnBuy
            // 
            btnBuy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuy.Location = new Point(12, 329);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(333, 39);
            btnBuy.TabIndex = 19;
            btnBuy.Text = "Đặt mua";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // txtCheckedBox
            // 
            txtCheckedBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCheckedBox.Location = new Point(12, 216);
            txtCheckedBox.Name = "txtCheckedBox";
            txtCheckedBox.ReadOnly = true;
            txtCheckedBox.Size = new Size(333, 31);
            txtCheckedBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 17;
            label3.Text = "C";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 16;
            label2.Text = "B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(24, 25);
            label1.TabIndex = 15;
            label1.Text = "A";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(333, 34);
            textBox1.TabIndex = 14;
            textBox1.Text = "Screen";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // clbListUser
            // 
            clbListUser.FormattingEnabled = true;
            clbListUser.Location = new Point(351, 12);
            clbListUser.Name = "clbListUser";
            clbListUser.Size = new Size(476, 312);
            clbListUser.TabIndex = 25;
            // 
            // btnLock
            // 
            btnLock.Location = new Point(633, 339);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(94, 29);
            btnLock.TabIndex = 26;
            btnLock.Text = "Lock";
            btnLock.UseVisualStyleBackColor = true;
            btnLock.Click += btnLock_Click;
            // 
            // btnUnlock
            // 
            btnUnlock.Location = new Point(733, 339);
            btnUnlock.Name = "btnUnlock";
            btnUnlock.Size = new Size(94, 29);
            btnUnlock.TabIndex = 27;
            btnUnlock.Text = "Unlock";
            btnUnlock.UseVisualStyleBackColor = true;
            btnUnlock.Click += btnUnlock_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(351, 338);
            label6.Name = "label6";
            label6.Size = new Size(199, 30);
            label6.TabIndex = 28;
            label6.Text = "Pleaseee!! Just One";
            // 
            // SuperUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 380);
            Controls.Add(label6);
            Controls.Add(btnUnlock);
            Controls.Add(btnLock);
            Controls.Add(clbListUser);
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
            Name = "SuperUser";
            Text = "SuperUser";
            FormClosing += Receiption1_FormClosing;
            Load += Rct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtPrice;
        private Label label4;
        private ComboBox cbbRoom;
        private ComboBox cbbFilmName;
        private Button btnBuy;
        private TextBox txtCheckedBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private CheckedListBox clbListUser;
        private Button btnLock;
        private Button btnUnlock;
        private Label label6;
    }
}