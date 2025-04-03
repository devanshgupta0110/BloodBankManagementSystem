using BloodBankManagementSystem.BLL;
using BloodBankManagementSystem.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
	public partial class frmUsers : Form
	{
		public frmUsers()
		{
			InitializeComponent();
		}

		// Create Objects of userBLL and userDAL
		userBLL u = new userBLL();
		userDAL dal = new userDAL();

		string imageName = "no-image.jpg";
		string sourcePath = "";
		string destinationPath = "";


		// Global variable for image to delete
		string rowHeaderImage;


		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			// Add functionality to close this form
			this.Hide();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			// Step1 : Get the values from UI
			u.full_name = txtFullName.Text;
			u.email = txtEmail.Text;
			u.username = txtUserName.Text;
			u.password = txtPassword.Text;
			u.contact = txtContact.Text;
			u.address = txtAddress.Text;
			u.added_date = DateTime.Now;
			u.image_name = imageName;

			


			// Check whether the user has selected an image or not
			if (imageName != "no-image.jpg")
			{
				// User has selected an image
				File.Copy(sourcePath, destinationPath);
			}

			// Step2 : Adding the values from the UI to the DB
			// Create a Boolean variable to check weather the data is inserted successfully or not
			bool success = dal.Insert(u);

			// Step3 : Check weather the data is inserted successfully or not 
			if (success == true)
			{
				//Data or User Added Successfully
				MessageBox.Show("New User added Successfully");

				// Display the user in Data Grid View
				DataTable dt = dal.Select();
				dgvUsers.DataSource = dt;

				// Clear the text boxes
				Clear();


			}
			else
			{
				// Failed to Add User
				MessageBox.Show("Failed to add new user");
			}
		}

		// Function to clear text boxes
		public void Clear()
		{
			txtUserID.Text = "";
			txtFullName.Text = "";
			txtEmail.Text = "";
			txtUserName.Text = "";
			txtPassword.Text = "";
			txtContact.Text = "";
			txtAddress.Text = "";
			txtUserID.Text = "";

			// Display the image of the selected user
			// Get the image path
			string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);

			// Path to the destination folder
			string imagePath = paths + "\\images\\no-image.jpg";

			// Display the image in the picture box
			PictureBoxProfilePicture.Image = new Bitmap(imagePath);

		}

		private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			// Find the Row index of the row clicked on the Data Grid View
			int rowIndex = e.RowIndex;
			txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
			txtUserName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
			txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
			txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
			txtFullName.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
			txtContact.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
			txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
			imageName = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();

			// Update the value of global variable rowHeader image
			rowHeaderImage = imageName;


			// Display the image of the selected user
			// Get the image path
			string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);

			if(imageName != "no-image.jpg")
			{
				// Path to the destination folder
				string imagePath = paths + "\\images\\" + imageName;

				// Display the image in the picture box
				PictureBoxProfilePicture.Image = new Bitmap(imagePath);

			}
			else
			{
				// Path to the destination folder
				string imagePath = paths + "\\images\\no-image.jpg";

				// Display the image in the picture box
				PictureBoxProfilePicture.Image = new Bitmap(imagePath);
			}

		}

		private void frmUsers_Load(object sender, EventArgs e)
		{
			// Display the users in Data Grid View when the form is loaded
			DataTable dt = dal.Select();
			dgvUsers.DataSource = dt;

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			// Step1 : Get the values from UI
			u.user_id = int.Parse(txtUserID.Text);
			u.full_name = txtFullName.Text;
			u.email = txtEmail.Text;
			u.username = txtUserName.Text;
			u.password = txtPassword.Text;
			u.contact = txtContact.Text;
			u.address = txtAddress.Text;
			u.added_date = DateTime.Now;
			u.image_name = imageName;

			// Upload new image 
			// Check whether the user has selected an image or not
			if (imageName != "no-image.jpg")
			{
				// User has selected an image
				File.Copy(sourcePath, destinationPath);
			}




			// Step2: Create a Boolean variable to check weather the data is updated successfully or not
			bool success = dal.Update(u);

			// Remove the previous image

			if (rowHeaderImage != "no-image.jpg")
			{
				// Path of the project folder
				string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
				// Give the path of the image folder
				string imagePath = paths + "\\images\\" + rowHeaderImage;

				// Clear function to clear the text boxes and picture box
				Clear();


				// Call Garbage collection function
				GC.Collect();
				GC.WaitForPendingFinalizers();



				// Delete the physical file of the user profile
				File.Delete(imagePath);




			}

			// Let's check weather the data is updated or not
			if (success == true)
			{
				// Data Updated Successfully
				MessageBox.Show("User Updated Successfully");

				// Refresh Data Grid View
				DataTable dt = dal.Select();
				dgvUsers.DataSource = dt;

				// Clear the text boxes
				Clear();


			}

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			// Step1 : Get the User ID from the text box
			u.user_id = int.Parse(txtUserID.Text);

			// Remove the physical file of the user profile 
			if (rowHeaderImage != "no-image.jpg")
			{
				// Path of the project folder
				string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
				// Give the path of the image folder
				string imagePath = paths + "\\images\\" + rowHeaderImage;

				// Clear function to clear the text boxes and picture box
				Clear();


				// Call Garbage collection function
				GC.Collect();
				GC.WaitForPendingFinalizers();



				// Delete the physical file of the user profile
				File.Delete(imagePath);




			}

			// Step2 : Create a Boolean variable to check weather the data is deleted successfully or not
			bool success = dal.Delete(u);

			// Let's check weather the data is deleted or not
			if (success == true)
			{
				// User Data Deleted Successfully
				MessageBox.Show("User Deleted Successfully");
				// Refresh Data Grid View
				DataTable dt = dal.Select();
				dgvUsers.DataSource = dt;
				// Clear the text boxes
				Clear();

			}

		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			//Call the user function to clear the text boxes
			Clear();
		}

		private void btnSelectImage_Click(object sender, EventArgs e)
		{
			// Write the code to upload the image of the user
			// Open the Dialog Box to select the image

			OpenFileDialog open = new OpenFileDialog();

			// Filter the file type, only allow image file types
			open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

			// Check if the file is selected or not
			if (open.ShowDialog() == DialogResult.OK)
			{
				// Check if the file exists or not
				if (open.CheckFileExists)
				{
					// Display the selected image in the picture box
					PictureBoxProfilePicture.Image = new Bitmap(open.FileName);

					// Rename the selected image
					// Step1 : Get the extension of the image
					string ext = Path.GetExtension(open.FileName);

					// Step2 : Generate Random Integer
					Random random = new Random();

					int RandInt = random.Next(0, 1000);

					// Step3 : Rename the image
					imageName = "Blood_Bank_MS_" + RandInt + ext;

					// Step4 : Get the path of the selected image
					sourcePath = open.FileName;

					// Step5 : Get the path of the destination
					string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);

					// Paths to destination	folder
					destinationPath = paths + "\\images\\" + imageName;

					// Step6 : Copy the image to the destination folder
					//File.Copy(sourcePath, destinationPath);

					// Step 7 : Display the message that the image is uploaded successfully
					//MessageBox.Show("Image Uploaded Successfully");

				}
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			// Write the code to get the users based on the keywords
			// 1: Get the keywords from the text box

			String keywords = txtSearch.Text;

			//Check wheather the textbox is empty or not
			if (keywords != null)
			{
				//Textbox is not empty, display the users on data grid view based on keywords
				DataTable dt = dal.Search(keywords);
				dgvUsers.DataSource = dt;


			}
			else
			{
				//Textbox is empty and display all the users on data grid view 
				DataTable dt = dal.Select();
				dgvUsers.DataSource = dt;

			}
		}
	}
}
