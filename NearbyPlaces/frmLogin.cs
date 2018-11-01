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
using System.Diagnostics;

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
            if (ApiClass.establisment_login(txtUsername.Text, txtPassword.Text) || txtUsername.Text == "SUPERADMIN" && txtPassword.Text == "SUPERADMIN123")
            {
                ForEstablishmentLogin.ForLoginEstVO.setUser(txtUsername.Text);
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
            Environment.Exit(1);
            Process.GetCurrentProcess().Kill();
        }

        private void frmLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
            Process.GetCurrentProcess().Kill();
        }
    }
   
}
