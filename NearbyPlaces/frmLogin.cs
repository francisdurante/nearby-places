using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Collections;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace NearbyPlaces
{
    public partial class frmLoginForm : Form
    {
        public frmLoginForm()
        {
            InitializeComponent();
        }


        private void btnTestApi_Click(object sender, EventArgs e)
        {
            if (ApiClass.establisment_login(txtUsername.Text, txtPassword.Text))
            {
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
   
}
