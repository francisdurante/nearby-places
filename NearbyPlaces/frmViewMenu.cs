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
    public partial class frmViewMenu : Form
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
        public frmViewMenu()
        {
            InitializeComponent();
        }

        private void frmViewMenu_Load(object sender, EventArgs e)
        {
            retrieveData();
        }

        private void retrieveData()
        {
            string[,] data = ApiClass.getProductOfEstablishment(ForEstablishmentLogin.ForLoginEstVO.getEstUserID().ToString());
            lvitemList.Items.Clear();
            for (int x = 0; x < data.Length / 5; x++)
            {
                int i = 0;
                ListViewItem lv = new ListViewItem(data[x, i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lvitemList.Items.Add(lv);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            retrieveData();
        }
    }
}
