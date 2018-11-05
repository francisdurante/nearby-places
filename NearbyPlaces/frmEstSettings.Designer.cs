namespace NearbyPlaces
{
    partial class frmEstSettings
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
            this.lbluserName = new System.Windows.Forms.Label();
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangePic = new System.Windows.Forms.Button();
            this.pbFrontStore = new System.Windows.Forms.PictureBox();
            this.cbAge = new System.Windows.Forms.ComboBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.cbEmotion = new System.Windows.Forms.ComboBox();
            this.lblEmotion = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cbEstType = new System.Windows.Forms.ComboBox();
            this.lblEstType = new System.Windows.Forms.Label();
            this.txtEstName = new System.Windows.Forms.TextBox();
            this.lblEstName = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblNote2 = new System.Windows.Forms.Label();
            this.lblNote3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbAccount.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrontStore)).BeginInit();
            this.SuspendLayout();
            // 
            // lbluserName
            // 
            this.lbluserName.AutoSize = true;
            this.lbluserName.Location = new System.Drawing.Point(6, 31);
            this.lbluserName.Name = "lbluserName";
            this.lbluserName.Size = new System.Drawing.Size(64, 13);
            this.lbluserName.TabIndex = 0;
            this.lbluserName.Text = "Username : ";
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.btnChangePassword);
            this.gbAccount.Controls.Add(this.txtUserName);
            this.gbAccount.Controls.Add(this.lbluserName);
            this.gbAccount.Location = new System.Drawing.Point(12, 241);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(273, 110);
            this.gbAccount.TabIndex = 1;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "Account Settings";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(9, 58);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(252, 23);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(76, 28);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(185, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangePic);
            this.groupBox1.Controls.Add(this.pbFrontStore);
            this.groupBox1.Controls.Add(this.cbAge);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.cbEmotion);
            this.groupBox1.Controls.Add(this.lblEmotion);
            this.groupBox1.Controls.Add(this.txtLongitude);
            this.groupBox1.Controls.Add(this.lblLongitude);
            this.groupBox1.Controls.Add(this.txtLatitude);
            this.groupBox1.Controls.Add(this.lblLatitude);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.cbEstType);
            this.groupBox1.Controls.Add(this.lblEstType);
            this.groupBox1.Controls.Add(this.txtEstName);
            this.groupBox1.Controls.Add(this.lblEstName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 223);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Establishment Settings";
            // 
            // btnChangePic
            // 
            this.btnChangePic.Location = new System.Drawing.Point(342, 188);
            this.btnChangePic.Name = "btnChangePic";
            this.btnChangePic.Size = new System.Drawing.Size(200, 23);
            this.btnChangePic.TabIndex = 15;
            this.btnChangePic.Text = "CHANGE";
            this.btnChangePic.UseVisualStyleBackColor = true;
            this.btnChangePic.Click += new System.EventHandler(this.btnChangePic_Click);
            // 
            // pbFrontStore
            // 
            this.pbFrontStore.Location = new System.Drawing.Point(342, 106);
            this.pbFrontStore.Name = "pbFrontStore";
            this.pbFrontStore.Size = new System.Drawing.Size(200, 75);
            this.pbFrontStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFrontStore.TabIndex = 14;
            this.pbFrontStore.TabStop = false;
            // 
            // cbAge
            // 
            this.cbAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAge.FormattingEnabled = true;
            this.cbAge.Items.AddRange(new object[] {
            "----SELECT THE BEST ONE----",
            "CHILDREN (0 - 14 years old)",
            "YOUTH (15 - 24 years old)",
            "ADULTS (25 - 59 years old)",
            "SENIORS (60 and Over years old)",
            "ALL"});
            this.cbAge.Location = new System.Drawing.Point(146, 133);
            this.cbAge.Name = "cbAge";
            this.cbAge.Size = new System.Drawing.Size(173, 21);
            this.cbAge.TabIndex = 13;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(9, 136);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(93, 13);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Good for Age Of : ";
            // 
            // cbEmotion
            // 
            this.cbEmotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmotion.FormattingEnabled = true;
            this.cbEmotion.Items.AddRange(new object[] {
            "----SELECT THE BEST ONE----",
            "HAPPY",
            "SAD",
            "ANGER",
            "CONTEMPT",
            "DISGUST",
            "FEAR",
            "NEUTRAL",
            "SURPIRSE",
            "ALL"});
            this.cbEmotion.Location = new System.Drawing.Point(146, 106);
            this.cbEmotion.Name = "cbEmotion";
            this.cbEmotion.Size = new System.Drawing.Size(173, 21);
            this.cbEmotion.TabIndex = 11;
            // 
            // lblEmotion
            // 
            this.lblEmotion.AutoSize = true;
            this.lblEmotion.Location = new System.Drawing.Point(9, 109);
            this.lblEmotion.Name = "lblEmotion";
            this.lblEmotion.Size = new System.Drawing.Size(112, 13);
            this.lblEmotion.TabIndex = 10;
            this.lblEmotion.Text = "Good for Emotion Of : ";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(382, 80);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(160, 20);
            this.txtLongitude.TabIndex = 9;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(313, 83);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(63, 13);
            this.lblLongitude.TabIndex = 8;
            this.lblLongitude.Text = "Longitude : ";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(146, 80);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(160, 20);
            this.txtLatitude.TabIndex = 7;
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(9, 83);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(54, 13);
            this.lblLatitude.TabIndex = 6;
            this.lblLatitude.Text = "Latitude : ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(146, 53);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(396, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(9, 56);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(113, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Establishment Address";
            // 
            // cbEstType
            // 
            this.cbEstType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstType.FormattingEnabled = true;
            this.cbEstType.Location = new System.Drawing.Point(146, 160);
            this.cbEstType.Name = "cbEstType";
            this.cbEstType.Size = new System.Drawing.Size(173, 21);
            this.cbEstType.TabIndex = 3;
            this.cbEstType.SelectedIndexChanged += new System.EventHandler(this.cbEstType_SelectedIndexChanged);
            // 
            // lblEstType
            // 
            this.lblEstType.AutoSize = true;
            this.lblEstType.Location = new System.Drawing.Point(9, 163);
            this.lblEstType.Name = "lblEstType";
            this.lblEstType.Size = new System.Drawing.Size(108, 13);
            this.lblEstType.TabIndex = 2;
            this.lblEstType.Text = "Establishment Type : ";
            this.lblEstType.Click += new System.EventHandler(this.lblEstType_Click);
            // 
            // txtEstName
            // 
            this.txtEstName.Location = new System.Drawing.Point(146, 27);
            this.txtEstName.Name = "txtEstName";
            this.txtEstName.Size = new System.Drawing.Size(396, 20);
            this.txtEstName.TabIndex = 1;
            // 
            // lblEstName
            // 
            this.lblEstName.AutoSize = true;
            this.lblEstName.Location = new System.Drawing.Point(9, 30);
            this.lblEstName.Name = "lblEstName";
            this.lblEstName.Size = new System.Drawing.Size(112, 13);
            this.lblEstName.TabIndex = 0;
            this.lblEstName.Text = "Establishment Name : ";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(332, 323);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(222, 13);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "Please dont change anything if not necessary";
            // 
            // lblNote2
            // 
            this.lblNote2.AutoSize = true;
            this.lblNote2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote2.Location = new System.Drawing.Point(424, 304);
            this.lblNote2.Name = "lblNote2";
            this.lblNote2.Size = new System.Drawing.Size(40, 13);
            this.lblNote2.TabIndex = 4;
            this.lblNote2.Text = "NOTE!";
            // 
            // lblNote3
            // 
            this.lblNote3.AutoSize = true;
            this.lblNote3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote3.Location = new System.Drawing.Point(291, 339);
            this.lblNote3.Name = "lblNote3";
            this.lblNote3.Size = new System.Drawing.Size(294, 13);
            this.lblNote3.TabIndex = 5;
            this.lblNote3.Text = "unnecessary changes will affect to your establishment setting";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(313, 241);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(129, 48);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(448, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 48);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEstSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(598, 363);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblNote3);
            this.Controls.Add(this.lblNote2);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstSettings";
            this.Text = "Establishment Settings";
            this.Load += new System.EventHandler(this.frmEstSettings_Load);
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrontStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluserName;
        private System.Windows.Forms.GroupBox gbAccount;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cbEstType;
        private System.Windows.Forms.Label lblEstType;
        private System.Windows.Forms.TextBox txtEstName;
        private System.Windows.Forms.Label lblEstName;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblEmotion;
        private System.Windows.Forms.Button btnChangePic;
        private System.Windows.Forms.PictureBox pbFrontStore;
        private System.Windows.Forms.ComboBox cbAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ComboBox cbEmotion;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblNote2;
        private System.Windows.Forms.Label lblNote3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}