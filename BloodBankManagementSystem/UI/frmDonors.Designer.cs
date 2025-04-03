namespace BloodBankManagementSystem.UI
{
	partial class frmDonors
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonors));
			this.panelTop = new System.Windows.Forms.Panel();
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.lblFormTitle = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.dgvDonors = new System.Windows.Forms.DataGridView();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.txtContact = new System.Windows.Forms.TextBox();
			this.lblContact = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.lblLastName = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.txtDonorID = new System.Windows.Forms.TextBox();
			this.lblDonorID = new System.Windows.Forms.Label();
			this.btnSelectImage = new System.Windows.Forms.Button();
			this.PictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
			this.lblProfilePicture = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
			this.lblBloodGroup = new System.Windows.Forms.Label();
			this.panelTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfilePicture)).BeginInit();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.Salmon;
			this.panelTop.Controls.Add(this.pictureBoxClose);
			this.panelTop.Controls.Add(this.lblFormTitle);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(1100, 49);
			this.panelTop.TabIndex = 1;
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
			this.pictureBoxClose.Location = new System.Drawing.Point(1049, 3);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(48, 43);
			this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxClose.TabIndex = 1;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
			// 
			// lblFormTitle
			// 
			this.lblFormTitle.AutoSize = true;
			this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFormTitle.Location = new System.Drawing.Point(460, 9);
			this.lblFormTitle.Name = "lblFormTitle";
			this.lblFormTitle.Size = new System.Drawing.Size(184, 31);
			this.lblFormTitle.TabIndex = 0;
			this.lblFormTitle.Text = "Manage Donors";
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(622, 80);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(456, 30);
			this.txtSearch.TabIndex = 48;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(557, 87);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(47, 17);
			this.lblSearch.TabIndex = 47;
			this.lblSearch.Text = "Search";
			// 
			// dgvDonors
			// 
			this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDonors.Location = new System.Drawing.Point(542, 132);
			this.dgvDonors.Name = "dgvDonors";
			this.dgvDonors.RowHeadersWidth = 51;
			this.dgvDonors.RowTemplate.Height = 24;
			this.dgvDonors.Size = new System.Drawing.Size(536, 358);
			this.dgvDonors.TabIndex = 46;
			this.dgvDonors.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDonors_RowHeaderMouseClick);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
			this.btnClear.Location = new System.Drawing.Point(397, 448);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(100, 50);
			this.btnClear.TabIndex = 45;
			this.btnClear.Text = "CLEAR";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Crimson;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnDelete.Location = new System.Drawing.Point(275, 448);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(100, 50);
			this.btnDelete.TabIndex = 44;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.Teal;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
			this.btnUpdate.Location = new System.Drawing.Point(147, 448);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(100, 50);
			this.btnUpdate.TabIndex = 43;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Green;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
			this.btnAdd.Location = new System.Drawing.Point(22, 448);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(100, 50);
			this.btnAdd.TabIndex = 42;
			this.btnAdd.Text = "ADD";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtAddress
			// 
			this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.Location = new System.Drawing.Point(161, 415);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(336, 29);
			this.txtAddress.TabIndex = 41;
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAddress.Location = new System.Drawing.Point(46, 415);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(56, 17);
			this.lblAddress.TabIndex = 40;
			this.lblAddress.Text = "Address";
			// 
			// txtContact
			// 
			this.txtContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContact.Location = new System.Drawing.Point(161, 379);
			this.txtContact.MaxLength = 15;
			this.txtContact.Name = "txtContact";
			this.txtContact.Size = new System.Drawing.Size(336, 30);
			this.txtContact.TabIndex = 39;
			// 
			// lblContact
			// 
			this.lblContact.AutoSize = true;
			this.lblContact.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContact.Location = new System.Drawing.Point(46, 379);
			this.lblContact.Name = "lblContact";
			this.lblContact.Size = new System.Drawing.Size(52, 17);
			this.lblContact.TabIndex = 38;
			this.lblContact.Text = "Contact";
			// 
			// txtLastName
			// 
			this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLastName.Location = new System.Drawing.Point(161, 234);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(336, 30);
			this.txtLastName.TabIndex = 35;
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastName.Location = new System.Drawing.Point(46, 234);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(70, 17);
			this.lblLastName.TabIndex = 34;
			this.lblLastName.Text = "Last Name";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(161, 270);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(336, 30);
			this.txtEmail.TabIndex = 33;
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(46, 270);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(39, 17);
			this.lblEmail.TabIndex = 32;
			this.lblEmail.Text = "Email";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirstName.Location = new System.Drawing.Point(161, 199);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(336, 30);
			this.txtFirstName.TabIndex = 31;
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFirstName.Location = new System.Drawing.Point(46, 199);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(71, 17);
			this.lblFirstName.TabIndex = 30;
			this.lblFirstName.Text = "First Name";
			// 
			// txtDonorID
			// 
			this.txtDonorID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDonorID.Location = new System.Drawing.Point(161, 163);
			this.txtDonorID.Name = "txtDonorID";
			this.txtDonorID.ReadOnly = true;
			this.txtDonorID.Size = new System.Drawing.Size(336, 30);
			this.txtDonorID.TabIndex = 29;
			// 
			// lblDonorID
			// 
			this.lblDonorID.AutoSize = true;
			this.lblDonorID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDonorID.Location = new System.Drawing.Point(46, 163);
			this.lblDonorID.Name = "lblDonorID";
			this.lblDonorID.Size = new System.Drawing.Size(61, 17);
			this.lblDonorID.TabIndex = 28;
			this.lblDonorID.Text = "Donor ID";
			// 
			// btnSelectImage
			// 
			this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSelectImage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSelectImage.Location = new System.Drawing.Point(286, 110);
			this.btnSelectImage.Name = "btnSelectImage";
			this.btnSelectImage.Size = new System.Drawing.Size(169, 48);
			this.btnSelectImage.TabIndex = 27;
			this.btnSelectImage.Text = "Select Image";
			this.btnSelectImage.UseVisualStyleBackColor = true;
			this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
			// 
			// PictureBoxProfilePicture
			// 
			this.PictureBoxProfilePicture.Location = new System.Drawing.Point(161, 52);
			this.PictureBoxProfilePicture.Name = "PictureBoxProfilePicture";
			this.PictureBoxProfilePicture.Size = new System.Drawing.Size(119, 106);
			this.PictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBoxProfilePicture.TabIndex = 26;
			this.PictureBoxProfilePicture.TabStop = false;
			// 
			// lblProfilePicture
			// 
			this.lblProfilePicture.AutoSize = true;
			this.lblProfilePicture.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProfilePicture.Location = new System.Drawing.Point(46, 52);
			this.lblProfilePicture.Name = "lblProfilePicture";
			this.lblProfilePicture.Size = new System.Drawing.Size(88, 17);
			this.lblProfilePicture.TabIndex = 25;
			this.lblProfilePicture.Text = "Profile Picture";
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGender.Location = new System.Drawing.Point(46, 305);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(51, 17);
			this.lblGender.TabIndex = 49;
			this.lblGender.Text = "Gender";
			// 
			// cmbGender
			// 
			this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
			this.cmbGender.Location = new System.Drawing.Point(161, 305);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(336, 31);
			this.cmbGender.TabIndex = 52;
			// 
			// cmbBloodGroup
			// 
			this.cmbBloodGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbBloodGroup.FormattingEnabled = true;
			this.cmbBloodGroup.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A-",
            "A+",
            "B-",
            "B+",
            "AB+",
            "AB-"});
			this.cmbBloodGroup.Location = new System.Drawing.Point(161, 342);
			this.cmbBloodGroup.Name = "cmbBloodGroup";
			this.cmbBloodGroup.Size = new System.Drawing.Size(336, 31);
			this.cmbBloodGroup.TabIndex = 54;
			// 
			// lblBloodGroup
			// 
			this.lblBloodGroup.AutoSize = true;
			this.lblBloodGroup.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBloodGroup.Location = new System.Drawing.Point(46, 342);
			this.lblBloodGroup.Name = "lblBloodGroup";
			this.lblBloodGroup.Size = new System.Drawing.Size(83, 17);
			this.lblBloodGroup.TabIndex = 53;
			this.lblBloodGroup.Text = "Blood Group";
			// 
			// frmDonors
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1100, 500);
			this.Controls.Add(this.cmbBloodGroup);
			this.Controls.Add(this.lblBloodGroup);
			this.Controls.Add(this.cmbGender);
			this.Controls.Add(this.lblGender);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.dgvDonors);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.txtContact);
			this.Controls.Add(this.lblContact);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.txtDonorID);
			this.Controls.Add(this.lblDonorID);
			this.Controls.Add(this.btnSelectImage);
			this.Controls.Add(this.PictureBoxProfilePicture);
			this.Controls.Add(this.lblProfilePicture);
			this.Controls.Add(this.panelTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmDonors";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Donors";
			this.Load += new System.EventHandler(this.frmDonors_Load);
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfilePicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Label lblFormTitle;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.DataGridView dgvDonors;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox txtContact;
		private System.Windows.Forms.Label lblContact;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.TextBox txtDonorID;
		private System.Windows.Forms.Label lblDonorID;
		private System.Windows.Forms.Button btnSelectImage;
		private System.Windows.Forms.PictureBox PictureBoxProfilePicture;
		private System.Windows.Forms.Label lblProfilePicture;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.ComboBox cmbGender;
		private System.Windows.Forms.ComboBox cmbBloodGroup;
		private System.Windows.Forms.Label lblBloodGroup;
	}
}