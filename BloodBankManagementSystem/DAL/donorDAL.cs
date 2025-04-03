using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using BloodBankManagementSystem.BLL;
using System.Linq.Expressions;



namespace BloodBankManagementSystem.DAL
{
	internal class donorDAL
	{
		// Create a connection string to connect Database
		static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

		#region SELECT to display data in data grid view from database
		public DataTable Select()
		{
			// Create object of datatable to hold the data from database and return it
			DataTable dt = new DataTable();

			// Create object of sql connection to connect database
			SqlConnection conn = new SqlConnection(myconnstrng);

			try
			{
				// Write SQL Query to select data from database
				string sql = "SELECT * FROM tbl_donors";

				// Create sql command to execute query
				SqlCommand cmd = new SqlCommand(sql, conn);

				// Create sql data adapter to hold the data temporarily
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				// Open the database connection
				conn.Open();

				// Pass the data from adapter to datatable
				adapter.Fill(dt);

			}
			catch (Exception ex)
			{
				// Display message if there is any exceptional errors
				MessageBox.Show(ex.Message);

			}
			finally
			{
				// Close the database connection
				conn.Close();
			}

			return dt;

		}
		#endregion
		#region INSERT data in database
		public bool Insert(donorBLL d)
		{
			// Create a boolean variable and set its default value to false
			bool isSuccess = false;

			// Create SQL connection to connect database
			SqlConnection conn = new SqlConnection(myconnstrng);

			try
			{
				// Write the query to insert data into database
				string sql = "INSERT INTO tbl_donors (first_name, last_name, email, contact, gender, address, blood_group, added_date, image_name,added_by) VALUES (@first_name, @last_name, @email, @contact, @gender, @address, @blood_group, @added_date, @image_name,@added_by)";

				// Create SQl command to execute the query
				SqlCommand cmd = new SqlCommand(sql, conn);

				// Pass the value to the query 
				cmd.Parameters.AddWithValue("@first_name", d.first_name);
				cmd.Parameters.AddWithValue("@last_name", d.last_name);
				cmd.Parameters.AddWithValue("@email", d.email);
				cmd.Parameters.AddWithValue("@contact", d.contact);
				cmd.Parameters.AddWithValue("@gender", d.gender);
				cmd.Parameters.AddWithValue("@address", d.address);
				cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
				cmd.Parameters.AddWithValue("@added_date", d.added_date);
				cmd.Parameters.AddWithValue("@image_name", d.image_name);
				cmd.Parameters.AddWithValue("@added_by", d.added_by);

				// Open the database connection
				conn.Open();

				// Create an integer variable to check if the query was executed successfully or not
				int rows = cmd.ExecuteNonQuery();

				// If the query is executed successfully then the value of rows will be greater than 0 else it will be 0
				if (rows > 0)
				{
					// Query executed successfully
					isSuccess = true;
				}
				else
				{
					// Failed to execute query
					isSuccess = false;
				}


			}
			catch (Exception ex)
			{
				// Display message if there is any exceptional errors
				MessageBox.Show(ex.Message);

			}
			finally
			{
				// Close the database connection
				conn.Close();

			}


			return isSuccess;

		}

		#endregion
		#region UPDATE data in database
		public bool Update(donorBLL d)
		{
			// Create a boolean variable and set its default value to false
			bool isSuccess = false;

			// Create SQL connection to connect database
			SqlConnection conn = new SqlConnection(myconnstrng);

			try
			{
				// Create a SQL query to update donors
				string sql = "UPDATE tbl_donors SET first_name=@first_name, last_name=@last_name, email=@email, contact=@contact, gender=@gender, address=@address, blood_group=@blood_group, image_name=@image_name, added_by=@added_by WHERE donor_id=@donor_id";

				// Create SQL command to execute the query
				SqlCommand cmd = new SqlCommand(sql, conn);

				// Pass the value to the query
				cmd.Parameters.AddWithValue("@first_name", d.first_name);
				cmd.Parameters.AddWithValue("@last_name", d.last_name);
				cmd.Parameters.AddWithValue("@email", d.email);
				cmd.Parameters.AddWithValue("@contact", d.contact);
				cmd.Parameters.AddWithValue("@gender", d.gender);
				cmd.Parameters.AddWithValue("@address", d.address);
				cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
				cmd.Parameters.AddWithValue("@image_name", d.image_name);
				cmd.Parameters.AddWithValue("@added_by", d.added_by);
				cmd.Parameters.AddWithValue("@donor_id", d.donor_id);


				// Open the database connection
				conn.Open();

				// Create an integer variable to check if the query was executed successfully or not
				int rows = cmd.ExecuteNonQuery();

				// If the query is executed successfully then the value of rows will be greater than 0 else it will be 0
				if (rows > 0)
				{
					// Query executed successfully
					isSuccess = true;
				}
				else
				{
					// Failed to execute query
					isSuccess = false;
				}


			}
			catch (Exception ex)
			{
				// Display message if there is any exceptional errors
				MessageBox.Show(ex.Message);
			}
			finally
			{
				// Close the database connection
				conn.Close();
			}

			return isSuccess;

		}
		#endregion
		#region DELETE donors from database
		public bool Delete(donorBLL d)
		{
			// Create a boolean variable and set its default value to false
			bool isSuccess = false;

			// Create SQL connection to connect database
			SqlConnection conn = new SqlConnection(myconnstrng);

			try
			{
				// Create a SQL query to delete donors from database
				string sql = "DELETE FROM tbl_donors WHERE donor_id=@donor_id";

				// Create SQL command to execute the query
				SqlCommand cmd = new SqlCommand(sql, conn);

				// Pass the value to the query using parameters
				cmd.Parameters.AddWithValue("@donor_id", d.donor_id);

				// Open the database connection
				conn.Open();

				// Create an integer variable to check if the query was executed successfully or not
				int rows = cmd.ExecuteNonQuery();

				// If the query is executed successfully then the value of rows will be greater than 0 else it will be 0
				if (rows > 0)
				{
					// Query executed successfully
					isSuccess = true;
				}
				else
				{
					// Failed to execute query
					isSuccess = false;

				}
			}
			catch (Exception ex)
			{
				// Display message if there is any exceptional errors
				MessageBox.Show(ex.Message);
			}
			finally
			{
				// Close the database connection
				conn.Close();
			}

			return isSuccess;
		}
		#endregion

		#region Count donors for specefic blood group

		public string countDonors(string blood_group)
		{
			// Create SQL connection to connect database
			SqlConnection conn = new SqlConnection(myconnstrng);

			// Create a string variable for donor count and set its default value to 0
			string donors = "0";

			try
			{
				// SQL query to count donors for specific blood group
				string sql = "SELECT * FROM tbl_donors WHERE blood_group='" + blood_group + "'";

				// SQl command to execute the query
				SqlCommand cmd = new SqlCommand(sql, conn);

				// Create SQL data adapter to get the data from database
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				// Create a datatable to hold the data temporarily
				DataTable dt = new DataTable();

				// pass the data from adapter to datatable
				adapter.Fill(dt);

				// Get the total number of donors based on blood group
				donors = dt.Rows.Count.ToString();



			}
			catch (Exception ex)
			{
				// Display message if there is any exceptional errors
				MessageBox.Show(ex.Message);
			}
			finally
			{
				// Close the database connection
				conn.Close();
			}

			return donors;
			
		}
		#endregion

		#region Method to search donors 
		public DataTable Search(string keywords)
		{

			// 1. SQL Connection to connect database
			SqlConnection conn = new SqlConnection(myconnstrng);

			// 2. Create a datatable to hold the data from database temporarily
			DataTable dt = new DataTable();

			try
			{
				// Write the code search donors based on keywords typed on textbox
				// SQL Query to search donors
				string sql = "SELECT * FROM tbl_donors WHERE donor_id LIKE '%"+ keywords + "%' OR first_name LIKE '%" + keywords + "%' OR last_name LIKE '"+ keywords+"' OR email LIKE '%"+ keywords + "%' OR blood_group LIKE '"+keywords+"'";

				// Create SQL command to execute the query
				SqlCommand cmd = new SqlCommand(sql, conn);

				// SQL Data adapter to save data from database
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				// OPEN the database connection
				conn.Open();

				// Transfer data from SQL data adapter to datatable
				adapter.Fill(dt);


			}
			catch (Exception ex)
			{
				// Display message if there is any exceptional errors
				MessageBox.Show(ex.Message);
			}
			finally
			{
				// Close the database connection
				conn.Close();
			}

			return dt;

		}

		#endregion
	}
}




