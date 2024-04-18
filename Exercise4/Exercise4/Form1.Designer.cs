namespace Exercise4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnReceiption1 = new Button();
            btnServer = new Button();
            SuspendLayout();
            // 
            // btnReceiption1
            // 
            btnReceiption1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReceiption1.Location = new Point(12, 12);
            btnReceiption1.Name = "btnReceiption1";
            btnReceiption1.Size = new Size(116, 40);
            btnReceiption1.TabIndex = 0;
            btnReceiption1.Text = "Quầy";
            btnReceiption1.UseVisualStyleBackColor = true;
            btnReceiption1.Click += btnReceiption1_Click;
            // 
            // btnServer
            // 
            btnServer.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServer.Location = new Point(262, 12);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(116, 40);
            btnServer.TabIndex = 3;
            btnServer.Text = "Server";
            btnServer.UseVisualStyleBackColor = true;
            btnServer.Click += btnServer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 76);
            Controls.Add(btnServer);
            Controls.Add(btnReceiption1);
            Name = "Form1";
            Text = "Danh sách quầy vé";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReceiption1;
        private Button btnServer;
    }
}
