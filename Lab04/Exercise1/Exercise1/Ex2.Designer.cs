namespace Lab04
{
    partial class Ex2
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
            btnBrowse = new Button();
            rtbOutput = new RichTextBox();
            btnDowload = new Button();
            txtPath = new TextBox();
            txtUrl = new TextBox();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(694, 43);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 9;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // rtbOutput
            // 
            rtbOutput.Location = new Point(12, 78);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.Size = new Size(776, 360);
            rtbOutput.TabIndex = 8;
            rtbOutput.Text = "";
            // 
            // btnDowload
            // 
            btnDowload.Location = new Point(694, 12);
            btnDowload.Name = "btnDowload";
            btnDowload.Size = new Size(94, 29);
            btnDowload.TabIndex = 7;
            btnDowload.Text = "Dowload";
            btnDowload.UseVisualStyleBackColor = true;
            btnDowload.Click += btnDowload_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(12, 45);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(676, 27);
            txtPath.TabIndex = 6;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(12, 12);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(676, 27);
            txtUrl.TabIndex = 5;
            // 
            // Ex2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBrowse);
            Controls.Add(rtbOutput);
            Controls.Add(btnDowload);
            Controls.Add(txtPath);
            Controls.Add(txtUrl);
            Name = "Ex2";
            Text = "Ex2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowse;
        private RichTextBox rtbOutput;
        private Button btnDowload;
        private TextBox txtPath;
        private TextBox txtUrl;
    }
}