using BloodBankManagementSystem.BLL;
using BloodBankManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		// Create the object of BLL and DAL
		loginBLL l = new loginBLL();
		loginDAL dal = new loginDAL();

		// Cretae a static string method to save the usename
		public static string loggedInUser;

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			// Write code to close the Application
			this.Close();

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			// Write the code to login our Application

			// Step 1: Get the username and password from the login form
			l.username = txtUsername.Text;
			l.password = txtPassword.Text;


			// Check the Login credentials
			bool isSuccess = dal.loginCheck(l);

			// Check if the login is successful or not
			// if login is successful, then isSuccess will be true else it will be false
			if (isSuccess == true)
			{
				// Login Successfull
				MessageBox.Show("Login Successful.");

				// Save the username in loggedInUser static method
				loggedInUser = l.username;

				// Display the Home Form

				frmHome home = new frmHome();
				home.Show();
				this.Hide(); // To close the login form


			}
			else
			{
				// Login Failed
				// Display the error message
				MessageBox.Show("Login Failed. Try Again.");

			}
		}

		private void txtUsername_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
