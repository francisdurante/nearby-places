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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.gbImageThumbnail = new System.Windows.Forms.GroupBox();
            this.gbProductDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 29);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(84, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name : ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 55);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price : ";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 82);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category : ";
            // 
            // gbProductDetails
            // 
            this.gbProductDetails.Controls.Add(this.cbCategory);
            this.gbProductDetails.Controls.Add(this.txtPrice);
            this.gbProductDetails.Controls.Add(this.txtProductName);
            this.gbProductDetails.Controls.Add(this.lblProductName);
            this.gbProductDetails.Controls.Add(this.lblCategory);
            this.gbProductDetails.Controls.Add(this.lblPrice);
            this.gbProductDetails.Location = new System.Drawing.Point(12, 12);
            this.gbProductDetails.Name = "gbProductDetails";
            this.gbProductDetails.Size = new System.Drawing.Size(273, 142);
            this.gbProductDetails.TabIndex = 3;
            this.gbProductDetails.TabStop = false;
            this.gbProductDetails.Text = "Product Details";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(97, 26);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(170, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(97, 52);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(170, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(97, 79);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(170, 21);
            this.cbCategory.TabIndex = 5;
            // 
            // gbImageThumbnail
            // 
            this.gbImageThumbnail.Location = new System.Drawing.Point(291, 12);
            this.gbImageThumbnail.Name = "gbImageThumbnail";
            this.gbImageThumbnail.Size = new System.Drawing.Size(273, 142);
            this.gbImageThumbnail.TabIndex = 6;
            this.gbImageThumbnail.TabStop = false;
            this.gbImageThumbnail.Text = "Image Thumbnail";
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 262);
            this.Controls.Add(this.gbImageThumbnail);
            this.Controls.Add(this.gbProductDetails);
            this.Name = "frmAddProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.gbProductDetails.ResumeLayout(false);
            this.gbProductDetails.PerformLayout();
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
    }
}