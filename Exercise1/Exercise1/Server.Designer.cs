namespace Exercise1
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
            txtPortBox = new TextBox();
            label2 = new Label();
            btnListen = new Button();
            label1 = new Label();
            txtSentContent = new RichTextBox();
            SuspendLayout();
            // 
            // txtPortBox
            // 
            txtPortBox.AllowDrop = true;
            txtPortBox.Location = new Point(113, 50);
            txtPortBox.Name = "txtPortBox";
            txtPortBox.Size = new Size(109, 27);
            txtPortBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Location = new Point(70, 53);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 4;
            label2.Text = "Port";
            // 
            // btnListen
            // 
            btnListen.Location = new Point(598, 50);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(94, 29);
            btnListen.TabIndex = 6;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 104);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 7;
            label1.Text = "Received Messages";
            // 
            // txtSentContent
            // 
            txtSentContent.Location = new Point(70, 139);
            txtSentContent.Name = "txtSentContent";
            txtSentContent.Size = new Size(647, 261);
            txtSentContent.TabIndex = 8;
            txtSentContent.Text = "";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSentContent);
            Controls.Add(label1);
            Controls.Add(btnListen);
            Controls.Add(txtPortBox);
            Controls.Add(label2);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPortBox;
        private Label label2;
        private Button btnListen;
        private Label label1;
        private RichTextBox txtSentContent;
    }
}