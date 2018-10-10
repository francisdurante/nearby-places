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
            category = ApiClass.getCategory(ForLoginEstVO.getEstID());
            for(int x = 0; x < category.Count; x++)
            {
                cbCategory.Items.Add(category[x]);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
               // pbMenuPic.Image = new Bitmap(open.FileName);
                fileInfo = new FileInfo(open.FileName);
                // image file path  
                txtFilePath.Text = open.FileName;
                
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(fileInfo + "");
           if(ApiClass.addProduct(txtProductName.Text, txtPrice.Text,txtFilePath.Text,cbCategory.Text))
            {
                MessageBox.Show("success");
            }
        }
    }
}
