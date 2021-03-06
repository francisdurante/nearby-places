﻿namespace NearbyPlaces
{
    partial class frmEditEstType
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
            this.cbEstName = new System.Windows.Forms.ComboBox();
            this.lblEstName = new System.Windows.Forms.Label();
            this.lblCEstname = new System.Windows.Forms.Label();
            this.txtCurrentEstName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbEstName
            // 
            this.cbEstName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstName.FormattingEnabled = true;
            this.cbEstName.Location = new System.Drawing.Point(216, 28);
            this.cbEstName.Name = "cbEstName";
            this.cbEstName.Size = new System.Drawing.Size(195, 21);
            this.cbEstName.TabIndex = 0;
            this.cbEstName.SelectedIndexChanged += new System.EventHandler(this.cbEstName_SelectedIndexChanged);
            // 
            // lblEstName
            // 
            this.lblEstName.AutoSize = true;
            this.lblEstName.BackColor = System.Drawing.Color.Transparent;
            this.lblEstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstName.ForeColor = System.Drawing.Color.Black;
            this.lblEstName.Location = new System.Drawing.Point(13, 29);
            this.lblEstName.Name = "lblEstName";
            this.lblEstName.Size = new System.Drawing.Size(152, 15);
            this.lblEstName.TabIndex = 1;
            this.lblEstName.Text = "Establishment Name : ";
            // 
            // lblCEstname
            // 
            this.lblCEstname.AutoSize = true;
            this.lblCEstname.BackColor = System.Drawing.Color.Transparent;
            this.lblCEstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEstname.ForeColor = System.Drawing.Color.Black;
            this.lblCEstname.Location = new System.Drawing.Point(13, 56);
            this.lblCEstname.Name = "lblCEstname";
            this.lblCEstname.Size = new System.Drawing.Size(203, 15);
            this.lblCEstname.TabIndex = 2;
            this.lblCEstname.Text = "Current Establishment Name : ";
            this.lblCEstname.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCurrentEstName
            // 
            this.txtCurrentEstName.Location = new System.Drawing.Point(216, 55);
            this.txtCurrentEstName.Name = "txtCurrentEstName";
            this.txtCurrentEstName.Size = new System.Drawing.Size(195, 20);
            this.txtCurrentEstName.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(13, 84);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status : ";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE"});
            this.cbStatus.Location = new System.Drawing.Point(216, 83);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(195, 21);
            this.cbStatus.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 53);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SUBMIT";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(168, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 53);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEditEstType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 185);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtCurrentEstName);
            this.Controls.Add(this.lblCEstname);
            this.Controls.Add(this.lblEstName);
            this.Controls.Add(this.cbEstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditEstType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Establishment Type";
            this.Load += new System.EventHandler(this.frmEditEstType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEstName;
        private System.Windows.Forms.Label lblEstName;
        private System.Windows.Forms.Label lblCEstname;
        private System.Windows.Forms.TextBox txtCurrentEstName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}