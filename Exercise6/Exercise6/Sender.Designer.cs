namespace Exercise6
{
    partial class Sender
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
            ChatBox = new RichTextBox();
            txtSendBox = new TextBox();
            btnSend = new Button();
            btnSendFile = new Button();
            SuspendLayout();
            // 
            // ChatBox
            // 
            ChatBox.Location = new Point(12, 12);
            ChatBox.Name = "ChatBox";
            ChatBox.Size = new Size(776, 393);
            ChatBox.TabIndex = 0;
            ChatBox.Text = "";
            // 
            // txtSendBox
            // 
            txtSendBox.Location = new Point(12, 411);
            txtSendBox.Name = "txtSendBox";
            txtSendBox.Size = new Size(627, 27);
            txtSendBox.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(694, 411);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnSendFile
            // 
            btnSendFile.Location = new Point(645, 411);
            btnSendFile.Name = "btnSendFile";
            btnSendFile.Size = new Size(43, 29);
            btnSendFile.TabIndex = 3;
            btnSendFile.Text = "...";
            btnSendFile.UseVisualStyleBackColor = true;
            btnSendFile.Click += btnSendFile_Click;
            // 
            // Sender
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSendFile);
            Controls.Add(btnSend);
            Controls.Add(txtSendBox);
            Controls.Add(ChatBox);
            Name = "Sender";
            Text = "Receiver";
            FormClosed += Sender_FormClosed;
            Load += Sender_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox ChatBox;
        private TextBox txtSendBox;
        private Button btnSend;
        private Button btnSendFile;
    }
}