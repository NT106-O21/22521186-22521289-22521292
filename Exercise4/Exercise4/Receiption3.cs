using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Receiption3 : Form
    {
        public Receiption3()
        {
            InitializeComponent();
        }

        private void Rct3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new Point(42 + (50 * i), 97);
                checkBox.Name = "A" + (i + 1).ToString();
                checkBox.Size = new Size(49, 24);
                checkBox.TabIndex = 4;
                checkBox.Text = "A" + (i + 1).ToString();
                checkBox.UseVisualStyleBackColor = true;
                checkBox.CheckStateChanged += checkBox_CheckedChanged;
                this.Controls.Add(checkBox);
            }
            for (int i = 0; i < 5; i++)
            {
                System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new Point(42 + (50 * i), 125);
                checkBox.Name = "B" + (i + 1).ToString();
                checkBox.Size = new Size(49, 24);
                checkBox.TabIndex = 4;
                checkBox.Text = "B" + (i + 1).ToString();
                checkBox.UseVisualStyleBackColor = true;
                checkBox.CheckStateChanged += checkBox_CheckedChanged;
                this.Controls.Add(checkBox);
            }
            for (int i = 0; i < 5; i++)
            {
                System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new Point(42 + (50 * i), 150);
                checkBox.Name = "C" + (i + 1).ToString();
                checkBox.Size = new Size(49, 24);
                checkBox.TabIndex = 4;
                checkBox.Text = "C" + (i + 1).ToString();
                checkBox.UseVisualStyleBackColor = true;
                checkBox.CheckStateChanged += checkBox_CheckedChanged;
                this.Controls.Add(checkBox);
            }
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            txtCheckedBox.Text = "";
            CheckBox chkBox = new CheckBox();
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    chkBox = (CheckBox)c;
                    if (chkBox.Checked == true)
                    {
                        txtCheckedBox.Text += chkBox.Text + "; ";
                    }
                }
            }
        }
    }
}
