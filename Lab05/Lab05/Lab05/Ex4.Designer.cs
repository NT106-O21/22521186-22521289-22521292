namespace Lab05
{
    partial class Ex4
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
            panel_listfilm = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(343, 46);
            label1.TabIndex = 0;
            label1.Text = "PHIM ĐANG CHIẾU";
            // 
            // panel_listfilm
            // 
            panel_listfilm.AutoScroll = true;
            panel_listfilm.BorderStyle = BorderStyle.FixedSingle;
            panel_listfilm.Location = new Point(12, 58);
            panel_listfilm.Name = "panel_listfilm";
            panel_listfilm.Size = new Size(658, 576);
            panel_listfilm.TabIndex = 1;
            // 
            // FormBT4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 646);
            Controls.Add(panel_listfilm);
            Controls.Add(label1);
            Name = "FormBT4";
            Text = "Rạp phim";
            Load += FormBT4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel_listfilm;
    }
}