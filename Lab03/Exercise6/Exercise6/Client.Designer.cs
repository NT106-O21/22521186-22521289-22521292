namespace Exercise6
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
            lstChatBox = new ListBox();
            grpParticipants = new GroupBox();
            lstParticipants = new ListBox();
            txtUserName = new TextBox();
            txtMessage = new TextBox();
            btnConnect = new Button();
            btnSend = new Button();
            grpUser = new GroupBox();
            grpMessage = new GroupBox();
            grpParticipants.SuspendLayout();
            grpUser.SuspendLayout();
            grpMessage.SuspendLayout();
            SuspendLayout();
            // 
            // lstChatBox
            // 
            lstChatBox.FormattingEnabled = true;
            lstChatBox.Location = new Point(12, 12);
            lstChatBox.Name = "lstChatBox";
            lstChatBox.Size = new Size(690, 384);
            lstChatBox.TabIndex = 0;
            // 
            // grpParticipants
            // 
            grpParticipants.Controls.Add(lstParticipants);
            grpParticipants.Location = new Point(708, 12);
            grpParticipants.Name = "grpParticipants";
            grpParticipants.Size = new Size(240, 580);
            grpParticipants.TabIndex = 1;
            grpParticipants.TabStop = false;
            grpParticipants.Text = "Participants";
            // 
            // lstParticipants
            // 
            lstParticipants.FormattingEnabled = true;
            lstParticipants.Location = new Point(6, 26);
            lstParticipants.Name = "lstParticipants";
            lstParticipants.Size = new Size(228, 544);
            lstParticipants.TabIndex = 0;
            lstParticipants.SelectedIndexChanged += lstParticipants_SelectedIndexChanged;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(10, 26);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(229, 27);
            txtUserName.TabIndex = 2;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(10, 26);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(574, 79);
            txtMessage.TabIndex = 3;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(288, 26);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 29);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(590, 49);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 5;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // grpUser
            // 
            grpUser.Controls.Add(txtUserName);
            grpUser.Controls.Add(btnConnect);
            grpUser.Location = new Point(12, 402);
            grpUser.Name = "grpUser";
            grpUser.Size = new Size(690, 67);
            grpUser.TabIndex = 6;
            grpUser.TabStop = false;
            grpUser.Text = "User";
            // 
            // grpMessage
            // 
            grpMessage.Controls.Add(txtMessage);
            grpMessage.Controls.Add(btnSend);
            grpMessage.Location = new Point(12, 477);
            grpMessage.Name = "grpMessage";
            grpMessage.Size = new Size(690, 115);
            grpMessage.TabIndex = 7;
            grpMessage.TabStop = false;
            grpMessage.Text = "Messages";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 604);
            Controls.Add(grpMessage);
            Controls.Add(grpUser);
            Controls.Add(grpParticipants);
            Controls.Add(lstChatBox);
            Name = "Client";
            Text = "Client";
            FormClosed += Client_FormClosed;
            grpParticipants.ResumeLayout(false);
            grpUser.ResumeLayout(false);
            grpUser.PerformLayout();
            grpMessage.ResumeLayout(false);
            grpMessage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstChatBox;
        private GroupBox grpParticipants;
        private TextBox txtUserName;
        private TextBox txtMessage;
        private Button btnConnect;
        private Button btnSend;
        private ListBox lstParticipants;
        private GroupBox grpUser;
        private GroupBox grpMessage;
    }
}