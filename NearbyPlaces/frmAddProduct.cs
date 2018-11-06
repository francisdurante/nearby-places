using NearbyPlaces.ForEstablishmentLogin;
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
    public partial class frmAddProduct : Form
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
        public static FileInfo fileInfo;
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            fillCategory();
        }

        private void fillCategory()
        {
            cbCategory.Items.Clear();
            cbCategory.Items.Add("");
            ArrayList category = new ArrayList();
            category = ApiClass.getCategory(ForLoginEstVO.getEstUserID(),"all_active");
            for(int x = 0; x < category.Count; x++)
            {
                cbCategory.Items.Add(category[x]);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbMenuPic.ImageLocation = dlg.FileName;
                txtFilePath.Text = dlg.FileName;
            }
            dlg.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(fileInfo + "");
           if(ApiClass.addProduct(txtProductName.Text, txtPrice.Text,txtFilePath.Text,cbCategory.Text))
            {
                MessageBox.Show("success");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
