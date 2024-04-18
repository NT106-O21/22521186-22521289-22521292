namespace Exercise6
{
    partial class Receiver
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
            btnSendFile = new Button();
            btnSend = new Button();
            txtSendBox = new TextBox();
            ChatBox = new RichTextBox();
            SuspendLayout();
            // 
            // btnSendFile
            // 
            btnSendFile.Location = new Point(645, 410);
            btnSendFile.Name = "btnSendFile";
            btnSendFile.Size = new Size(43, 29);
            btnSendFile.TabIndex = 7;
            btnSendFile.Text = "...";
            btnSendFile.UseVisualStyleBackColor = true;
            btnSendFile.Click += btnSendFile_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(694, 410);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtSendBox
            // 
            txtSendBox.Location = new Point(12, 410);
            txtSendBox.Name = "txtSendBox";
            txtSendBox.Size = new Size(627, 27);
            txtSendBox.TabIndex = 5;
            // 
            // ChatBox
            // 
            ChatBox.Location = new Point(12, 11);
            ChatBox.Name = "ChatBox";
            ChatBox.Size = new Size(776, 393);
            ChatBox.TabIndex = 4;
            ChatBox.Text = "";
            // 
            // Receiver
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSendFile);
            Controls.Add(btnSend);
            Controls.Add(txtSendBox);
            Controls.Add(ChatBox);
            Name = "Receiver";
            Text = "Receiver";
            FormClosed += Receiver_FormClosed;
            Load += Receiver_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSendFile;
        private Button btnSend;
        private TextBox txtSendBox;
        private RichTextBox ChatBox;
    }
}