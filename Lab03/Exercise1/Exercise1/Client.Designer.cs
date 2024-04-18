namespace Exercise1
{
    partial class Client
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
            label1 = new Label();
            txtIpRemote = new TextBox();
            txtPortBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtSent = new RichTextBox();
            btnSend = new Button();
            btnConnect = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 29);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "IP Remote host";
            // 
            // txtIpRemote
            // 
            txtIpRemote.Location = new Point(33, 52);
            txtIpRemote.Name = "txtIpRemote";
            txtIpRemote.Size = new Size(213, 27);
            txtIpRemote.TabIndex = 1;
            // 
            // txtPortBox
            // 
            txtPortBox.Location = new Point(304, 52);
            txtPortBox.Name = "txtPortBox";
            txtPortBox.Size = new Size(109, 27);
            txtPortBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 29);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 2;
            label2.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 134);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Message";
            // 
            // txtSent
            // 
            txtSent.Location = new Point(33, 166);
            txtSent.Name = "txtSent";
            txtSent.Size = new Size(497, 101);
            txtSent.TabIndex = 5;
            txtSent.Text = "";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(33, 284);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(436, 51);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 29);
            btnConnect.TabIndex = 7;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 335);
            Controls.Add(btnConnect);
            Controls.Add(btnSend);
            Controls.Add(txtSent);
            Controls.Add(label3);
            Controls.Add(txtPortBox);
            Controls.Add(label2);
            Controls.Add(txtIpRemote);
            Controls.Add(label1);
            Name = "Client";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIpRemote;
        private TextBox txtPortBox;
        private Label label2;
        private Label label3;
        private RichTextBox txtSent;
        private Button btnSend;
        private Button btnConnect;
    }
}