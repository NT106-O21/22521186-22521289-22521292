namespace Lab05
{
    partial class Ex6_SendMail
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
            lb_From = new Label();
            txt_From = new TextBox();
            Check_HTML = new CheckBox();
            txt_Mail_Content = new RichTextBox();
            btn_Browse = new Button();
            txt_Subject = new TextBox();
            lb_Subject = new Label();
            txt_To = new TextBox();
            lb_To = new Label();
            txt_Name = new TextBox();
            lb_Name = new Label();
            lb_Body = new Label();
            txt_Attachment = new TextBox();
            lb_Attachment = new Label();
            btn_Send = new Button();
            File_URL = new OpenFileDialog();
            SuspendLayout();
            // 
            // lb_From
            // 
            lb_From.AutoSize = true;
            lb_From.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_From.Location = new Point(13, 42);
            lb_From.Name = "lb_From";
            lb_From.Size = new Size(93, 37);
            lb_From.TabIndex = 0;
            lb_From.Text = "From";
            // 
            // txt_From
            // 
            txt_From.Enabled = false;
            txt_From.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_From.Location = new Point(226, 39);
            txt_From.Margin = new Padding(3, 4, 3, 4);
            txt_From.Name = "txt_From";
            txt_From.Size = new Size(990, 44);
            txt_From.TabIndex = 1;
            // 
            // Check_HTML
            // 
            Check_HTML.AutoSize = true;
            Check_HTML.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Check_HTML.Location = new Point(226, 289);
            Check_HTML.Margin = new Padding(3, 4, 3, 4);
            Check_HTML.Name = "Check_HTML";
            Check_HTML.Size = new Size(130, 41);
            Check_HTML.TabIndex = 2;
            Check_HTML.Text = "HTML";
            Check_HTML.UseVisualStyleBackColor = true;
            // 
            // txt_Mail_Content
            // 
            txt_Mail_Content.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Mail_Content.Location = new Point(21, 355);
            txt_Mail_Content.Margin = new Padding(3, 4, 3, 4);
            txt_Mail_Content.Name = "txt_Mail_Content";
            txt_Mail_Content.Size = new Size(1194, 519);
            txt_Mail_Content.TabIndex = 3;
            txt_Mail_Content.Text = "<h1>Học Lập Trình Mạng Thật Vui<h1>\n<h2>Hãy Học Lập Trình Mạng<h2>";
            // 
            // btn_Browse
            // 
            btn_Browse.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Browse.Location = new Point(1017, 916);
            btn_Browse.Margin = new Padding(3, 4, 3, 4);
            btn_Browse.Name = "btn_Browse";
            btn_Browse.Size = new Size(199, 62);
            btn_Browse.TabIndex = 4;
            btn_Browse.Text = "Browse";
            btn_Browse.UseVisualStyleBackColor = true;
            btn_Browse.Click += btn_Browse_Click;
            // 
            // txt_Subject
            // 
            txt_Subject.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Subject.Location = new Point(226, 226);
            txt_Subject.Margin = new Padding(3, 4, 3, 4);
            txt_Subject.Name = "txt_Subject";
            txt_Subject.Size = new Size(990, 44);
            txt_Subject.TabIndex = 6;
            txt_Subject.Text = "Test";
            // 
            // lb_Subject
            // 
            lb_Subject.AutoSize = true;
            lb_Subject.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Subject.Location = new Point(13, 230);
            lb_Subject.Name = "lb_Subject";
            lb_Subject.Size = new Size(123, 37);
            lb_Subject.TabIndex = 5;
            lb_Subject.Text = "Subject";
            // 
            // txt_To
            // 
            txt_To.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_To.Location = new Point(226, 164);
            txt_To.Margin = new Padding(3, 4, 3, 4);
            txt_To.Name = "txt_To";
            txt_To.Size = new Size(990, 44);
            txt_To.TabIndex = 8;
            txt_To.Text = "quanpham0405@gmail.com";
            // 
            // lb_To
            // 
            lb_To.AutoSize = true;
            lb_To.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_To.Location = new Point(13, 168);
            lb_To.Name = "lb_To";
            lb_To.Size = new Size(55, 37);
            lb_To.TabIndex = 7;
            lb_To.Text = "To";
            // 
            // txt_Name
            // 
            txt_Name.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Name.Location = new Point(226, 101);
            txt_Name.Margin = new Padding(3, 4, 3, 4);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(990, 44);
            txt_Name.TabIndex = 10;
            txt_Name.Text = "Quan";
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Name.Location = new Point(13, 105);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(103, 37);
            lb_Name.TabIndex = 9;
            lb_Name.Text = "Name";
            // 
            // lb_Body
            // 
            lb_Body.AutoSize = true;
            lb_Body.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Body.Location = new Point(13, 294);
            lb_Body.Name = "lb_Body";
            lb_Body.Size = new Size(89, 37);
            lb_Body.TabIndex = 11;
            lb_Body.Text = "Body";
            // 
            // txt_Attachment
            // 
            txt_Attachment.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Attachment.Location = new Point(226, 921);
            txt_Attachment.Margin = new Padding(3, 4, 3, 4);
            txt_Attachment.Name = "txt_Attachment";
            txt_Attachment.Size = new Size(784, 44);
            txt_Attachment.TabIndex = 13;
            // 
            // lb_Attachment
            // 
            lb_Attachment.AutoSize = true;
            lb_Attachment.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Attachment.Location = new Point(13, 925);
            lb_Attachment.Name = "lb_Attachment";
            lb_Attachment.Size = new Size(180, 37);
            lb_Attachment.TabIndex = 12;
            lb_Attachment.Text = "Attachment";
            // 
            // btn_Send
            // 
            btn_Send.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Send.Location = new Point(460, 1004);
            btn_Send.Margin = new Padding(3, 4, 3, 4);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(261, 148);
            btn_Send.TabIndex = 14;
            btn_Send.Text = "Send Mail";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // File_URL
            // 
            File_URL.FileName = "openFileDialog1";
            // 
            // Ex6_SendMail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 1166);
            Controls.Add(btn_Send);
            Controls.Add(txt_Attachment);
            Controls.Add(lb_Attachment);
            Controls.Add(lb_Body);
            Controls.Add(txt_Name);
            Controls.Add(lb_Name);
            Controls.Add(txt_To);
            Controls.Add(lb_To);
            Controls.Add(txt_Subject);
            Controls.Add(lb_Subject);
            Controls.Add(btn_Browse);
            Controls.Add(txt_Mail_Content);
            Controls.Add(Check_HTML);
            Controls.Add(txt_From);
            Controls.Add(lb_From);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ex6_SendMail";
            Text = "Send Mail";
            Load += Send_Mail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lb_From;
        private System.Windows.Forms.TextBox txt_From;
        private System.Windows.Forms.CheckBox Check_HTML;
        private System.Windows.Forms.RichTextBox txt_Mail_Content;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label lb_Subject;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.Label lb_To;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Body;
        private System.Windows.Forms.TextBox txt_Attachment;
        private System.Windows.Forms.Label lb_Attachment;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.OpenFileDialog File_URL;
    }
}