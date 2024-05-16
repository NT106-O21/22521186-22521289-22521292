namespace Lab04
{
    partial class Ex3
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
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            btnDownFile = new Button();
            btnReload = new Button();
            btnBrowse = new Button();
            btnLoad = new Button();
            txtPath = new TextBox();
            txtUrl = new TextBox();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 78);
            webView21.Name = "webView21";
            webView21.Size = new Size(776, 360);
            webView21.TabIndex = 19;
            webView21.ZoomFactor = 1D;
            // 
            // btnDownFile
            // 
            btnDownFile.Location = new Point(594, 44);
            btnDownFile.Name = "btnDownFile";
            btnDownFile.Size = new Size(94, 29);
            btnDownFile.TabIndex = 18;
            btnDownFile.Text = "DownFile";
            btnDownFile.UseVisualStyleBackColor = true;
            btnDownFile.Click += btnDownFile_Click;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(594, 12);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(94, 29);
            btnReload.TabIndex = 17;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(694, 43);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 16;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(694, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 15;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(12, 45);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(576, 27);
            txtPath.TabIndex = 14;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(12, 12);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(576, 27);
            txtUrl.TabIndex = 13;
            // 
            // Ex3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webView21);
            Controls.Add(btnDownFile);
            Controls.Add(btnReload);
            Controls.Add(btnBrowse);
            Controls.Add(btnLoad);
            Controls.Add(txtPath);
            Controls.Add(txtUrl);
            Name = "Ex3";
            Text = "Ex3";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button btnDownFile;
        private Button btnReload;
        private Button btnBrowse;
        private Button btnLoad;
        private TextBox txtPath;
        private TextBox txtUrl;
    }
}