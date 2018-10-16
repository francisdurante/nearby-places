using System;
using System.Collections;
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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gbEstablishmentDetails_Enter(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" ||
                txtPassword.Text != "" ||
                txtRePassword.Text != "" ||
                txtSecurity.Text != "" ||
                txtEstablishmentName.Text != "" ||
                txtLat.Text != "" ||
                txtLon.Text != "" ||
                cbEmotion.Text != "" && cbEmotion.Text != "----SELECT THE BEST ONE----" ||
                cbAge.Text != "" && cbAge.Text != "----SELECT THE BEST ONE----")
            {
                if (txtPassword.Text == txtRePassword.Text)
                {
                    if (ApiClass.establishment_registration(txtUsername.Text, txtPassword.Text, txtEstablishmentName.Text, txtLat.Text, txtLon.Text, cbEmotion.Text, cbAge.Text, txtSecurity.Text,forEstablishmentType.ForEstablishmentTypeVO.getEstTypeID()))
                    {
                        MessageBox.Show("Registration Success", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registration Fail", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password and Re-Password Not Match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Complete Information Needed Or;\nSelect Specific Item needed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            ArrayList type = new ArrayList();
            type = ApiClass.get_est_type("active", "");
            for(int x = 0; x < type.Count; x++)
            {
                cbEstType.Items.Add(type[x]);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbEstType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApiClass.get_est_type("specific", cbEstType.Text);
        }
    }
}
