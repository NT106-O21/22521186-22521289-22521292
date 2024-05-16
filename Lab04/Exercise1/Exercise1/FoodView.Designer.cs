namespace Lab04
{
    partial class FoodView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureFood = new PictureBox();
            labelName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelPrice = new Label();
            labelAddress = new Label();
            labelContributor = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureFood).BeginInit();
            SuspendLayout();
            // 
            // pictureFood
            // 
            pictureFood.BackgroundImageLayout = ImageLayout.Stretch;
            pictureFood.Dock = DockStyle.Left;
            pictureFood.Location = new Point(0, 0);
            pictureFood.Name = "pictureFood";
            pictureFood.Size = new Size(125, 125);
            pictureFood.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFood.TabIndex = 0;
            pictureFood.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.FromArgb(255, 128, 0);
            labelName.Location = new Point(131, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(70, 28);
            labelName.TabIndex = 1;
            labelName.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 37);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 2;
            label1.Text = "Giá:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(131, 60);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 3;
            label2.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(131, 83);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 4;
            label3.Text = "Đóng góp:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(217, 37);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(50, 20);
            labelPrice.TabIndex = 5;
            labelPrice.Text = "label1";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(217, 60);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(50, 20);
            labelAddress.TabIndex = 6;
            labelAddress.Text = "label2";
            // 
            // labelContributor
            // 
            labelContributor.AutoSize = true;
            labelContributor.ForeColor = Color.Green;
            labelContributor.Location = new Point(217, 83);
            labelContributor.Name = "labelContributor";
            labelContributor.Size = new Size(50, 20);
            labelContributor.TabIndex = 7;
            labelContributor.Text = "label3";
            // 
            // FoodView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelContributor);
            Controls.Add(labelAddress);
            Controls.Add(labelPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelName);
            Controls.Add(pictureFood);
            Name = "FoodView";
            Size = new Size(480, 125);
            ((System.ComponentModel.ISupportInitialize)pictureFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureFood;
        private Label labelName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelPrice;
        private Label labelAddress;
        private Label labelContributor;
    }
}
