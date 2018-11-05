namespace NearbyPlaces
{
    partial class frmRegisteredEst
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
            this.lvEst = new System.Windows.Forms.ListView();
            this.cl_est_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_est_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_est_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_latitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_longitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_emotion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_front_store = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_est_status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_user_status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvEst
            // 
            this.lvEst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_est_id,
            this.cl_username,
            this.cl_est_name,
            this.cl_est_type,
            this.cl_latitude,
            this.cl_longitude,
            this.cl_emotion,
            this.cl_age,
            this.cl_front_store,
            this.cl_est_status,
            this.cl_user_status,
            this.cl_address});
            this.lvEst.FullRowSelect = true;
            this.lvEst.GridLines = true;
            this.lvEst.Location = new System.Drawing.Point(12, 62);
            this.lvEst.Name = "lvEst";
            this.lvEst.Size = new System.Drawing.Size(758, 332);
            this.lvEst.TabIndex = 0;
            this.lvEst.UseCompatibleStateImageBehavior = false;
            this.lvEst.View = System.Windows.Forms.View.Details;
            // 
            // cl_est_id
            // 
            this.cl_est_id.Text = "Establishment ID";
            this.cl_est_id.Width = 100;
            // 
            // cl_username
            // 
            this.cl_username.Text = "Username";
            this.cl_username.Width = 100;
            // 
            // cl_est_name
            // 
            this.cl_est_name.Text = "Establishment Name";
            this.cl_est_name.Width = 120;
            // 
            // cl_est_type
            // 
            this.cl_est_type.Text = "Establishment Type";
            this.cl_est_type.Width = 120;
            // 
            // cl_latitude
            // 
            this.cl_latitude.Text = "Latitude";
            // 
            // cl_longitude
            // 
            this.cl_longitude.Text = "Longitude";
            // 
            // cl_emotion
            // 
            this.cl_emotion.Text = "Emotion";
            this.cl_emotion.Width = 70;
            // 
            // cl_age
            // 
            this.cl_age.Text = "Age";
            this.cl_age.Width = 70;
            // 
            // cl_front_store
            // 
            this.cl_front_store.Text = "Picture Path";
            this.cl_front_store.Width = 120;
            // 
            // cl_est_status
            // 
            this.cl_est_status.Text = "Establishment Status";
            this.cl_est_status.Width = 120;
            // 
            // cl_user_status
            // 
            this.cl_user_status.Text = "User Status";
            this.cl_user_status.Width = 120;
            // 
            // cl_address
            // 
            this.cl_address.Text = "Address";
            this.cl_address.Width = 120;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(13, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(165, 52);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(184, 7);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(50, 13);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search : ";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(230, 4);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(204, 20);
            this.txtKey.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(450, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(184, 31);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(38, 13);
            this.lblFilter.TabIndex = 5;
            this.lblFilter.Text = "Filter : ";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(230, 28);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(204, 21);
            this.cbCategory.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(13, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 62);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmRegisteredEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(784, 485);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lvEst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegisteredEst";
            this.Text = "Registered Establishment";
            this.Load += new System.EventHandler(this.frmRegisteredEst_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEst;
        private System.Windows.Forms.ColumnHeader cl_est_id;
        private System.Windows.Forms.ColumnHeader cl_username;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ColumnHeader cl_est_name;
        private System.Windows.Forms.ColumnHeader cl_est_type;
        private System.Windows.Forms.ColumnHeader cl_latitude;
        private System.Windows.Forms.ColumnHeader cl_longitude;
        private System.Windows.Forms.ColumnHeader cl_emotion;
        private System.Windows.Forms.ColumnHeader cl_age;
        private System.Windows.Forms.ColumnHeader cl_front_store;
        private System.Windows.Forms.ColumnHeader cl_est_status;
        private System.Windows.Forms.ColumnHeader cl_user_status;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ColumnHeader cl_address;
        private System.Windows.Forms.Button btnCancel;
    }
}