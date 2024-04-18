namespace Exercise3
{
    partial class FormDangNhap
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
            btnClient = new Button();
            btnServer = new Button();
            SuspendLayout();
            // 
            // btnClient
            // 
            btnClient.BackColor = SystemColors.ActiveCaption;
            btnClient.Location = new Point(104, 66);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(94, 29);
            btnClient.TabIndex = 0;
            btnClient.Text = "Client";
            btnClient.UseVisualStyleBackColor = false;
            btnClient.Click += btnClient_Click;
            // 
            // btnServer
            // 
            btnServer.BackColor = SystemColors.ActiveCaption;
            btnServer.Location = new Point(270, 66);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(94, 29);
            btnServer.TabIndex = 1;
            btnServer.Text = "Server";
            btnServer.UseVisualStyleBackColor = false;
            btnServer.Click += btnServer_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(481, 171);
            Controls.Add(btnServer);
            Controls.Add(btnClient);
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClient;
        private Button btnServer;
    }
}