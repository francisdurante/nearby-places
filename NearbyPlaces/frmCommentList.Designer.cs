namespace NearbyPlaces
{
    partial class frmCommentList
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
            this.lvCommentList = new System.Windows.Forms.ListView();
            this.chCommentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCommentText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCommentStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCommentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCommentBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCommentTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSearchKey = new System.Windows.Forms.Label();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvCommentList
            // 
            this.lvCommentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCommentID,
            this.chCommentText,
            this.chCommentStatus,
            this.chCommentDate,
            this.chCommentBy,
            this.chCommentTo});
            this.lvCommentList.FullRowSelect = true;
            this.lvCommentList.GridLines = true;
            this.lvCommentList.Location = new System.Drawing.Point(12, 65);
            this.lvCommentList.Name = "lvCommentList";
            this.lvCommentList.Size = new System.Drawing.Size(848, 358);
            this.lvCommentList.TabIndex = 0;
            this.lvCommentList.UseCompatibleStateImageBehavior = false;
            this.lvCommentList.View = System.Windows.Forms.View.Details;
            this.lvCommentList.DoubleClick += new System.EventHandler(this.lvCommentList_DoubleClick);
            // 
            // chCommentID
            // 
            this.chCommentID.Text = "Comment ID";
            this.chCommentID.Width = 100;
            // 
            // chCommentText
            // 
            this.chCommentText.Text = "Comment";
            this.chCommentText.Width = 300;
            // 
            // chCommentStatus
            // 
            this.chCommentStatus.Text = "Comment Status";
            this.chCommentStatus.Width = 120;
            // 
            // chCommentDate
            // 
            this.chCommentDate.Text = "Comment Date";
            this.chCommentDate.Width = 120;
            // 
            // chCommentBy
            // 
            this.chCommentBy.Text = "Comment By";
            this.chCommentBy.Width = 100;
            // 
            // chCommentTo
            // 
            this.chCommentTo.Text = "Comment To";
            this.chCommentTo.Width = 100;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(141, 46);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSearchKey
            // 
            this.lblSearchKey.AutoSize = true;
            this.lblSearchKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchKey.Location = new System.Drawing.Point(160, 13);
            this.lblSearchKey.Name = "lblSearchKey";
            this.lblSearchKey.Size = new System.Drawing.Size(91, 15);
            this.lblSearchKey.TabIndex = 2;
            this.lblSearchKey.Text = "Search Key : ";
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(257, 12);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(232, 20);
            this.txtSearchKey.TabIndex = 3;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(160, 39);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(71, 15);
            this.lblFilter.TabIndex = 4;
            this.lblFilter.Text = "Filter By : ";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Establishment",
            "Username"});
            this.cbFilter.Location = new System.Drawing.Point(257, 38);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(232, 21);
            this.cbFilter.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(495, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 46);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 429);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 46);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCommentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 491);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.txtSearchKey);
            this.Controls.Add(this.lblSearchKey);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lvCommentList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCommentList";
            this.Text = "frmCommentList";
            this.Load += new System.EventHandler(this.frmCommentList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCommentList;
        private System.Windows.Forms.ColumnHeader chCommentID;
        private System.Windows.Forms.ColumnHeader chCommentText;
        private System.Windows.Forms.ColumnHeader chCommentStatus;
        private System.Windows.Forms.ColumnHeader chCommentDate;
        private System.Windows.Forms.ColumnHeader chCommentBy;
        private System.Windows.Forms.ColumnHeader chCommentTo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSearchKey;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
    }
}