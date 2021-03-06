﻿using NearbyPlaces.ForEstablishmentLogin;
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
    public partial class frmEditCategory : Form
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
        ArrayList category = new ArrayList();
        public frmEditCategory()
        {
            InitializeComponent();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void frmEditCategory_Load(object sender, EventArgs e)
        {
            getMenuCategory();
        }

        private void cbCurrentCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApiClass.editCategory(ForLoginEstVO.getEstUserID(), cbCurrentCategory.Text);
            if (forEditCategory.forEditCategory.getStatus() == 1)
            {
                cbStatus.Text = "ACTIVE";
            }
            else {
                cbStatus.Text = "INACTIVE";
            }
            txtCatName.Text = cbCurrentCategory.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int status = 0;
            bool exist = false;
            if(cbStatus.Text == "ACTIVE")
            {
                status = 1;
            }
            if (cbCurrentCategory.Text.Equals(txtCatName.Text) && status == forEditCategory.forEditCategory.getStatus())
            {
                MessageBox.Show("Nothing to Edit", "Edit Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for(int x = 0; x < category.Count; x++)
                {
                    if (txtCatName.Text.Equals(category[x]))
                    {
                        exist = true;
                    }
                }
                if (exist && status == forEditCategory.forEditCategory.getStatus())
                {
                    MessageBox.Show("Category name Already Exist", "Edit Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(ApiClass.submit_edited_category(forEditCategory.forEditCategory.getCatId(), ForLoginEstVO.getEstID(), txtCatName.Text, status))
                    {
                        MessageBox.Show("Edit Success", "Edit Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getMenuCategory();
                        
                    }
                    else
                    {
                        MessageBox.Show("Fail to Edit", "Edit Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text != "" && ApiClass.est_add_category(txtCategory.Text, ForLoginEstVO.getEstUserID()))
            {
                MessageBox.Show("Category Add Successful!", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getMenuCategory();
                txtCategory.Clear();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void getMenuCategory()
        {
            cbCurrentCategory.Items.Clear();
            category = ApiClass.getCategory(ForLoginEstVO.getEstUserID(), "all");
            category.Sort();
            for (int x = 0; x < category.Count; x++)
            {
                cbCurrentCategory.Items.Add(category[x]);
            }
        }
    }
}
