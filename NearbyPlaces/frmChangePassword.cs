using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NearbyPlaces
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtConfirmPass.Text == "" || txtCurrentPass.Text == "" || txtNewPass.Text == "")
            {
                MessageBox.Show("Please Complete Information Needed", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("New Password not Match with Confirm Password", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (ApiClass.changePass(txtCurrentPass.Text, txtNewPass.Text, ForEstablishmentLogin.ForLoginEstVO.getEstUserID().ToString()))
                {
                    MessageBox.Show("Password Changed!", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
