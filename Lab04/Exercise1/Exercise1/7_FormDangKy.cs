using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class _7_FormDangKy : Form
    {
        public _7_FormDangKy()
        {
            InitializeComponent();
        }

        public class postData
        {
            public string username { get; set; }
            public string password { get; set; }
            public postData() { }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            postData postdata = new postData
            {
                username = name.Text,
                password = pass.Text
            };

        }

    }
}
