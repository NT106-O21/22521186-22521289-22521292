namespace Lab04
{
    partial class Ex1
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
            rtbOutput = new RichTextBox();
            btnBrowse = new Button();
            txtUrl = new TextBox();
            SuspendLayout();
            // 
            // rtbOutput
            // 
            rtbOutput.Location = new Point(12, 46);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.Size = new Size(776, 393);
            rtbOutput.TabIndex = 5;
            rtbOutput.Text = "";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(675, 11);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(113, 29);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(12, 13);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(657, 27);
            txtUrl.TabIndex = 3;
            // 
            // Ex1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbOutput);
            Controls.Add(btnBrowse);
            Controls.Add(txtUrl);
            Name = "Ex1";
            Text = "Ex1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbOutput;
        private Button btnBrowse;
        private TextBox txtUrl;
    }
}