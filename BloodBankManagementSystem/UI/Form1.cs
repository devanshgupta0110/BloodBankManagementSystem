using BloodBankManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBankManagementSystem.DAL;


namespace BloodBankManagementSystem
{
	public partial class frmHome : Form
	{
		public frmHome()
		{
			InitializeComponent();
		}

		// Create the object of Donor Dal
		donorDAL dal = new donorDAL();


		private void Form1_Load(object sender, EventArgs e)
		{
			// Load all the blood donors count when form is loaded
			// Call allDonorCount method
			allDonorCount();

			// Display all the donors
			DataTable dt = dal.Select();
			dgvDonors.DataSource = dt;

			// Display the username of logged in user
			lblUser.Text = frmLogin.loggedInUser;


		}

		public void allDonorCount()
		{
			// Get the donor count from DB and set in respective labels
			lblOpositiveCount.Text = dal.countDonors("O+");
			lblOnegativeCount.Text = dal.countDonors("O-");
			lblApositiveCount.Text = dal.countDonors("A+");
			lblAnegativeCount.Text = dal.countDonors("A-");
			lblBpositiveCount.Text = dal.countDonors("B+");
			lblBnegativeCount.Text = dal.countDonors("B-");
			lblABpositiveCount.Text = dal.countDonors("AB+");
			lblABnegativeCount.Text = dal.countDonors("AB-");

		}
		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			// Code to close this application
			this.Hide();
		}

		private void usersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Open Users Form
			frmUsers users = new frmUsers();
			users.Show();

		}

		private void donorsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Open Manage Donors Form
			frmDonors donors = new frmDonors();
			donors.Show();

		}

		private void frmHome_Activated(object sender, EventArgs e)
		{
			// Call allDonorCount method
			allDonorCount();


		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			// Get the keywords from the search text box
			string keywords = txtSearch.Text;


			// Check wheather the textbox is empty or not
			if (keywords != null)
			{
				// Filter the donors based on keywords
				DataTable dt = dal.Search(keywords);
				dgvDonors.DataSource = dt;
			}
			else
			{
				// Display all the donors
				DataTable dt = dal.Select();
				dgvDonors.DataSource = dt;
			}
		}
	}
}
