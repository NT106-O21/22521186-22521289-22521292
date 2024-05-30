namespace Lab05
{
    partial class Ex4_Display
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
            pictureBox_film = new PictureBox();
            label_name = new Label();
            label_link = new Label();
            btn_detail = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_film).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_film
            // 
            pictureBox_film.Location = new Point(3, 3);
            pictureBox_film.Name = "pictureBox_film";
            pictureBox_film.Size = new Size(193, 158);
            pictureBox_film.TabIndex = 0;
            pictureBox_film.TabStop = false;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_name.ForeColor = SystemColors.HotTrack;
            label_name.Location = new Point(202, 3);
            label_name.Name = "label_name";
            label_name.Size = new Size(80, 31);
            label_name.TabIndex = 1;
            label_name.Text = "label1";
            // 
            // label_link
            // 
            label_link.AutoSize = true;
            label_link.Location = new Point(202, 46);
            label_link.Name = "label_link";
            label_link.Size = new Size(50, 20);
            label_link.TabIndex = 2;
            label_link.Text = "label2";
            // 
            // btn_detail
            // 
            btn_detail.BackColor = Color.White;
            btn_detail.FlatStyle = FlatStyle.Flat;
            btn_detail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_detail.Location = new Point(202, 80);
            btn_detail.Name = "btn_detail";
            btn_detail.Size = new Size(146, 33);
            btn_detail.TabIndex = 3;
            btn_detail.Text = "Xem chi tiết";
            btn_detail.UseVisualStyleBackColor = false;
            btn_detail.Click += btn_detail_Click;
            // 
            // FormBT4_Display
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_detail);
            Controls.Add(label_link);
            Controls.Add(label_name);
            Controls.Add(pictureBox_film);
            Name = "FormBT4_Display";
            Size = new Size(658, 164);
            ((System.ComponentModel.ISupportInitialize)pictureBox_film).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_film;
        private Label label_name;
        private Label label_link;
        private Button btn_detail;
    }
}
