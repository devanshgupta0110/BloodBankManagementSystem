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
using System.IO;
using BloodBankManagementSystem.DLL;


namespace BloodBankManagementSystem.UI
{
	public partial class frmDonors : Form
	{
		public frmDonors()
		{
			InitializeComponent();
		}

		// Create an object of donorBLL and donorDAL
		donorBLL d = new donorBLL();
		donorDAL dal = new donorDAL();
		userDAL udal = new userDAL();


		// Create global variable for image
		string imageName = "no-image.jpg";
		string sourcePath = "";
		string destinationPath = "";


		string rowHeaderImage;

		private void frmDonors_Load(object sender, EventArgs e)
		{
			// Display donors in data grid view
			DataTable dt = dal.Select();
			dgvDonors.DataSource = dt;

			// First we need to get the path of no-image.jpg
			string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);

			string imagePath = path + "\\images\\no-image.jpg";

			// Display the image in the picture box
			PictureBoxProfilePicture.Image = new Bitmap(imagePath);
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			// Close this form
			this.Hide();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			// Write the code to add new donor

			// Step1 : Get the values from Manage Donors Form
			d.first_name = txtFirstName.Text;
			d.last_name = txtLastName.Text;
			d.email = txtEmail.Text;
			d.gender = cmbGender.Text;
			d.blood_group = cmbBloodGroup.Text;
			d.contact = txtContact.Text;
			d.address = txtAddress.Text;
			d.added_date = DateTime.Now;

			// Get the ID of logged in user
			string loggedInUser = frmLogin.loggedInUser;
			userBLL usr = udal.GetIDFromUsername(loggedInUser);



			d.added_by = usr.user_id; 

			d.image_name = imageName;

			// Upload Image
			// Check wheather the user has selected an image or not
			if(imageName != "no-image.jpg")
			{
				// Upload the image
				File.Copy(sourcePath, destinationPath);

			}


			// Step 2 : Insert data into database
			// Cretae a boolean variable to check if the data is inserted successfully

			bool isSuccess = dal.Insert(d);

			// If the data is inserted successfully then the value of isSuccess will be true else it will be false
			if (isSuccess == true)
			{
				// Data inserted successfully
				MessageBox.Show("New Donor Added Successfully");

				// Refresh the data grid view
				DataTable dt = dal.Select();
				dgvDonors.DataSource = dt;

				// Clear all the textboxes
				Clear();
			}
			else
			{
				// Failed to insert data
				MessageBox.Show("Failed to Add New Donor.");
			}
		}

		// Create a method to clear all the textboxes
		public void Clear()
		{
			txtFirstName.Text = "";
			txtLastName.Text = "";
			txtEmail.Text = "";
			txtDonorID.Text = "";
			cmbGender.Text = "";
			cmbBloodGroup.Text = "";
			txtContact.Text = "";
			txtAddress.Text = "";
			imageName = "no-image.jpg";




			// Clear the picture box
			// First we need to get the path of no-image.jpg
			string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);

			string imagePath = path + "\\images\\no-image.jpg";

			// Display the image in the picture box
			PictureBoxProfilePicture.Image = new Bitmap(imagePath);
		}

		private void dgvDonors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			// Select the data from data grid view and display it in our form

			// 1. Find the row selected
			int rowIndex = e.RowIndex;

			txtDonorID.Text = dgvDonors.Rows[rowIndex].Cells[0].Value.ToString();
			txtFirstName.Text = dgvDonors.Rows[rowIndex].Cells[1].Value.ToString();
			txtLastName.Text = dgvDonors.Rows[rowIndex].Cells[2].Value.ToString();
			txtEmail.Text = dgvDonors.Rows[rowIndex].Cells[3].Value.ToString();
			txtContact.Text = dgvDonors.Rows[rowIndex].Cells[4].Value.ToString();
			cmbGender.Text = dgvDonors.Rows[rowIndex].Cells[5].Value.ToString();
			txtAddress.Text = dgvDonors.Rows[rowIndex].Cells[6].Value.ToString();
			cmbBloodGroup.Text = dgvDonors.Rows[rowIndex].Cells[7].Value.ToString();


			imageName = dgvDonors.Rows[rowIndex].Cells[9].Value.ToString();

			// Update the value of rowHeaderImage
			rowHeaderImage = imageName;

			// Display the image of the selected donor
			// Get the image path
			string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);

			string imagePath = paths + "\\images\\" + imageName;

			// Display the image in the picture box of the user
			PictureBoxProfilePicture.Image = new Bitmap(imagePath);


		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			// Add the functionality to update the donor
			// Get the values from the form
			d.donor_id = int.Parse(txtDonorID.Text);
			d.first_name = txtFirstName.Text;
			d.last_name = txtLastName.Text;
			d.email = txtEmail.Text;
			d.gender = cmbGender.Text;
			d.blood_group = cmbBloodGroup.Text;
			d.contact = txtContact.Text;
			d.address = txtAddress.Text;

			// Get the ID of logged in user
			string loggedInUser = frmLogin.loggedInUser;
			userBLL usr = udal.GetIDFromUsername(loggedInUser);



			d.added_by = usr.user_id;

			d.image_name = imageName;


			// Upload new image
			// Upload Image
			// Check wheather the user has selected an image or not
			if (imageName != "no-image.jpg")
			{
				// Upload the image
				File.Copy(sourcePath, destinationPath);

			}
			// Create a Boolean variable to check if the data is updated successfully or not
			bool isSuccess = dal.Update(d);

			// Remove the previous image
			// Check wheather the donor has profile picture or not
			if (rowHeaderImage != "no-image.jpg")
			{
				// Only runs if the user has image
				// Get the path to root folder of the project
				string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);

				// Get the path of the image
				string imagePath = path + "\\images\\" + rowHeaderImage;

				// Call clear function
				Clear();

				// Call Garbage collection function
				GC.Collect();
				GC.WaitForPendingFinalizers();

				// Delete the physical image file of the donor
				File.Delete(imagePath);


			}

			// If the data is updated successfully then the value of isSuccess will be true else it will be false
			if (isSuccess == true)
			{

				// Donor updated successfully
				MessageBox.Show("Donor Updated Successfully");
				Clear();

				// Refresh the data grid view
				DataTable dt = dal.Select();
				dgvDonors.DataSource = dt;

			}
			else
			{
				// Failed to update donor
				MessageBox.Show("Failed to Update Donor");

			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			// Get the value from form
			d.donor_id = int.Parse(txtDonorID.Text);

			// Check wheather the donor has profile picture or not
			if (rowHeaderImage != "no-image.jpg")
			{
				// Only runs if the user has image
				// Get the path to root folder of the project
				string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);

				// Get the path of the image
				string imagePath = path + "\\images\\" + rowHeaderImage;

				// Call clear function
				Clear();

				// Call Garbage collection function
				GC.Collect();
				GC.WaitForPendingFinalizers();

				// Delete the physical image file of the donor
				File.Delete(imagePath);


			}


			// Cretae a boolean variable to check if the donor deleted or not
			bool isSuccess = dal.Delete(d);
			if (isSuccess == true)
			{
				// Donor deleted successfully
				MessageBox.Show("Donor Deleted Successfully");
				Clear();

				// Refresh the data grid view
				DataTable dt = dal.Select();
				dgvDonors.DataSource = dt;
			}
			else
			{
				// Failed to delete donor
				MessageBox.Show("Failed to Delete Donor");
			}

		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			// Clear all the textboxes
			Clear();

		}

		private void btnSelectImage_Click(object sender, EventArgs e)
		{
			// Code to select image and upload 
			// Open the Dialog Box to select the image
			OpenFileDialog open = new OpenFileDialog();


			// 2. Filter the file type (allow only image files)
			open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

			// 3. Check wheather the file is selected or not
			if(open.ShowDialog() == DialogResult.OK)
			{

				// Check if the file exists or not

				if (open.CheckFileExists)
				{
					// Display the selected image in the picture box
					PictureBoxProfilePicture.Image = new Bitmap(open.FileName);

					// Rename the selected image
					// Step1 : Get the extension of the image
					string ext = Path.GetExtension(open.FileName);

					string name = Path.GetFileNameWithoutExtension(open.FileName);

					// Generate Random but Globally Unique Identifier
					Guid g = new Guid();

					g = Guid.NewGuid();

					// Finally rename the image
					imageName = "Blood_Bank_MS" + name + g +  ext;

					// Get the source path (Path of image)
				    sourcePath = open.FileName;

					// Get the destination path
					string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
					// Path to destination
					destinationPath = paths + "\\images\\" + imageName;

					// Upload the image to destination folder
					//File.Copy(sourcePath, destinationPath);

					// Display message after the image is uploaded
					//MessageBox.Show("Image Uploaded Successfully");
				}

			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			// Lets all the functionality to search the donors

			// 1. Get the keywords typed on the search textbox
			string keywords = txtSearch.Text;

			// Check wheather the Search textbox is empty or not
			if (keywords != null)
			{
				// Show donors based on keywords
				DataTable dt = dal.Search(keywords);
				dgvDonors.DataSource = dt;
			}
			else
			{
				// Show all the donors from the database
				DataTable dt = dal.Select();
				dgvDonors.DataSource = dt;
			}
		}
	}
}
