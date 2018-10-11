using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NearbyPlaces
{
    public partial class frmEditProduct : Form
    {
        string oldPath = "";
        int upload = 0;
        bool nameChange = false;
        int status = 0;
        public frmEditProduct()
        {
            InitializeComponent();
        }

        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            cbCategory.Enabled = false;
            txtPrice.Enabled = false;
            btnChange.Enabled = false;
            btnSave.Enabled = false;

            ArrayList product = new ArrayList();
            product = ApiClass.getProduct(ForEstablishmentLogin.ForLoginEstVO.getEstID(), "all");
            for (int x = 0; x < product.Count; x++)
            {
                cbItemName.Items.Add(product[x]);
            }
            ArrayList category = new ArrayList();
            category = ApiClass.getCategory(ForEstablishmentLogin.ForLoginEstVO.getEstID(), "all");
            for (int x = 0; x < category.Count; x++)
            {
                cbCategory.Items.Add(category[x]);
            }
        }

        private void cbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbItemName.Text != "")
            {
                cbCategory.Enabled = true;
                txtPrice.Enabled = true;
                btnChange.Enabled = true;
                btnSave.Enabled = true;
                txtItemName.Text = cbItemName.Text;
                ApiClass.editProduct(ForEstablishmentLogin.ForLoginEstVO.getEstID(), cbItemName.Text);
                cbCategory.Text = forEditProduct.forEditProductVO.getCategory();
                txtPrice.Text = forEditProduct.forEditProductVO.getPrice();
                string path = forEditProduct.forEditProductVO.getPath();
                oldPath = path;
                String[] separated = path.Split('/');
                path = separated[6] + "/" + separated[7];
                pbThumbnail.Load("http://darkened-career.000webhostapp.com/" + path);

                if (forEditProduct.forEditProductVO.getStatus() == 1)
                {
                    cbStatus.Text = "ACTIVE";
                }
                else
                {
                    cbStatus.Text = "INACTIVE";
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbThumbnail.ImageLocation = dlg.FileName;
                txtLocalPath.Text = dlg.FileName;
            }
            dlg.Dispose();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == forEditProduct.forEditProductVO.getItemName() &&
                txtPrice.Text == forEditProduct.forEditProductVO.getPrice() &&
                status == forEditProduct.forEditProductVO.getStatus() &&
                oldPath == forEditProduct.forEditProductVO.getPath() &&
                cbCategory.Text == forEditProduct.forEditProductVO.getCategory())
            {
                MessageBox.Show("Nothing to Edit", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtItemName.Text != forEditProduct.forEditProductVO.getItemName() ||
                txtPrice.Text != forEditProduct.forEditProductVO.getPrice() ||
                status != forEditProduct.forEditProductVO.getStatus() ||
                oldPath != forEditProduct.forEditProductVO.getPath() ||
                cbCategory.Text != forEditProduct.forEditProductVO.getCategory())
            {
                if (ApiClass.submit_edited_product(forEditProduct.forEditProductVO.getItemId(),
                    ForEstablishmentLogin.ForLoginEstVO.getEstID()
                    , cbCategory.Text, status,
                    oldPath, txtItemName.Text,
                    txtPrice.Text,
                    upload))
                {
                    MessageBox.Show("Edit Success", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Edit Fail", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else if(txtItemName.Text == forEditProduct.forEditProductVO.getItemName() ||
                txtPrice.Text != forEditProduct.forEditProductVO.getPrice() ||
                status != forEditProduct.forEditProductVO.getStatus() ||
                oldPath != forEditProduct.forEditProductVO.getPath() ||
                cbCategory.Text != forEditProduct.forEditProductVO.getCategory())
            {
                if (ApiClass.submit_edited_product(forEditProduct.forEditProductVO.getItemId(),
                    ForEstablishmentLogin.ForLoginEstVO.getEstID()
                    , cbCategory.Text, status,
                    oldPath, forEditProduct.forEditProductVO.getItemName(),
                    txtPrice.Text,
                    upload))
                {
                    MessageBox.Show("Edit Success", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Edit Fail", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void txtLocalPath_TextChanged(object sender, EventArgs e)
        {
            if(txtLocalPath.Text != "")
            {
                oldPath = txtLocalPath.Text;
                upload = 1;
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbStatus.Text == "ACTIVE")
            {
                status = 1;
            }
            else
            {
                status = 0;
            }
        }
    }
}
