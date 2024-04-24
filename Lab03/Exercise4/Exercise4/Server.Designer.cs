namespace Exercise4
{
    partial class Server
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
            rtbLog = new RichTextBox();
            rtbInput = new RichTextBox();
            btnStartListen = new Button();
            SuspendLayout();
            // 
            // rtbLog
            // 
            rtbLog.Location = new Point(12, 52);
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.Size = new Size(480, 466);
            rtbLog.TabIndex = 0;
            rtbLog.Text = "";
            // 
            // rtbInput
            // 
            rtbInput.Location = new Point(498, 52);
            rtbInput.Name = "rtbInput";
            rtbInput.ReadOnly = true;
            rtbInput.Size = new Size(405, 466);
            rtbInput.TabIndex = 1;
            rtbInput.Text = "";
            // 
            // btnStartListen
            // 
            btnStartListen.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartListen.Location = new Point(12, 12);
            btnStartListen.Name = "btnStartListen";
            btnStartListen.Size = new Size(190, 34);
            btnStartListen.TabIndex = 2;
            btnStartListen.Text = "Khởi động server";
            btnStartListen.UseVisualStyleBackColor = true;
            btnStartListen.Click += btnStartListen_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 528);
            Controls.Add(btnStartListen);
            Controls.Add(rtbInput);
            Controls.Add(rtbLog);
            Name = "Server";
            Text = "Server";
            FormClosed += Server_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbLog;
        private RichTextBox rtbInput;
        private Button btnStartListen;
    }
}