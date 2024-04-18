namespace Exercise5
{
    partial class HNAG_Client
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HNAG_Client));
            ListViewItem listViewItem1 = new ListViewItem("Bánh canh cua", "banhcanhcua.png");
            ListViewItem listViewItem2 = new ListViewItem("Bánh hỏi heo quay", "banhhoiheoquay.png");
            ListViewItem listViewItem3 = new ListViewItem("Bún đậu mắm tôm", "bundaumamtom.png");
            ListViewItem listViewItem4 = new ListViewItem("Bún thịt nướng", "bunthitnuong.png");
            ListViewItem listViewItem5 = new ListViewItem("Cơm gà", "comga.png");
            ListViewItem listViewItem6 = new ListViewItem("Cơm sườn", "comsuon.png");
            imageList1 = new ImageList(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            foodName12 = new TextBox();
            pictureBox1 = new PictureBox();
            btnChoose1 = new Button();
            btnAdd1 = new Button();
            foodName11 = new TextBox();
            btnBrowse1 = new Button();
            label7 = new Label();
            label6 = new Label();
            foodImage1 = new TextBox();
            label5 = new Label();
            listView1 = new ListView();
            tabPage2 = new TabPage();
            userName2 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            foodName22 = new TextBox();
            pictureBox2 = new PictureBox();
            btnChoose2 = new Button();
            foodImage2 = new TextBox();
            btnAdd2 = new Button();
            tenanh = new Label();
            btnBrowse2 = new Button();
            label4 = new Label();
            label3 = new Label();
            foodName21 = new TextBox();
            label2 = new Label();
            userName = new TextBox();
            label1 = new Label();
            listView2 = new ListView();
            imageList2 = new ImageList(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "banhcanhcua.png");
            imageList1.Images.SetKeyName(1, "banhhoiheoquay.png");
            imageList1.Images.SetKeyName(2, "bundaumamtom.png");
            imageList1.Images.SetKeyName(3, "bunthitnuong.png");
            imageList1.Images.SetKeyName(4, "comga.png");
            imageList1.Images.SetKeyName(5, "comsuon.png");
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(847, 546);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ButtonShadow;
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(foodName12);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(btnChoose1);
            tabPage1.Controls.Add(btnAdd1);
            tabPage1.Controls.Add(foodName11);
            tabPage1.Controls.Add(btnBrowse1);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(foodImage1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(listView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(839, 513);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cá nhân";
            // 
            // foodName12
            // 
            foodName12.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodName12.Location = new Point(54, 407);
            foodName12.Multiline = true;
            foodName12.Name = "foodName12";
            foodName12.Size = new Size(246, 34);
            foodName12.TabIndex = 10;
            foodName12.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(75, 201);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnChoose1
            // 
            btnChoose1.BackColor = Color.Yellow;
            btnChoose1.Location = new Point(95, 457);
            btnChoose1.Name = "btnChoose1";
            btnChoose1.Size = new Size(161, 50);
            btnChoose1.TabIndex = 8;
            btnChoose1.Text = "Chọn";
            btnChoose1.UseVisualStyleBackColor = false;
            btnChoose1.Click += btnChoose1_Click;
            // 
            // btnAdd1
            // 
            btnAdd1.BackColor = Color.Lime;
            btnAdd1.Location = new Point(95, 124);
            btnAdd1.Name = "btnAdd1";
            btnAdd1.Size = new Size(161, 50);
            btnAdd1.TabIndex = 7;
            btnAdd1.Text = "Thêm món ăn";
            btnAdd1.UseVisualStyleBackColor = false;
            btnAdd1.Click += btnAdd1_Click;
            // 
            // foodName11
            // 
            foodName11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodName11.Location = new Point(95, 48);
            foodName11.Multiline = true;
            foodName11.Name = "foodName11";
            foodName11.Size = new Size(246, 34);
            foodName11.TabIndex = 6;
            // 
            // btnBrowse1
            // 
            btnBrowse1.BackColor = SystemColors.ActiveCaption;
            btnBrowse1.Location = new Point(247, 89);
            btnBrowse1.Name = "btnBrowse1";
            btnBrowse1.Size = new Size(94, 29);
            btnBrowse1.TabIndex = 5;
            btnBrowse1.Text = "Duyệt ...";
            btnBrowse1.UseVisualStyleBackColor = false;
            btnBrowse1.Click += btnBrowse1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 89);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 4;
            label7.Text = "Hình ảnh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 48);
            label6.Name = "label6";
            label6.Size = new Size(38, 25);
            label6.TabIndex = 3;
            label6.Text = "Tên";
            // 
            // foodImage1
            // 
            foodImage1.Location = new Point(95, 89);
            foodImage1.Name = "foodImage1";
            foodImage1.Size = new Size(146, 27);
            foodImage1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 6);
            label5.Name = "label5";
            label5.Size = new Size(154, 25);
            label5.TabIndex = 1;
            label5.Text = "Thông tin món ăn";
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6 });
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(347, 6);
            listView1.Name = "listView1";
            listView1.Size = new Size(489, 501);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ButtonShadow;
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(userName2);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(foodName22);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(btnChoose2);
            tabPage2.Controls.Add(foodImage2);
            tabPage2.Controls.Add(btnAdd2);
            tabPage2.Controls.Add(tenanh);
            tabPage2.Controls.Add(btnBrowse2);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(foodName21);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(userName);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(listView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(839, 513);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cộng đồng";
            // 
            // userName2
            // 
            userName2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName2.Location = new Point(148, 399);
            userName2.Multiline = true;
            userName2.Name = "userName2";
            userName2.Size = new Size(193, 34);
            userName2.TabIndex = 16;
            userName2.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 402);
            label9.Name = "label9";
            label9.Size = new Size(139, 25);
            label9.TabIndex = 15;
            label9.Text = "Người cung cấp";
            label9.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 356);
            label8.Name = "label8";
            label8.Size = new Size(80, 25);
            label8.TabIndex = 14;
            label8.Text = "Tên món";
            label8.Visible = false;
            // 
            // foodName22
            // 
            foodName22.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodName22.Location = new Point(89, 353);
            foodName22.Multiline = true;
            foodName22.Name = "foodName22";
            foodName22.Size = new Size(252, 34);
            foodName22.TabIndex = 13;
            foodName22.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(112, 237);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 110);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // btnChoose2
            // 
            btnChoose2.BackColor = Color.Yellow;
            btnChoose2.Location = new Point(89, 457);
            btnChoose2.Name = "btnChoose2";
            btnChoose2.Size = new Size(161, 50);
            btnChoose2.TabIndex = 11;
            btnChoose2.Text = "Chọn";
            btnChoose2.UseVisualStyleBackColor = false;
            btnChoose2.Click += btnChoose2_Click;
            // 
            // foodImage2
            // 
            foodImage2.Location = new Point(89, 146);
            foodImage2.Multiline = true;
            foodImage2.Name = "foodImage2";
            foodImage2.Size = new Size(152, 27);
            foodImage2.TabIndex = 10;
            // 
            // btnAdd2
            // 
            btnAdd2.BackColor = Color.Lime;
            btnAdd2.Location = new Point(89, 181);
            btnAdd2.Name = "btnAdd2";
            btnAdd2.Size = new Size(161, 50);
            btnAdd2.TabIndex = 9;
            btnAdd2.Text = "Thêm món ăn";
            btnAdd2.UseVisualStyleBackColor = false;
            btnAdd2.Click += btnAdd2_Click;
            // 
            // tenanh
            // 
            tenanh.AutoSize = true;
            tenanh.Location = new Point(89, 150);
            tenanh.Name = "tenanh";
            tenanh.Size = new Size(0, 20);
            tenanh.TabIndex = 7;
            // 
            // btnBrowse2
            // 
            btnBrowse2.BackColor = SystemColors.ActiveCaption;
            btnBrowse2.Location = new Point(247, 146);
            btnBrowse2.Name = "btnBrowse2";
            btnBrowse2.Size = new Size(94, 29);
            btnBrowse2.TabIndex = 4;
            btnBrowse2.Text = "Duyệt ...";
            btnBrowse2.UseVisualStyleBackColor = false;
            btnBrowse2.Click += btnBrowse2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 146);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 6;
            label4.Text = "Hình ảnh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 102);
            label3.Name = "label3";
            label3.Size = new Size(38, 25);
            label3.TabIndex = 5;
            label3.Text = "Tên";
            // 
            // foodName21
            // 
            foodName21.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodName21.Location = new Point(89, 99);
            foodName21.Multiline = true;
            foodName21.Name = "foodName21";
            foodName21.Size = new Size(252, 34);
            foodName21.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 3;
            label2.Text = "Thông tin món ăn";
            // 
            // userName
            // 
            userName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.Location = new Point(6, 34);
            userName.Multiline = true;
            userName.Name = "userName";
            userName.Size = new Size(335, 34);
            userName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 1;
            label1.Text = "Tên người dùng";
            // 
            // listView2
            // 
            listView2.LargeImageList = imageList2;
            listView2.Location = new Point(347, 6);
            listView2.Name = "listView2";
            listView2.Size = new Size(489, 501);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(60, 60);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // HNAG_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(871, 570);
            Controls.Add(tabControl1);
            DoubleBuffered = true;
            Name = "HNAG_Client";
            Text = "HNAG_Client";
            FormClosed += HNAG_Client_FormClosed;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView listView2;
        private TextBox userName;
        private Label label1;
        private Label label3;
        private TextBox foodName21;
        private Label label2;
        private Label tenanh;
        private Button btnBrowse2;
        private Label label4;
        private Button btnAdd2;
        private TextBox foodImage2;
        private ListView listView1;
        private Button btnBrowse1;
        private Label label7;
        private Label label6;
        private TextBox foodImage1;
        private Label label5;
        private TextBox foodName11;
        private Button btnAdd1;
        private ImageList imageList2;
        private Button btnChoose2;
        private PictureBox pictureBox2;
        private TextBox foodName22;
        private TextBox userName2;
        private Label label9;
        private Label label8;
        private TextBox foodName12;
        private PictureBox pictureBox1;
        private Button btnChoose1;
    }
}