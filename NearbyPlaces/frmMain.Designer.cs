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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLoggedIn = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsEstName = new System.Windows.Forms.ToolStripStatusLabel();
            this.userName = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.establishmentSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductOnMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.establishmentTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllEst = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationTab = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.establishmentSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsEstName,
            this.userName});
            this.statusStrip1.Location = new System.Drawing.Point(177, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(683, 22);
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
            // userName
            // 
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(65, 17);
            this.userName.Text = "UserName:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.establishmentSystemToolStripMenuItem,
            this.registrationTab,
            this.accountSettingsToolStripMenuItem,
            this.aboutSystemToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(177, 531);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // establishmentSystemToolStripMenuItem
            // 
            this.establishmentSystemToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.establishmentSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductOnMenuToolStripMenuItem,
            this.categoryMenuToolStripMenuItem,
            this.establishmentTypeToolStripMenuItem,
            this.showAllEst,
            this.viewMenuToolStripMenuItem});
            this.establishmentSystemToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.establishmentSystemToolStripMenuItem.Image = global::NearbyPlaces.Properties.Resources.if_maintenance_repair_service_Gear_3853928;
            this.establishmentSystemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.establishmentSystemToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.establishmentSystemToolStripMenuItem.Name = "establishmentSystemToolStripMenuItem";
            this.establishmentSystemToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.establishmentSystemToolStripMenuItem.Size = new System.Drawing.Size(164, 67);
            this.establishmentSystemToolStripMenuItem.Text = "Establishment Maintenance";
            this.establishmentSystemToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // addProductOnMenuToolStripMenuItem
            // 
            this.addProductOnMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.editProductToolStripMenuItem});
            this.addProductOnMenuToolStripMenuItem.Name = "addProductOnMenuToolStripMenuItem";
            this.addProductOnMenuToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
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
            this.categoryMenuToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.categoryMenuToolStripMenuItem.Text = "Category Menu Settings";
            this.categoryMenuToolStripMenuItem.Click += new System.EventHandler(this.categoryMenuToolStripMenuItem_Click);
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addCategoryToolStripMenuItem.Text = "Add Category";
            this.addCategoryToolStripMenuItem.Visible = false;
            this.addCategoryToolStripMenuItem.Click += new System.EventHandler(this.addCategoryToolStripMenuItem_Click);
            // 
            // editCategoryToolStripMenuItem
            // 
            this.editCategoryToolStripMenuItem.Name = "editCategoryToolStripMenuItem";
            this.editCategoryToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.editCategoryToolStripMenuItem.Text = "Edit Category";
            this.editCategoryToolStripMenuItem.Visible = false;
            this.editCategoryToolStripMenuItem.Click += new System.EventHandler(this.editCategoryToolStripMenuItem_Click);
            // 
            // establishmentTypeToolStripMenuItem
            // 
            this.establishmentTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTypeToolStripMenuItem,
            this.editTypeToolStripMenuItem});
            this.establishmentTypeToolStripMenuItem.Name = "establishmentTypeToolStripMenuItem";
            this.establishmentTypeToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.establishmentTypeToolStripMenuItem.Text = "Establishment Type";
            // 
            // addTypeToolStripMenuItem
            // 
            this.addTypeToolStripMenuItem.Name = "addTypeToolStripMenuItem";
            this.addTypeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.addTypeToolStripMenuItem.Text = "Add Type";
            this.addTypeToolStripMenuItem.Click += new System.EventHandler(this.addTypeToolStripMenuItem_Click);
            // 
            // editTypeToolStripMenuItem
            // 
            this.editTypeToolStripMenuItem.Name = "editTypeToolStripMenuItem";
            this.editTypeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.editTypeToolStripMenuItem.Text = "Edit Type";
            this.editTypeToolStripMenuItem.Click += new System.EventHandler(this.editTypeToolStripMenuItem_Click);
            // 
            // showAllEst
            // 
            this.showAllEst.Name = "showAllEst";
            this.showAllEst.Size = new System.Drawing.Size(253, 22);
            this.showAllEst.Text = "Show all Registered Establishment";
            this.showAllEst.Click += new System.EventHandler(this.showAllEst_Click);
            // 
            // viewMenuToolStripMenuItem
            // 
            this.viewMenuToolStripMenuItem.Name = "viewMenuToolStripMenuItem";
            this.viewMenuToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.viewMenuToolStripMenuItem.Text = "View Menu";
            this.viewMenuToolStripMenuItem.Click += new System.EventHandler(this.viewMenuToolStripMenuItem_Click);
            // 
            // registrationTab
            // 
            this.registrationTab.Image = global::NearbyPlaces.Properties.Resources.if_add_user_678158;
            this.registrationTab.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.registrationTab.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.registrationTab.Name = "registrationTab";
            this.registrationTab.Padding = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.registrationTab.Size = new System.Drawing.Size(164, 67);
            this.registrationTab.Text = "Registration";
            this.registrationTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.registrationTab.Click += new System.EventHandler(this.registrationTab_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.establishmentSettingsToolStripMenuItem});
            this.accountSettingsToolStripMenuItem.Image = global::NearbyPlaces.Properties.Resources.if_account_circle_326497;
            this.accountSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSettingsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(164, 67);
            this.accountSettingsToolStripMenuItem.Text = "Profile";
            this.accountSettingsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.accountSettingsToolStripMenuItem.Click += new System.EventHandler(this.accountSettingsToolStripMenuItem_Click);
            // 
            // establishmentSettingsToolStripMenuItem
            // 
            this.establishmentSettingsToolStripMenuItem.Name = "establishmentSettingsToolStripMenuItem";
            this.establishmentSettingsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.establishmentSettingsToolStripMenuItem.Text = "Establishment Settings";
            this.establishmentSettingsToolStripMenuItem.Visible = false;
            this.establishmentSettingsToolStripMenuItem.Click += new System.EventHandler(this.establishmentSettingsToolStripMenuItem_Click);
            // 
            // aboutSystemToolStripMenuItem
            // 
            this.aboutSystemToolStripMenuItem.Image = global::NearbyPlaces.Properties.Resources.if_v_31_3162614;
            this.aboutSystemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutSystemToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.aboutSystemToolStripMenuItem.Name = "aboutSystemToolStripMenuItem";
            this.aboutSystemToolStripMenuItem.Size = new System.Drawing.Size(164, 67);
            this.aboutSystemToolStripMenuItem.Text = "About System";
            this.aboutSystemToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.aboutSystemToolStripMenuItem.Visible = false;
            this.aboutSystemToolStripMenuItem.Click += new System.EventHandler(this.aboutSystemToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Image = global::NearbyPlaces.Properties.Resources.if_icons_exit2_1564506;
            this.lOGOUTToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lOGOUTToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(164, 67);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::NearbyPlaces.Properties.Resources.EATERYFINDERLOGO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(860, 531);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripStatusLabel tsLoggedIn;
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
        private System.Windows.Forms.ToolStripMenuItem establishmentTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationTab;
        private System.Windows.Forms.ToolStripStatusLabel userName;
        private System.Windows.Forms.ToolStripMenuItem showAllEst;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem establishmentSettingsToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel tsEstName;
        private System.Windows.Forms.ToolStripMenuItem viewMenuToolStripMenuItem;
    }
}