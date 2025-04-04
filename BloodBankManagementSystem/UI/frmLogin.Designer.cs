﻿namespace BloodBankManagementSystem.UI
{
	partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblAppName = new System.Windows.Forms.Label();
			this.lblAppSubName = new System.Windows.Forms.Label();
			this.pictureBoxAppIcon = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAppIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(950, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(51, 45);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.Location = new System.Drawing.Point(552, 118);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(87, 23);
			this.lblUsername.TabIndex = 1;
			this.lblUsername.Text = "Username";
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(556, 154);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(339, 34);
			this.txtUsername.TabIndex = 2;
			this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(556, 253);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(339, 34);
			this.txtPassword.TabIndex = 4;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(552, 217);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(82, 23);
			this.lblPassword.TabIndex = 3;
			this.lblPassword.Text = "Password";
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.Green;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
			this.btnLogin.Location = new System.Drawing.Point(556, 323);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(339, 71);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lblAppName
			// 
			this.lblAppName.AutoSize = true;
			this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppName.Location = new System.Drawing.Point(150, 299);
			this.lblAppName.Name = "lblAppName";
			this.lblAppName.Size = new System.Drawing.Size(238, 54);
			this.lblAppName.TabIndex = 6;
			this.lblAppName.Text = "Blood Bank";
			// 
			// lblAppSubName
			// 
			this.lblAppSubName.AutoSize = true;
			this.lblAppSubName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppSubName.Location = new System.Drawing.Point(153, 353);
			this.lblAppSubName.Name = "lblAppSubName";
			this.lblAppSubName.Size = new System.Drawing.Size(229, 31);
			this.lblAppSubName.TabIndex = 7;
			this.lblAppSubName.Text = "Management System";
			// 
			// pictureBoxAppIcon
			// 
			this.pictureBoxAppIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAppIcon.Image")));
			this.pictureBoxAppIcon.Location = new System.Drawing.Point(193, 118);
			this.pictureBoxAppIcon.Name = "pictureBoxAppIcon";
			this.pictureBoxAppIcon.Size = new System.Drawing.Size(150, 136);
			this.pictureBoxAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxAppIcon.TabIndex = 8;
			this.pictureBoxAppIcon.TabStop = false;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1013, 554);
			this.Controls.Add(this.pictureBoxAppIcon);
			this.Controls.Add(this.lblAppSubName);
			this.Controls.Add(this.lblAppName);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmLogin";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAppIcon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lblAppName;
		private System.Windows.Forms.Label lblAppSubName;
		private System.Windows.Forms.PictureBox pictureBoxAppIcon;
	}
}