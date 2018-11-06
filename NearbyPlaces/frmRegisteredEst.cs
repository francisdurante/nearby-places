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
    public partial class frmRegisteredEst : Form
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
        public frmRegisteredEst()
        {
            InitializeComponent();
        }

        private void frmRegisteredEst_Load(object sender, EventArgs e)
        {
            retrieveData("",cbCategory.Text);
            retrieveFilter();
        }

        public void retrieveData(string key,string filter)
        {
            string[,] data = ApiClass.get_all_est_user(key,filter);
            lvEst.Items.Clear();
            for (int x = 0; x < data.Length/12; x++)
            {
                int i = 0;
                ListViewItem lv = new ListViewItem(data[x,i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lvEst.Items.Add(lv);
            }
        }
        public void retrieveFilter()
        {
            ArrayList estType = new ArrayList();
            estType = ApiClass.get_est_type("all","");
            cbCategory.Items.Add("");
            for(int x = 0; x < estType.Count; x++)
            {
                cbCategory.Items.Add(estType[x]);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtKey.Text = "";
            cbCategory.Text = "";
            retrieveData("","");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            retrieveData(txtKey.Text,cbCategory.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
