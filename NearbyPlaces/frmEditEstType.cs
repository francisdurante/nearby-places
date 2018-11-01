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
    public partial class frmEditEstType : Form
    {
        public frmEditEstType()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int status = 0;
            if(cbStatus.Text == "ACTIVE")
            {
                status = 1;
            }
            if(ApiClass.submit_edited_est_type(txtCurrentEstName.Text, status, forEstablishmentType.ForEstablishmentTypeVO.getEstTypeID())){
                MessageBox.Show("Success", "Edit Establishment Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmEditEstType_Load(object sender, EventArgs e)
        {
            ArrayList type = new ArrayList();
            type = ApiClass.get_est_type("all", "");
            for (int x = 0; x < type.Count; x++)
            {
                cbEstName.Items.Add(type[x]);
            }
        }

        private void cbEstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCurrentEstName.Text = cbEstName.Text;
            ApiClass.get_est_type("specific", txtCurrentEstName.Text);
            if(forEstablishmentType.ForEstablishmentTypeVO.getStatus() == 1)
            {
                cbStatus.Text = "ACTIVE";
            }
            else
            {
                cbStatus.Text = "INACTIVE";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
