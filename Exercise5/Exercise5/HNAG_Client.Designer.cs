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
            tabPage2 = new TabPage();
            btnAdd = new Button();
            tenanh = new Label();
            btnBrowse = new Button();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            listView1 = new ListView();
            textBox3 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
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
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(839, 513);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cá nhân";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ButtonShadow;
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(btnAdd);
            tabPage2.Controls.Add(tenanh);
            tabPage2.Controls.Add(btnBrowse);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(listView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(839, 513);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cộng đồng";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Location = new Point(89, 195);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 50);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm món ăn";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // tenanh
            // 
            tenanh.AutoSize = true;
            tenanh.Location = new Point(89, 150);
            tenanh.Name = "tenanh";
            tenanh.Size = new Size(0, 20);
            tenanh.TabIndex = 7;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = SystemColors.ActiveCaption;
            btnBrowse.Location = new Point(247, 146);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "Duyệt ...";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
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
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(89, 99);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(252, 34);
            textBox2.TabIndex = 4;
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(6, 34);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 34);
            textBox1.TabIndex = 2;
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
            // listView1
            // 
            listView1.Location = new Point(347, 6);
            listView1.Name = "listView1";
            listView1.Size = new Size(489, 501);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(89, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 27);
            textBox3.TabIndex = 10;
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView listView1;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Label tenanh;
        private Button btnBrowse;
        private Label label4;
        private Button btnAdd;
        private TextBox textBox3;
    }
}