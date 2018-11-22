namespace NearbyPlaces
{
    partial class frmUpdateComment
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
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblCommentStatus = new System.Windows.Forms.Label();
            this.cbCommentStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(13, 12);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(84, 16);
            this.lblComment.TabIndex = 0;
            this.lblComment.Text = "Comment : ";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(156, 12);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ReadOnly = true;
            this.txtComment.Size = new System.Drawing.Size(216, 128);
            this.txtComment.TabIndex = 1;
            // 
            // lblCommentStatus
            // 
            this.lblCommentStatus.AutoSize = true;
            this.lblCommentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentStatus.Location = new System.Drawing.Point(13, 159);
            this.lblCommentStatus.Name = "lblCommentStatus";
            this.lblCommentStatus.Size = new System.Drawing.Size(131, 16);
            this.lblCommentStatus.TabIndex = 2;
            this.lblCommentStatus.Text = "Comment Status : ";
            // 
            // cbCommentStatus
            // 
            this.cbCommentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCommentStatus.FormattingEnabled = true;
            this.cbCommentStatus.Items.AddRange(new object[] {
            "PENDING",
            "POST",
            "REJECT"});
            this.cbCommentStatus.Location = new System.Drawing.Point(156, 158);
            this.cbCommentStatus.Name = "cbCommentStatus";
            this.cbCommentStatus.Size = new System.Drawing.Size(216, 21);
            this.cbCommentStatus.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(379, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 50);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(378, 68);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmUpdateComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 211);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbCommentStatus);
            this.Controls.Add(this.lblCommentStatus);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateComment";
            this.Text = "frmUpdateComment";
            this.Load += new System.EventHandler(this.frmUpdateComment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblCommentStatus;
        private System.Windows.Forms.ComboBox cbCommentStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}