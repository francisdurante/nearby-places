namespace NearbyPlaces
{
    partial class frmMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLoggedIn = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsEstName = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.establishmentSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductOnMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLoggedIn,
            this.tsEstName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(860, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsLoggedIn
            // 
            this.tsLoggedIn.Name = "tsLoggedIn";
            this.tsLoggedIn.Size = new System.Drawing.Size(60, 17);
            this.tsLoggedIn.Text = "LoggedIn:";
            this.tsLoggedIn.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tsEstName
            // 
            this.tsEstName.Name = "tsEstName";
            this.tsEstName.Size = new System.Drawing.Size(125, 17);
            this.tsEstName.Text = "Establishment Name : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.establishmentSystemToolStripMenuItem,
            this.aboutSystemToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // establishmentSystemToolStripMenuItem
            // 
            this.establishmentSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductOnMenuToolStripMenuItem,
            this.categoryMenuToolStripMenuItem});
            this.establishmentSystemToolStripMenuItem.Name = "establishmentSystemToolStripMenuItem";
            this.establishmentSystemToolStripMenuItem.Size = new System.Drawing.Size(165, 20);
            this.establishmentSystemToolStripMenuItem.Text = "Establishment Maintenance";
            // 
            // addProductOnMenuToolStripMenuItem
            // 
            this.addProductOnMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.editProductToolStripMenuItem});
            this.addProductOnMenuToolStripMenuItem.Name = "addProductOnMenuToolStripMenuItem";
            this.addProductOnMenuToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addProductOnMenuToolStripMenuItem.Text = "Product Menu";
            this.addProductOnMenuToolStripMenuItem.Click += new System.EventHandler(this.addProductOnMenuToolStripMenuItem_Click);
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // editProductToolStripMenuItem
            // 
            this.editProductToolStripMenuItem.Name = "editProductToolStripMenuItem";
            this.editProductToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.editProductToolStripMenuItem.Text = "Edit Product";
            this.editProductToolStripMenuItem.Click += new System.EventHandler(this.editProductToolStripMenuItem_Click);
            // 
            // categoryMenuToolStripMenuItem
            // 
            this.categoryMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategoryToolStripMenuItem,
            this.editCategoryToolStripMenuItem});
            this.categoryMenuToolStripMenuItem.Name = "categoryMenuToolStripMenuItem";
            this.categoryMenuToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.categoryMenuToolStripMenuItem.Text = "Category Menu";
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addCategoryToolStripMenuItem.Text = "Add Category";
            this.addCategoryToolStripMenuItem.Click += new System.EventHandler(this.addCategoryToolStripMenuItem_Click);
            // 
            // editCategoryToolStripMenuItem
            // 
            this.editCategoryToolStripMenuItem.Name = "editCategoryToolStripMenuItem";
            this.editCategoryToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.editCategoryToolStripMenuItem.Text = "Edit Category";
            this.editCategoryToolStripMenuItem.Click += new System.EventHandler(this.editCategoryToolStripMenuItem_Click);
            // 
            // aboutSystemToolStripMenuItem
            // 
            this.aboutSystemToolStripMenuItem.Name = "aboutSystemToolStripMenuItem";
            this.aboutSystemToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.aboutSystemToolStripMenuItem.Text = "About System";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 531);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsLoggedIn;
        private System.Windows.Forms.ToolStripStatusLabel tsEstName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem establishmentSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductOnMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}