namespace NearbyPlaces
{
    partial class frmViewMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvitemList = new System.Windows.Forms.ListView();
            this.chItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chItemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPicturePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvitemList
            // 
            this.lvitemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chItemID,
            this.chItemName,
            this.chItemPrice,
            this.chCategoryName,
            this.chPicturePath});
            this.lvitemList.GridLines = true;
            this.lvitemList.Location = new System.Drawing.Point(21, 12);
            this.lvitemList.Name = "lvitemList";
            this.lvitemList.Size = new System.Drawing.Size(809, 243);
            this.lvitemList.TabIndex = 0;
            this.lvitemList.UseCompatibleStateImageBehavior = false;
            this.lvitemList.View = System.Windows.Forms.View.Details;
            // 
            // chItemID
            // 
            this.chItemID.Text = "Item ID";
            // 
            // chItemName
            // 
            this.chItemName.Text = "Item Name";
            this.chItemName.Width = 120;
            // 
            // chItemPrice
            // 
            this.chItemPrice.Text = "Item Price";
            this.chItemPrice.Width = 120;
            // 
            // chPicturePath
            // 
            this.chPicturePath.Text = "Picture Path";
            this.chPicturePath.Width = 384;
            // 
            // chCategoryName
            // 
            this.chCategoryName.Text = "Category";
            this.chCategoryName.Width = 120;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(21, 261);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(146, 37);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(173, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmViewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 311);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lvitemList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewMenu";
            this.Text = "frmViewMenu";
            this.Load += new System.EventHandler(this.frmViewMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvitemList;
        private System.Windows.Forms.ColumnHeader chItemID;
        private System.Windows.Forms.ColumnHeader chItemName;
        private System.Windows.Forms.ColumnHeader chItemPrice;
        private System.Windows.Forms.ColumnHeader chPicturePath;
        private System.Windows.Forms.ColumnHeader chCategoryName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCancel;
    }
}