namespace Lab04
{
    partial class _7_FormAdd
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
            foodname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            price = new TextBox();
            address = new TextBox();
            picture = new TextBox();
            description = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(113, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 31);
            label1.TabIndex = 1;
            label1.Text = "THÊM MÓN ĂN";
            // 
            // foodname
            // 
            foodname.Location = new Point(113, 73);
            foodname.Name = "foodname";
            foodname.Size = new Size(285, 27);
            foodname.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên món ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 4;
            label3.Text = "Giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 142);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 5;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 175);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 6;
            label5.Text = "Hình ảnh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 208);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 7;
            label6.Text = "Mô tả";
            // 
            // price
            // 
            price.Location = new Point(113, 106);
            price.Name = "price";
            price.Size = new Size(285, 27);
            price.TabIndex = 8;
            // 
            // address
            // 
            address.Location = new Point(113, 139);
            address.Name = "address";
            address.Size = new Size(285, 27);
            address.TabIndex = 9;
            // 
            // picture
            // 
            picture.Location = new Point(113, 172);
            picture.Name = "picture";
            picture.Size = new Size(285, 27);
            picture.TabIndex = 10;
            // 
            // description
            // 
            description.Location = new Point(113, 205);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(285, 146);
            description.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Yellow;
            btnAdd.Location = new Point(304, 357);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Location = new Point(201, 357);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // _7_FormAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(408, 396);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(description);
            Controls.Add(picture);
            Controls.Add(address);
            Controls.Add(price);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(foodname);
            Controls.Add(label1);
            Name = "_7_FormAdd";
            Text = "Thêm món ăn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox foodname;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox price;
        private TextBox address;
        private TextBox picture;
        private TextBox description;
        private Button btnAdd;
        private Button btnClear;
    }
}