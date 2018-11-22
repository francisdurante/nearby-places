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
    public partial class frmCommentList : Form
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
        public frmCommentList()
        {
            InitializeComponent();
        }

        private void frmCommentList_Load(object sender, EventArgs e)
        {
            retrieveData("", "");
        }

        public void retrieveData(string est_filter, string user_filter)
        {
            string[,] data = ApiClass.getAllComment(est_filter, user_filter);
            lvCommentList.Items.Clear();
            for (int x = 0; x < data.Length / 7; x++)
            {
                int i = 0;
                ListViewItem lv = new ListViewItem(data[x, i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lvCommentList.Items.Add(lv);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string user = "";
            string est = "";
            if(cbFilter.SelectedIndex == 0)
            {
                est = txtSearchKey.Text;
            }
            else if(cbFilter.SelectedIndex == 1)
            {
                user = txtSearchKey.Text;
            }
            retrieveData(est, user);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            retrieveData("", "");
        }

        private void lvCommentList_DoubleClick(object sender, EventArgs e)
        {
            if (lvCommentList.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lvCommentList.SelectedItems;

                ListViewItem lvItem = lvCommentList.SelectedItems[0];
                int ID = Convert.ToInt32(lvItem.Text);
                GlobalVO.setCommentID(ID);
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();

                Form f = Application.OpenForms["frmUpdateComment"];
                if (f == null)
                {
                    frmUpdateComment fad = new frmUpdateComment();
                    fad.MdiParent = this.MdiParent;
                    fad.Show();
                }
                else
                {
                    MessageBox.Show("Update Comment Form is Already Open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
            }

        }
    }
}
