using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NearbyPlaces
{
    public partial class frmMain : Form
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
        public frmMain()
        {
            InitializeComponent();
            frmEstSettings.mainStatusStrip = this;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tsLoggedIn.Text = "Establishment ID: " + ForEstablishmentLogin.ForLoginEstVO.getEstID();
            tsEstName.Text = "Establishment Name : " + ForEstablishmentLogin.ForLoginEstVO.getEstName();
            userName.Text = " User name : " + ForEstablishmentLogin.ForLoginEstVO.getUser();
            if(ForEstablishmentLogin.ForLoginEstVO.getUser() == "SUPERADMIN")
            {
                registrationTab.Visible = true;
                establishmentTypeToolStripMenuItem.Visible = true;
                showAllEst.Visible = true;
                addProductOnMenuToolStripMenuItem.Visible = false;
                categoryMenuToolStripMenuItem.Visible = false;
                accountSettingsToolStripMenuItem.Visible = false;
            }
            else
            {
                registrationTab.Visible = false;
                establishmentTypeToolStripMenuItem.Visible = false;
                showAllEst.Visible = false;
                addProductOnMenuToolStripMenuItem.Visible = true;
                categoryMenuToolStripMenuItem.Visible = true;
            }
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Form f = Application.OpenForms["frmAddCategory"];
            if (f == null)
            {
                frmAddCategory fac = new frmAddCategory();
                fac.MdiParent = this;
                fac.Show();
            }
            else
            {
                MessageBox.Show("Add Category Form is Already Open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addProductOnMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Form f = Application.OpenForms["frmAddProduct"];
            if (f == null)
            {
                frmAddProduct fad = new frmAddProduct();
                fad.MdiParent = this;
                fad.Show();
            }
            else
            {
                MessageBox.Show("Add Product Form is Already Open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Form f = Application.OpenForms["frmEditCategory"];
            if (f == null)
            {
                frmEditCategory fec = new frmEditCategory();
                fec.MdiParent = this;
                fec.Show();
            }
            else
            {
                MessageBox.Show("Edit Category Form is Already Open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Form f = Application.OpenForms["frmEditProduct"];
            if (f == null)
            {
                frmEditProduct fep = new frmEditProduct();
                fep.MdiParent = this;
                fep.Show();
            }
            else
            {
                MessageBox.Show("Edit Product Form is Already Open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
                frmLoginForm flf = new frmLoginForm();
                flf.Show();
            }
        }

        private void addTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Form f = Application.OpenForms["frmAddEstType"];
            if (f == null)
            {
                frmAddEstType fep = new frmAddEstType();
                fep.MdiParent = this;
                fep.Show();
            }
            else
            {
                MessageBox.Show("Add Establishment Type Form is Already Open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Form f = Application.OpenForms["frmEditEstType"];
            if (f == null)
            {
                frmEditEstType fep = new frmEditEstType();
                fep.MdiParent = this;
                fep.Show();
            }
            else
            {
                MessageBox.Show("Edit Establishment Type Form is Already Open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void registrationTab_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Form f = Application.OpenForms["frmRegistration"];
            if (f == null)
            {
                frmRegistration fep = new frmRegistration();
                fep.MdiParent = this;
                fep.Show();
            }
            else
            {
                MessageBox.Show("Registration Form is Already Open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void showAllEst_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Form f = Application.OpenForms["frmRegisteredEst"];
            if (f == null)
            {
                frmRegisteredEst fep = new frmRegisteredEst();
                fep.MdiParent = this;
                fep.Show();
            }
            else
            {
                MessageBox.Show("Registered Establishment Form is Already Open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void establishmentSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Form f = Application.OpenForms["frmAbout"];
            if (f == null)
            {
                frmAbout fes = new frmAbout();
                fes.MdiParent = this;
                fes.Show();
            }
            else
            {
                MessageBox.Show("About Form is Already Open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Form f = Application.OpenForms["frmEstSettings"];
            if (f == null)
            {
                frmEstSettings fes = new frmEstSettings();
                fes.MdiParent = this;
                fes.Show();
            }
            else
            {
                MessageBox.Show("Establishment Settings Form is Already Open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
