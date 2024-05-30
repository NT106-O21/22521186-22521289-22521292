namespace Lab05
{
    partial class Ex5_ChosenFood
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
            btnInvite = new Button();
            SuspendLayout();
            // 
            // foodView1
            // 
            foodView1.Location = new Point(12, 12);
            foodView1.Name = "foodView1";
            foodView1.Size = new Size(600, 156);
            foodView1.TabIndex = 0;
            // 
            // btnInvite
            // 
            btnInvite.BackColor = SystemColors.ActiveCaption;
            btnInvite.Location = new Point(505, 184);
            btnInvite.Name = "btnInvite";
            btnInvite.Size = new Size(111, 29);
            btnInvite.TabIndex = 1;
            btnInvite.Text = "Mời bạn bè...";
            btnInvite.UseVisualStyleBackColor = false;
            btnInvite.Click += btnInvite_Click;
            // 
            // _7_ChosenFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(628, 225);
            Controls.Add(btnInvite);
            Controls.Add(foodView1);
            Name = "_7_ChosenFood";
            Text = "_7_ChoosenFood";
            ResumeLayout(false);
        }

        #endregion

        private FoodView foodView1;
        private Button btnInvite;
    }
}