﻿namespace BloodBankManagementSystem
{
	partial class frmHome
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
			this.menuStripTop = new System.Windows.Forms.MenuStrip();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.donorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelFooter = new System.Windows.Forms.Panel();
			this.lblDeveloper = new System.Windows.Forms.Label();
			this.lblDevTitel = new System.Windows.Forms.Label();
			this.lblAppName = new System.Windows.Forms.Label();
			this.panelOpositive = new System.Windows.Forms.Panel();
			this.lblName = new System.Windows.Forms.Label();
			this.lblOpositiveCount = new System.Windows.Forms.Label();
			this.lblOpositive = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblOnegativeCount = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblOnegative = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblAnegativeCount = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblAnegative = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.lblApositiveCount = new System.Windows.Forms.Label();
			this.lblApositive = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lblABnegativeCount = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lblABnegative = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.lblABpositiveCount = new System.Windows.Forms.Label();
			this.lblABpositive = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.lblBnegativeCount = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.lblBnegative = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label19 = new System.Windows.Forms.Label();
			this.lblBpositiveCount = new System.Windows.Forms.Label();
			this.lblBpositive = new System.Windows.Forms.Label();
			this.dgvDonors = new System.Windows.Forms.DataGridView();
			this.lblSearch = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.lblUserTitle = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.menuStripTop.SuspendLayout();
			this.panelFooter.SuspendLayout();
			this.panelOpositive.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStripTop
			// 
			this.menuStripTop.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStripTop.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.donorsToolStripMenuItem});
			this.menuStripTop.Location = new System.Drawing.Point(0, 0);
			this.menuStripTop.Name = "menuStripTop";
			this.menuStripTop.Padding = new System.Windows.Forms.Padding(5, 11, 0, 11);
			this.menuStripTop.Size = new System.Drawing.Size(1255, 49);
			this.menuStripTop.TabIndex = 0;
			this.menuStripTop.Text = "menuStrip1";
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(66, 27);
			this.usersToolStripMenuItem.Text = "Users";
			this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
			// 
			// donorsToolStripMenuItem
			// 
			this.donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
			this.donorsToolStripMenuItem.Size = new System.Drawing.Size(81, 27);
			this.donorsToolStripMenuItem.Text = "Donors";
			this.donorsToolStripMenuItem.Click += new System.EventHandler(this.donorsToolStripMenuItem_Click);
			// 
			// panelFooter
			// 
			this.panelFooter.BackColor = System.Drawing.SystemColors.Control;
			this.panelFooter.Controls.Add(this.lblDeveloper);
			this.panelFooter.Controls.Add(this.lblDevTitel);
			this.panelFooter.Controls.Add(this.lblAppName);
			this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelFooter.Location = new System.Drawing.Point(0, 567);
			this.panelFooter.Name = "panelFooter";
			this.panelFooter.Size = new System.Drawing.Size(1255, 49);
			this.panelFooter.TabIndex = 1;
			// 
			// lblDeveloper
			// 
			this.lblDeveloper.AutoSize = true;
			this.lblDeveloper.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDeveloper.ForeColor = System.Drawing.Color.Navy;
			this.lblDeveloper.Location = new System.Drawing.Point(806, 8);
			this.lblDeveloper.Name = "lblDeveloper";
			this.lblDeveloper.Size = new System.Drawing.Size(217, 38);
			this.lblDeveloper.TabIndex = 2;
			this.lblDeveloper.Text = "Devansh Gupta";
			// 
			// lblDevTitel
			// 
			this.lblDevTitel.AutoSize = true;
			this.lblDevTitel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDevTitel.ForeColor = System.Drawing.Color.Black;
			this.lblDevTitel.Location = new System.Drawing.Point(610, 8);
			this.lblDevTitel.Name = "lblDevTitel";
			this.lblDevTitel.Size = new System.Drawing.Size(215, 38);
			this.lblDevTitel.TabIndex = 1;
			this.lblDevTitel.Text = "Developed By - ";
			// 
			// lblAppName
			// 
			this.lblAppName.AutoSize = true;
			this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
			this.lblAppName.Location = new System.Drawing.Point(119, 8);
			this.lblAppName.Name = "lblAppName";
			this.lblAppName.Size = new System.Drawing.Size(424, 38);
			this.lblAppName.TabIndex = 0;
			this.lblAppName.Text = "Blood Bank Management System";
			// 
			// panelOpositive
			// 
			this.panelOpositive.BackColor = System.Drawing.SystemColors.Control;
			this.panelOpositive.Controls.Add(this.lblName);
			this.panelOpositive.Controls.Add(this.lblOpositiveCount);
			this.panelOpositive.Controls.Add(this.lblOpositive);
			this.panelOpositive.Location = new System.Drawing.Point(12, 81);
			this.panelOpositive.Name = "panelOpositive";
			this.panelOpositive.Size = new System.Drawing.Size(200, 100);
			this.panelOpositive.TabIndex = 2;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(110, 52);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(74, 28);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "Donors";
			// 
			// lblOpositiveCount
			// 
			this.lblOpositiveCount.AutoSize = true;
			this.lblOpositiveCount.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOpositiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
			this.lblOpositiveCount.Location = new System.Drawing.Point(100, 3);
			this.lblOpositiveCount.Name = "lblOpositiveCount";
			this.lblOpositiveCount.Size = new System.Drawing.Size(94, 59);
			this.lblOpositiveCount.TabIndex = 1;
			this.lblOpositiveCount.Text = "100";
			// 
			// lblOpositive
			// 
			this.lblOpositive.AutoSize = true;
			this.lblOpositive.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOpositive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
			this.lblOpositive.Location = new System.Drawing.Point(1, 10);
			this.lblOpositive.Name = "lblOpositive";
			this.lblOpositive.Size = new System.Drawing.Size(96, 62);
			this.lblOpositive.TabIndex = 0;
			this.lblOpositive.Text = "O+";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.lblOnegativeCount);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.lblOnegative);
			this.panel1.Location = new System.Drawing.Point(268, 81);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 100);
			this.panel1.TabIndex = 3;
			// 
			// lblOnegativeCount
			// 
			this.lblOnegativeCount.AutoSize = true;
			this.lblOnegativeCount.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
			this.lblOnegativeCount.Location = new System.Drawing.Point(100, 2);
			this.lblOnegativeCount.Name = "lblOnegativeCount";
			this.lblOnegativeCount.Size = new System.Drawing.Size(94, 59);
			this.lblOnegativeCount.TabIndex = 1;
			this.lblOnegativeCount.Text = "100";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(114, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 28);
			this.label1.TabIndex = 2;
			this.label1.Text = "Donors";
			// 
			// lblOnegative
			// 
			this.lblOnegative.AutoSize = true;
			this.lblOnegative.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
			this.lblOnegative.Location = new System.Drawing.Point(3, 11);
			this.lblOnegative.Name = "lblOnegative";
			this.lblOnegative.Size = new System.Drawing.Size(82, 62);
			this.lblOnegative.TabIndex = 0;
			this.lblOnegative.Text = "O-";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.Controls.Add(this.lblAnegativeCount);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.lblAnegative);
			this.panel2.Location = new System.Drawing.Point(269, 199);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 100);
			this.panel2.TabIndex = 5;
			// 
			// lblAnegativeCount
			// 
			this.lblAnegativeCount.AutoSize = true;
			this.lblAnegativeCount.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
			this.lblAnegativeCount.Location = new System.Drawing.Point(100, 2);
			this.lblAnegativeCount.Name = "lblAnegativeCount";
			this.lblAnegativeCount.Size = new System.Drawing.Size(94, 59);
			this.lblAnegativeCount.TabIndex = 1;
			this.lblAnegativeCount.Text = "100";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(114, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 28);
			this.label5.TabIndex = 2;
			this.label5.Text = "Donors";
			// 
			// lblAnegative
			// 
			this.lblAnegative.AutoSize = true;
			this.lblAnegative.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
			this.lblAnegative.Location = new System.Drawing.Point(3, 11);
			this.lblAnegative.Name = "lblAnegative";
			this.lblAnegative.Size = new System.Drawing.Size(79, 62);
			this.lblAnegative.TabIndex = 0;
			this.lblAnegative.Text = "A-";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Control;
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.lblApositiveCount);
			this.panel3.Controls.Add(this.lblApositive);
			this.panel3.Location = new System.Drawing.Point(13, 199);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(200, 100);
			this.panel3.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(110, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 28);
			this.label7.TabIndex = 2;
			this.label7.Text = "Donors";
			// 
			// lblApositiveCount
			// 
			this.lblApositiveCount.AutoSize = true;
			this.lblApositiveCount.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblApositiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
			this.lblApositiveCount.Location = new System.Drawing.Point(100, 3);
			this.lblApositiveCount.Name = "lblApositiveCount";
			this.lblApositiveCount.Size = new System.Drawing.Size(94, 59);
			this.lblApositiveCount.TabIndex = 1;
			this.lblApositiveCount.Text = "100";
			// 
			// lblApositive
			// 
			this.lblApositive.AutoSize = true;
			this.lblApositive.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblApositive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
			this.lblApositive.Location = new System.Drawing.Point(1, 10);
			this.lblApositive.Name = "lblApositive";
			this.lblApositive.Size = new System.Drawing.Size(93, 62);
			this.lblApositive.TabIndex = 0;
			this.lblApositive.Text = "A+";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.Control;
			this.panel4.Controls.Add(this.lblABnegativeCount);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.lblABnegative);
			this.panel4.Location = new System.Drawing.Point(270, 439);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(200, 100);
			this.panel4.TabIndex = 9;
			// 
			// lblABnegativeCount
			// 
			this.lblABnegativeCount.AutoSize = true;
			this.lblABnegativeCount.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblABnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
			this.lblABnegativeCount.Location = new System.Drawing.Point(100, 2);
			this.lblABnegativeCount.Name = "lblABnegativeCount";
			this.lblABnegativeCount.Size = new System.Drawing.Size(94, 59);
			this.lblABnegativeCount.TabIndex = 1;
			this.lblABnegativeCount.Text = "100";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(114, 53);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(74, 28);
			this.label11.TabIndex = 2;
			this.label11.Text = "Donors";
			// 
			// lblABnegative
			// 
			this.lblABnegative.AutoSize = true;
			this.lblABnegative.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblABnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
			this.lblABnegative.Location = new System.Drawing.Point(3, 11);
			this.lblABnegative.Name = "lblABnegative";
			this.lblABnegative.Size = new System.Drawing.Size(109, 62);
			this.lblABnegative.TabIndex = 0;
			this.lblABnegative.Text = "AB-";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.Control;
			this.panel5.Controls.Add(this.label13);
			this.panel5.Controls.Add(this.lblABpositiveCount);
			this.panel5.Controls.Add(this.lblABpositive);
			this.panel5.Location = new System.Drawing.Point(14, 439);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(200, 100);
			this.panel5.TabIndex = 8;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(110, 52);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(74, 28);
			this.label13.TabIndex = 2;
			this.label13.Text = "Donors";
			// 
			// lblABpositiveCount
			// 
			this.lblABpositiveCount.AutoSize = true;
			this.lblABpositiveCount.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblABpositiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
			this.lblABpositiveCount.Location = new System.Drawing.Point(100, 3);
			this.lblABpositiveCount.Name = "lblABpositiveCount";
			this.lblABpositiveCount.Size = new System.Drawing.Size(94, 59);
			this.lblABpositiveCount.TabIndex = 1;
			this.lblABpositiveCount.Text = "100";
			// 
			// lblABpositive
			// 
			this.lblABpositive.AutoSize = true;
			this.lblABpositive.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblABpositive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
			this.lblABpositive.Location = new System.Drawing.Point(1, 10);
			this.lblABpositive.Name = "lblABpositive";
			this.lblABpositive.Size = new System.Drawing.Size(123, 62);
			this.lblABpositive.TabIndex = 0;
			this.lblABpositive.Text = "AB+";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.SystemColors.Control;
			this.panel6.Controls.Add(this.lblBnegativeCount);
			this.panel6.Controls.Add(this.label17);
			this.panel6.Controls.Add(this.lblBnegative);
			this.panel6.Location = new System.Drawing.Point(269, 321);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(200, 100);
			this.panel6.TabIndex = 7;
			// 
			// lblBnegativeCount
			// 
			this.lblBnegativeCount.AutoSize = true;
			this.lblBnegativeCount.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
			this.lblBnegativeCount.Location = new System.Drawing.Point(100, 2);
			this.lblBnegativeCount.Name = "lblBnegativeCount";
			this.lblBnegativeCount.Size = new System.Drawing.Size(94, 59);
			this.lblBnegativeCount.TabIndex = 1;
			this.lblBnegativeCount.Text = "100";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(114, 53);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(74, 28);
			this.label17.TabIndex = 2;
			this.label17.Text = "Donors";
			// 
			// lblBnegative
			// 
			this.lblBnegative.AutoSize = true;
			this.lblBnegative.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
			this.lblBnegative.Location = new System.Drawing.Point(3, 11);
			this.lblBnegative.Name = "lblBnegative";
			this.lblBnegative.Size = new System.Drawing.Size(76, 62);
			this.lblBnegative.TabIndex = 0;
			this.lblBnegative.Text = "B-";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.SystemColors.Control;
			this.panel7.Controls.Add(this.label19);
			this.panel7.Controls.Add(this.lblBpositiveCount);
			this.panel7.Controls.Add(this.lblBpositive);
			this.panel7.Location = new System.Drawing.Point(13, 321);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(200, 100);
			this.panel7.TabIndex = 6;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(110, 52);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(74, 28);
			this.label19.TabIndex = 2;
			this.label19.Text = "Donors";
			// 
			// lblBpositiveCount
			// 
			this.lblBpositiveCount.AutoSize = true;
			this.lblBpositiveCount.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBpositiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
			this.lblBpositiveCount.Location = new System.Drawing.Point(100, 3);
			this.lblBpositiveCount.Name = "lblBpositiveCount";
			this.lblBpositiveCount.Size = new System.Drawing.Size(94, 59);
			this.lblBpositiveCount.TabIndex = 1;
			this.lblBpositiveCount.Text = "100";
			// 
			// lblBpositive
			// 
			this.lblBpositive.AutoSize = true;
			this.lblBpositive.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBpositive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
			this.lblBpositive.Location = new System.Drawing.Point(1, 10);
			this.lblBpositive.Name = "lblBpositive";
			this.lblBpositive.Size = new System.Drawing.Size(90, 62);
			this.lblBpositive.TabIndex = 0;
			this.lblBpositive.Text = "B+";
			// 
			// dgvDonors
			// 
			this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDonors.Location = new System.Drawing.Point(515, 134);
			this.dgvDonors.Name = "dgvDonors";
			this.dgvDonors.RowHeadersWidth = 51;
			this.dgvDonors.RowTemplate.Height = 24;
			this.dgvDonors.Size = new System.Drawing.Size(695, 405);
			this.dgvDonors.TabIndex = 10;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(510, 81);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(135, 28);
			this.lblSearch.TabIndex = 11;
			this.lblSearch.Text = "Search Donor";
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(666, 81);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(544, 34);
			this.txtSearch.TabIndex = 12;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
			this.pictureBoxClose.Location = new System.Drawing.Point(1207, 0);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(42, 39);
			this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxClose.TabIndex = 13;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
			// 
			// lblUserTitle
			// 
			this.lblUserTitle.AutoSize = true;
			this.lblUserTitle.Location = new System.Drawing.Point(14, 53);
			this.lblUserTitle.Name = "lblUserTitle";
			this.lblUserTitle.Size = new System.Drawing.Size(96, 17);
			this.lblUserTitle.TabIndex = 14;
			this.lblUserTitle.Text = "Logged In As : ";
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.ForeColor = System.Drawing.Color.LimeGreen;
			this.lblUser.Location = new System.Drawing.Point(116, 53);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(11, 17);
			this.lblUser.TabIndex = 15;
			this.lblUser.Text = ".";
			// 
			// frmHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1255, 616);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.lblUserTitle);
			this.Controls.Add(this.pictureBoxClose);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.dgvDonors);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelOpositive);
			this.Controls.Add(this.panelFooter);
			this.Controls.Add(this.menuStripTop);
			this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStripTop;
			this.Name = "frmHome";
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Home";
			this.Activated += new System.EventHandler(this.frmHome_Activated);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStripTop.ResumeLayout(false);
			this.menuStripTop.PerformLayout();
			this.panelFooter.ResumeLayout(false);
			this.panelFooter.PerformLayout();
			this.panelOpositive.ResumeLayout(false);
			this.panelOpositive.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripTop;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem donorsToolStripMenuItem;
		private System.Windows.Forms.Panel panelFooter;
		private System.Windows.Forms.Label lblAppName;
		private System.Windows.Forms.Label lblDeveloper;
		private System.Windows.Forms.Label lblDevTitel;
		private System.Windows.Forms.Panel panelOpositive;
		private System.Windows.Forms.Label lblOpositive;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblOpositiveCount;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblOnegativeCount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblOnegative;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblAnegativeCount;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblAnegative;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblApositiveCount;
		private System.Windows.Forms.Label lblApositive;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label lblABnegativeCount;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lblABnegative;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lblABpositiveCount;
		private System.Windows.Forms.Label lblABpositive;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label lblBnegativeCount;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label lblBnegative;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label lblBpositiveCount;
		private System.Windows.Forms.Label lblBpositive;
		private System.Windows.Forms.DataGridView dgvDonors;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Label lblUserTitle;
		private System.Windows.Forms.Label lblUser;
	}
}

