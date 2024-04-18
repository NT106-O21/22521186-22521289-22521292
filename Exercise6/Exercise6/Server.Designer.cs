namespace Exercise6
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
            lstChatBox = new ListBox();
            btnListen = new Button();
            SuspendLayout();
            // 
            // lstChatBox
            // 
            lstChatBox.FormattingEnabled = true;
            lstChatBox.Location = new Point(12, 77);
            lstChatBox.Name = "lstChatBox";
            lstChatBox.Size = new Size(776, 344);
            lstChatBox.TabIndex = 0;
            // 
            // btnListen
            // 
            btnListen.Location = new Point(694, 42);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(94, 29);
            btnListen.TabIndex = 1;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListen);
            Controls.Add(lstChatBox);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstChatBox;
        private Button btnListen;
        private Button Listen;
    }
}