﻿namespace NearbyPlaces
{
    partial class frmRegistration
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.gbAccountDetails = new System.Windows.Forms.GroupBox();
            this.gbEstablishmentDetails = new System.Windows.Forms.GroupBox();
            this.txtEstablishmentName = new System.Windows.Forms.TextBox();
            this.txtLon = new System.Windows.Forms.TextBox();
            this.lblEstName = new System.Windows.Forms.Label();
            this.lblLon = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.lblEmotion = new System.Windows.Forms.Label();
            this.cbEmotion = new System.Windows.Forms.ComboBox();
            this.cbAge = new System.Windows.Forms.ComboBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtSecurity = new System.Windows.Forms.TextBox();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbAccountDetails.SuspendLayout();
            this.gbEstablishmentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(10, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(64, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username : ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(125, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(152, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(125, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(152, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(10, 48);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password : ";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(125, 71);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(152, 20);
            this.txtRePassword.TabIndex = 5;
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Location = new System.Drawing.Point(10, 74);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(79, 13);
            this.lblRePassword.TabIndex = 4;
            this.lblRePassword.Text = "Re-Password : ";
            // 
            // gbAccountDetails
            // 
            this.gbAccountDetails.Controls.Add(this.lblSecurity);
            this.gbAccountDetails.Controls.Add(this.txtSecurity);
            this.gbAccountDetails.Controls.Add(this.txtUsername);
            this.gbAccountDetails.Controls.Add(this.txtRePassword);
            this.gbAccountDetails.Controls.Add(this.lblUsername);
            this.gbAccountDetails.Controls.Add(this.lblRePassword);
            this.gbAccountDetails.Controls.Add(this.lblPassword);
            this.gbAccountDetails.Controls.Add(this.txtPassword);
            this.gbAccountDetails.Location = new System.Drawing.Point(13, 13);
            this.gbAccountDetails.Name = "gbAccountDetails";
            this.gbAccountDetails.Size = new System.Drawing.Size(283, 164);
            this.gbAccountDetails.TabIndex = 6;
            this.gbAccountDetails.TabStop = false;
            this.gbAccountDetails.Text = "Account Details";
            // 
            // gbEstablishmentDetails
            // 
            this.gbEstablishmentDetails.Controls.Add(this.cbAge);
            this.gbEstablishmentDetails.Controls.Add(this.lblAge);
            this.gbEstablishmentDetails.Controls.Add(this.cbEmotion);
            this.gbEstablishmentDetails.Controls.Add(this.lblEmotion);
            this.gbEstablishmentDetails.Controls.Add(this.txtEstablishmentName);
            this.gbEstablishmentDetails.Controls.Add(this.txtLon);
            this.gbEstablishmentDetails.Controls.Add(this.txtLat);
            this.gbEstablishmentDetails.Controls.Add(this.lblEstName);
            this.gbEstablishmentDetails.Controls.Add(this.lblLat);
            this.gbEstablishmentDetails.Controls.Add(this.lblLon);
            this.gbEstablishmentDetails.Location = new System.Drawing.Point(302, 13);
            this.gbEstablishmentDetails.Name = "gbEstablishmentDetails";
            this.gbEstablishmentDetails.Size = new System.Drawing.Size(355, 164);
            this.gbEstablishmentDetails.TabIndex = 7;
            this.gbEstablishmentDetails.TabStop = false;
            this.gbEstablishmentDetails.Text = "EstablishmentDetails";
            this.gbEstablishmentDetails.Enter += new System.EventHandler(this.gbEstablishmentDetails_Enter);
            // 
            // txtEstablishmentName
            // 
            this.txtEstablishmentName.Location = new System.Drawing.Point(144, 19);
            this.txtEstablishmentName.Name = "txtEstablishmentName";
            this.txtEstablishmentName.Size = new System.Drawing.Size(205, 20);
            this.txtEstablishmentName.TabIndex = 7;
            // 
            // txtLon
            // 
            this.txtLon.Location = new System.Drawing.Point(144, 71);
            this.txtLon.Name = "txtLon";
            this.txtLon.Size = new System.Drawing.Size(205, 20);
            this.txtLon.TabIndex = 11;
            // 
            // lblEstName
            // 
            this.lblEstName.AutoSize = true;
            this.lblEstName.Location = new System.Drawing.Point(13, 22);
            this.lblEstName.Name = "lblEstName";
            this.lblEstName.Size = new System.Drawing.Size(106, 13);
            this.lblEstName.TabIndex = 6;
            this.lblEstName.Text = "Establisment Name : ";
            this.lblEstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLon
            // 
            this.lblLon.AutoSize = true;
            this.lblLon.Location = new System.Drawing.Point(13, 74);
            this.lblLon.Name = "lblLon";
            this.lblLon.Size = new System.Drawing.Size(87, 13);
            this.lblLon.TabIndex = 10;
            this.lblLon.Text = "Map Longitude : ";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Location = new System.Drawing.Point(13, 48);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(74, 13);
            this.lblLat.TabIndex = 8;
            this.lblLat.Text = "Map latitude : ";
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(144, 45);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(205, 20);
            this.txtLat.TabIndex = 9;
            // 
            // lblEmotion
            // 
            this.lblEmotion.AutoSize = true;
            this.lblEmotion.Location = new System.Drawing.Point(13, 102);
            this.lblEmotion.Name = "lblEmotion";
            this.lblEmotion.Size = new System.Drawing.Size(115, 13);
            this.lblEmotion.TabIndex = 12;
            this.lblEmotion.Text = "Good For Emotion Of : ";
            // 
            // cbEmotion
            // 
            this.cbEmotion.FormattingEnabled = true;
            this.cbEmotion.Items.AddRange(new object[] {
            "----SELECT THE BEST ONE----",
            "HAPPY",
            "SAD",
            "ALL"});
            this.cbEmotion.Location = new System.Drawing.Point(144, 97);
            this.cbEmotion.Name = "cbEmotion";
            this.cbEmotion.Size = new System.Drawing.Size(205, 21);
            this.cbEmotion.TabIndex = 13;
            // 
            // cbAge
            // 
            this.cbAge.FormattingEnabled = true;
            this.cbAge.Items.AddRange(new object[] {
            "----SELECT THE BEST ONE----",
            "CHILDREN (0 - 14 years old)",
            "YOUTH (15 - 24 years old)",
            "ADULTS (25 - 59 years old)",
            "SENIORS (60 and Over years old)",
            "ALL"});
            this.cbAge.Location = new System.Drawing.Point(144, 124);
            this.cbAge.Name = "cbAge";
            this.cbAge.Size = new System.Drawing.Size(205, 21);
            this.cbAge.TabIndex = 15;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(13, 129);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(96, 13);
            this.lblAge.TabIndex = 14;
            this.lblAge.Text = "Good For Age Of : ";
            // 
            // txtSecurity
            // 
            this.txtSecurity.Location = new System.Drawing.Point(125, 99);
            this.txtSecurity.Name = "txtSecurity";
            this.txtSecurity.PasswordChar = '_';
            this.txtSecurity.Size = new System.Drawing.Size(152, 20);
            this.txtSecurity.TabIndex = 6;
            // 
            // lblSecurity
            // 
            this.lblSecurity.AutoSize = true;
            this.lblSecurity.Location = new System.Drawing.Point(10, 102);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(113, 13);
            this.lblSecurity.TabIndex = 7;
            this.lblSecurity.Text = "Security Registration : ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(13, 184);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(201, 51);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(220, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(201, 51);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 247);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbEstablishmentDetails);
            this.Controls.Add(this.gbAccountDetails);
            this.Name = "frmRegistration";
            this.Text = "Establishment Registration";
            this.gbAccountDetails.ResumeLayout(false);
            this.gbAccountDetails.PerformLayout();
            this.gbEstablishmentDetails.ResumeLayout(false);
            this.gbEstablishmentDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.GroupBox gbAccountDetails;
        private System.Windows.Forms.GroupBox gbEstablishmentDetails;
        private System.Windows.Forms.TextBox txtEstablishmentName;
        private System.Windows.Forms.TextBox txtLon;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label lblEstName;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblLon;
        private System.Windows.Forms.ComboBox cbAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ComboBox cbEmotion;
        private System.Windows.Forms.Label lblEmotion;
        private System.Windows.Forms.Label lblSecurity;
        private System.Windows.Forms.TextBox txtSecurity;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}