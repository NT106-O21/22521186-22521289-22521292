namespace Lab05
{
    partial class Ex4_Detail
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
            panel_Website = new Panel();
            SuspendLayout();
            // 
            // panel_Website
            // 
            panel_Website.Location = new Point(12, 12);
            panel_Website.Name = "panel_Website";
            panel_Website.Size = new Size(758, 729);
            panel_Website.TabIndex = 0;
            // 
            // FormBT4_Detail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 753);
            Controls.Add(panel_Website);
            Name = "FormBT4_Detail";
            Text = "FormBT4_Detail";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Website;
    }
}