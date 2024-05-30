namespace Lab05
{
    partial class Ex5_InviteForm
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
            foodView1 = new FoodView();
            label1 = new Label();
            txtEmail = new TextBox();
            btnAdd = new Button();
            listBox1 = new ListBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // foodView1
            // 
            foodView1.BackColor = SystemColors.ButtonFace;
            foodView1.Location = new Point(12, 12);
            foodView1.Name = "foodView1";
            foodView1.Size = new Size(600, 156);
            foodView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 179);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(77, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(435, 27);
            txtEmail.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 128, 0);
            btnAdd.Location = new Point(518, 179);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 213);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(611, 184);
            listBox1.TabIndex = 4;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(255, 128, 0);
            btnSend.Location = new Point(529, 403);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // Ex5_InviteForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(635, 444);
            Controls.Add(btnSend);
            Controls.Add(listBox1);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(foodView1);
            Name = "Ex5_InviteForm";
            Text = "Invite";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FoodView foodView1;
        private Label label1;
        private TextBox txtEmail;
        private Button btnAdd;
        private ListBox listBox1;
        private Button btnSend;
    }
}