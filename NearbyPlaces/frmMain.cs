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
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tsLoggedIn.Text = "Establishment ID: " + ForEstablishmentLogin.ForLoginEstVO.getEstID();
            tsEstName.Text = "Establishment Name : " + ForEstablishmentLogin.ForLoginEstVO.getEstName();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                Environment.Exit(1);
                Process.GetCurrentProcess().Kill();
            }
            else
            {

            }
        }
    }
}
