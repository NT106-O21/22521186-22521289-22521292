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
            label1 = new Label();
            btnAddFood = new Button();
            btnChoose = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tabPage2 = new TabPage();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            pagesizeList = new ComboBox();
            currentpageList = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 31);
            label1.TabIndex = 0;
            label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.Yellow;
            btnAddFood.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddFood.ForeColor = SystemColors.ControlText;
            btnAddFood.Location = new Point(392, 48);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(131, 48);
            btnAddFood.TabIndex = 1;
            btnAddFood.Text = "Thêm món ăn";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnChoose
            // 
            btnChoose.BackColor = Color.FromArgb(255, 128, 0);
            btnChoose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChoose.ForeColor = SystemColors.ControlText;
            btnChoose.Location = new Point(255, 48);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(131, 48);
            btnChoose.TabIndex = 2;
            btnChoose.Text = "Chọn món ăn";
            btnChoose.UseVisualStyleBackColor = false;
            btnChoose.Click += btnChoose_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 102);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(511, 469);
            tabControl1.TabIndex = 3;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(flowLayoutPanel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(503, 436);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cộng đồng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(6, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(491, 427);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(flowLayoutPanel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(503, 436);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cá nhân";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Location = new Point(6, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(491, 427);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(255, 9);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(446, 11);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 5;
            label3.Text = "Đăng xuất";
            label3.Click += label3_Click;
            // 
            // pagesizeList
            // 
            pagesizeList.FormattingEnabled = true;
            pagesizeList.Items.AddRange(new object[] { "10", "15", "20" });
            pagesizeList.Location = new Point(452, 577);
            pagesizeList.Name = "pagesizeList";
            pagesizeList.Size = new Size(71, 28);
            pagesizeList.TabIndex = 8;
            pagesizeList.SelectedIndexChanged += pagesizeList_SelectedIndexChanged;
            // 
            // currentpageList
            // 
            currentpageList.FormattingEnabled = true;
            currentpageList.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            currentpageList.Location = new Point(290, 577);
            currentpageList.Name = "currentpageList";
            currentpageList.Size = new Size(71, 28);
            currentpageList.TabIndex = 9;
            currentpageList.SelectedIndexChanged += currentpageList_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(367, 580);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 10;
            label4.Text = "Kích thước";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(238, 580);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 11;
            label5.Text = "Trang";
            // 
            // Ex7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(535, 631);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(currentpageList);
            Controls.Add(pagesizeList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tabControl1);
            Controls.Add(btnChoose);
            Controls.Add(btnAddFood);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Ex7";
            Text = "Ex7";
            Load += Ex7_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddFood;
        private Button btnChoose;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel2;
        private ComboBox pagesizeList;
        private ComboBox currentpageList;
        private Label label4;
        private Label label5;
    }
}