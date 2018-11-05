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
    public partial class frmEstSettings : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        string[,] data;
        string oldPath;
        public frmEstSettings()
        {
            InitializeComponent();
        }

        private void lblEstType_Click(object sender, EventArgs e)
        {

        }

        private void cbEstType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmEstSettings_Load(object sender, EventArgs e)
        {
            retrieveEstType();
            retrieveData(ForEstablishmentLogin.ForLoginEstVO.establishment_name,"");
        }

        public void retrieveData(string key, string filter)
        {
            data = ApiClass.get_all_est_user(key, filter);
            txtEstName.Text = data[0, 2];
            txtAddress.Text = data[0, 11];
            txtLatitude.Text = data[0, 4];
            txtLongitude.Text = data[0, 5];
            cbEmotion.Text = data[0, 6];
            cbAge.Text = data[0, 7];
            cbEstType.Text = data[0, 3];
            pbFrontStore.Load(data[0, 8]);
            txtUserName.Text = data[0, 1];
            oldPath = data[0, 8];
        }
        public void retrieveEstType()
        {
            ArrayList type = new ArrayList();
            type = ApiClass.get_est_type("active", "");
            for (int x = 0; x < type.Count; x++)
            {
                cbEstType.Items.Add(type[x]);
            }
        }
        public bool isPassValidation()
        {
            if(data[0,2] == txtEstName.Text &&
                data[0,11] == txtAddress.Text &&
                data[0,4] == txtLatitude.Text &&
                data[0,5] == txtLongitude.Text &&
                data[0,6] == cbEmotion.Text &&
                data[0,7] == cbAge.Text &&
                data[0,3] == cbEstType.Text &&
                data[0,8] == oldPath)
            {
                MessageBox.Show("Nothing is change!", "Establishment Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isPassValidation())
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to apply changes?", "Establishment Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    string path = "";
                    if(oldPath != data[0, 8])
                    {
                        path = oldPath;
                    }
                    if (ApiClass.submit_edit_est_setting(ForEstablishmentLogin.ForLoginEstVO.getEstID().ToString(),txtEstName.Text, txtAddress.Text, txtLatitude.Text, txtLongitude.Text, cbEmotion.Text, cbAge.Text, cbEstType.Text, path))
                    {
                        MessageBox.Show("Changes Applied!", "Establishment Setting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Change not Applied", "Establishment Setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnChangePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbFrontStore.ImageLocation = dlg.FileName;
                oldPath = dlg.FileName;
            }
            dlg.Dispose();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmChangePassword"];
            if (f == null)
            {
                frmChangePassword fac = new frmChangePassword();
                fac.MdiParent = MdiParent;
                fac.Show();
            }
            else
            {
                MessageBox.Show("Add Category Form is Already Open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
