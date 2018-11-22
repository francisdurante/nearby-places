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
    public partial class frmUpdateComment : Form
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
        public frmUpdateComment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ApiClass.updateCommentStatus(GlobalVO.getCommentID(), cbCommentStatus.Text == "POST" ? "pass" : cbCommentStatus.Text == "REJECT" ? "reject" : "pending" );
            reOpenCommentListForm();
        }

        private void reOpenCommentListForm()
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Form f = Application.OpenForms["frmCommentList"];
            if (f == null)
            {
                frmCommentList fec = new frmCommentList();
                fec.MdiParent = this.MdiParent;
                fec.Show();
            }
            else
            {
                MessageBox.Show("Comment List Form is Already Open.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reOpenCommentListForm();
        }

        private void frmUpdateComment_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            string[,] data = ApiClass.getCommentByID(GlobalVO.getCommentID());
            txtComment.Text = data[0, 0].ToString();
            cbCommentStatus.Text = data[0,1].ToString() == "PENDING" ? "PENDING" : data[0, 1].ToString() == "REJECTED" ?  "REJECT" : "POST"; 
        }
    }
}
