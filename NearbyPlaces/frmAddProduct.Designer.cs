namespace NearbyPlaces
{
    partial class frmAddProduct
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbProductDetails = new System.Windows.Forms.GroupBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.gbImageThumbnail = new System.Windows.Forms.GroupBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pbMenuPic = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbProductDetails.SuspendLayout();
            this.gbImageThumbnail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 29);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(110, 15);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name : ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 55);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 15);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price : ";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 82);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(75, 15);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category : ";
            // 
            // gbProductDetails
            // 
            this.gbProductDetails.BackColor = System.Drawing.Color.Transparent;
            this.gbProductDetails.Controls.Add(this.cbCategory);
            this.gbProductDetails.Controls.Add(this.txtPrice);
            this.gbProductDetails.Controls.Add(this.txtProductName);
            this.gbProductDetails.Controls.Add(this.lblProductName);
            this.gbProductDetails.Controls.Add(this.lblCategory);
            this.gbProductDetails.Controls.Add(this.lblPrice);
            this.gbProductDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductDetails.ForeColor = System.Drawing.Color.White;
            this.gbProductDetails.Location = new System.Drawing.Point(12, 12);
            this.gbProductDetails.Name = "gbProductDetails";
            this.gbProductDetails.Size = new System.Drawing.Size(308, 142);
            this.gbProductDetails.TabIndex = 3;
            this.gbProductDetails.TabStop = false;
            this.gbProductDetails.Text = "Product Details";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(122, 79);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(170, 23);
            this.cbCategory.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(122, 52);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(170, 21);
            this.txtPrice.TabIndex = 4;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(122, 26);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(170, 21);
            this.txtProductName.TabIndex = 3;
            // 
            // gbImageThumbnail
            // 
            this.gbImageThumbnail.BackColor = System.Drawing.Color.Transparent;
            this.gbImageThumbnail.Controls.Add(this.txtFilePath);
            this.gbImageThumbnail.Controls.Add(this.btnUpload);
            this.gbImageThumbnail.Controls.Add(this.pbMenuPic);
            this.gbImageThumbnail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbImageThumbnail.ForeColor = System.Drawing.Color.White;
            this.gbImageThumbnail.Location = new System.Drawing.Point(326, 12);
            this.gbImageThumbnail.Name = "gbImageThumbnail";
            this.gbImageThumbnail.Size = new System.Drawing.Size(339, 142);
            this.gbImageThumbnail.TabIndex = 6;
            this.gbImageThumbnail.TabStop = false;
            this.gbImageThumbnail.Text = "Image Thumbnail";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(130, 115);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(203, 21);
            this.txtFilePath.TabIndex = 2;
            // 
            // btnUpload
            // 
            this.btnUpload.ForeColor = System.Drawing.Color.Black;
            this.btnUpload.Location = new System.Drawing.Point(6, 112);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(118, 23);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "BROWSE";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pbMenuPic
            // 
            this.pbMenuPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMenuPic.Location = new System.Drawing.Point(6, 19);
            this.pbMenuPic.Name = "pbMenuPic";
            this.pbMenuPic.Size = new System.Drawing.Size(165, 88);
            this.pbMenuPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenuPic.TabIndex = 0;
            this.pbMenuPic.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 160);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(171, 51);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 51);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::NearbyPlaces.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 234);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbImageThumbnail);
            this.Controls.Add(this.gbProductDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.gbProductDetails.ResumeLayout(false);
            this.gbProductDetails.PerformLayout();
            this.gbImageThumbnail.ResumeLayout(false);
            this.gbImageThumbnail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbProductDetails;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.GroupBox gbImageThumbnail;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pbMenuPic;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}