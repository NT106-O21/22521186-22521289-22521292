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
            imageList1 = new ImageList(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnAdd1 = new Button();
            foodName1 = new TextBox();
            btnBrowse1 = new Button();
            label7 = new Label();
            label6 = new Label();
            foodImage1 = new TextBox();
            label5 = new Label();
            listView1 = new ListView();
            tabPage2 = new TabPage();
            foodImage2 = new TextBox();
            btnAdd2 = new Button();
            tenanh = new Label();
            btnBrowse2 = new Button();
            label4 = new Label();
            label3 = new Label();
            foodName2 = new TextBox();
            label2 = new Label();
            userName = new TextBox();
            label1 = new Label();
            listView2 = new ListView();
            imageList2 = new ImageList(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(60, 60);
            imageList1.TransparentColor = Color.Transparent;
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
            tabPage1.Controls.Add(btnAdd1);
            tabPage1.Controls.Add(foodName1);
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
            // foodName1
            // 
            foodName1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodName1.Location = new Point(95, 48);
            foodName1.Multiline = true;
            foodName1.Name = "foodName1";
            foodName1.Size = new Size(246, 34);
            foodName1.TabIndex = 6;
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
            tabPage2.Controls.Add(foodImage2);
            tabPage2.Controls.Add(btnAdd2);
            tabPage2.Controls.Add(tenanh);
            tabPage2.Controls.Add(btnBrowse2);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(foodName2);
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
            // foodName2
            // 
            foodName2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodName2.Location = new Point(89, 99);
            foodName2.Multiline = true;
            foodName2.Name = "foodName2";
            foodName2.Size = new Size(252, 34);
            foodName2.TabIndex = 4;
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private TextBox foodName2;
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
        private TextBox foodName1;
        private Button btnAdd1;
        private ImageList imageList2;
    }
}