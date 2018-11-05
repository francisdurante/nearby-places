using NearbyPlaces.ForEstablishmentLogin;
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
    public partial class frmAddCategory : Form
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
        public frmAddCategory()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text != "" && ApiClass.est_add_category(txtCategory.Text,ForLoginEstVO.getEstUserID()))
            {
                MessageBox.Show("Category Add Successful!", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmAddCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
