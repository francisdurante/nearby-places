using NearbyPlaces.ForEstablishmentLogin;
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
    public partial class frmAddProduct : Form
    {
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
    }
}
