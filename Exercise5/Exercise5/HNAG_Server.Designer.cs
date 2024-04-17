namespace Exercise5
{
    partial class HNAG_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HNAG_Server));
            ListViewItem listViewItem7 = new ListViewItem("Bánh canh cua", "banhcanhcua.png");
            ListViewItem listViewItem8 = new ListViewItem("Bánh hỏi heo quay", "banhhoiheoquay.png");
            ListViewItem listViewItem9 = new ListViewItem("Bún đậu mắm tôm", "bundaumamtom.png");
            ListViewItem listViewItem10 = new ListViewItem("Bún thịt nướng", "bunthitnuong.png");
            ListViewItem listViewItem11 = new ListViewItem("Cơm gà", "comga.png");
            ListViewItem listViewItem12 = new ListViewItem("Cơm sườn", "comsuon.png");
            imageList1 = new ImageList(components);
            listView1 = new ListView();
            reportBox = new ListBox();
            btnUpdate = new Button();
            btnDelete = new Button();
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
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem7, listViewItem8, listViewItem9, listViewItem10, listViewItem11, listViewItem12 });
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(464, 518);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // reportBox
            // 
            reportBox.FormattingEnabled = true;
            reportBox.Location = new Point(482, 12);
            reportBox.Name = "reportBox";
            reportBox.Size = new Size(402, 584);
            reportBox.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 128, 255);
            btnUpdate.ForeColor = SystemColors.ControlText;
            btnUpdate.Location = new Point(12, 536);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(237, 57);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật \r\ndanh sách món ăn";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Lime;
            btnDelete.Location = new Point(255, 536);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(221, 57);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xoá món ăn";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // HNAG_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 605);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(reportBox);
            Controls.Add(listView1);
            DoubleBuffered = true;
            Name = "HNAG_Server";
            Text = "HNAG_Server";
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private ListView listView1;
        private ListBox reportBox;
        private Button btnUpdate;
        private Button btnDelete;
    }
}