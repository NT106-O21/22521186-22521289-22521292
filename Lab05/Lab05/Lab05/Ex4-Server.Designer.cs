namespace Lab05
{
    partial class Ex4_Server
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
            btnAddClient = new Button();
            rtbInput = new RichTextBox();
            rtbLog = new RichTextBox();
            SuspendLayout();
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(727, 409);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(94, 29);
            btnAddClient.TabIndex = 6;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // rtbInput
            // 
            rtbInput.Location = new Point(421, 12);
            rtbInput.Name = "rtbInput";
            rtbInput.ReadOnly = true;
            rtbInput.Size = new Size(400, 391);
            rtbInput.TabIndex = 5;
            rtbInput.Text = "";
            // 
            // rtbLog
            // 
            rtbLog.Location = new Point(12, 12);
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.Size = new Size(403, 391);
            rtbLog.TabIndex = 4;
            rtbLog.Text = "";
            // 
            // Ex4_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 450);
            Controls.Add(btnAddClient);
            Controls.Add(rtbInput);
            Controls.Add(rtbLog);
            Name = "Ex4_Server";
            Text = "Ex4_Server";
            FormClosing += Ex4_Server_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddClient;
        private RichTextBox rtbInput;
        private RichTextBox rtbLog;
    }
}