using BloodBankManagementSystem.BLL;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlTypes;


namespace BloodBankManagementSystem.DLL
{
	internal class userDAL
	{
		// Create a static string method to connect DB
		static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

		#region SELECT data from database
		public DataTable Select()
		{
			// create an object to connect DB
			SqlConnection conn = new SqlConnection(myconnstrng);

			// create a DataTable to Hold the Data from DataBase
			DataTable dt = new DataTable();

			
			try
			{
				// Write SQL Query to get data from DB
				String sql = "SELECT * FROM tbl_users"; 
			
				// Create SQL Command to Execute Query
				SqlCommand cmd = new SqlCommand(sql, conn);

				// Create SQL Data Adapter to hold the data from DB temporarily
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				// Open DB connection
				conn.Open();

				// Transfer Data from SqlData Adapter to DataTable
				adapter.Fill(dt);

			}
			catch (Exception ex)
			{
				//Display Error Messsage if there is any exception errors
				MessageBox.Show(ex.Message);

			}
			finally { 
			
				// Close DB connection
			conn.Close();
			}
			return dt;
		}
		#endregion

		#region Insert Data into DB from User Module


		public bool Insert (userBLL u)
		{
			// create a boolean variable and set its default value to false
			bool isSuccess = false;

			// Create an Object of SQLConnection to connect DB
			SqlConnection conn = new SqlConnection(myconnstrng);

			try
			{
				// Create a string variable to store the query
				String sql = "INSERT INTO tbl_users(username, email, password, full_name, contact, address, added_date, image_name) VALUES (@username, @email, @password, @full_name, @contact, @address, @added_date, @image_name)";

				// Create a SQL command to pass the value in our query
				SqlCommand cmd = new SqlCommand(sql, conn);

				// Create the Parameter to pass or get the value from UI and pass it on SQL Query above
				cmd.Parameters.AddWithValue("@username", u.username);
				cmd.Parameters.AddWithValue("@email", u.email);
				cmd.Parameters.AddWithValue("@password", u.password);
				cmd.Parameters.AddWithValue("@full_name", u.full_name);
				cmd.Parameters.AddWithValue("@contact", u.contact);
				cmd.Parameters.AddWithValue("@address", u.address);
				cmd.Parameters.AddWithValue("@added_date", u.added_date);
				cmd.Parameters.AddWithValue("@image_name", u.image_name);

				// Open DB Connection

				conn.Open();

				// Create an interger variable to hold the value after the query is executed
				int rows = cmd.ExecuteNonQuery();

				// The value of rows will be greater than 0 if the query is executed successfully
				// Else it will be 0
				if (rows > 0)
				{
					isSuccess = true;

				}
				else
				{

					isSuccess = false;
				}

			}
			catch (Exception ex)
			{
				// Display Error Message if there is any exceptional errors
				MessageBox.Show (ex.Message);
			}

			finally
			{
				// Close DB connection
				conn.Close();
			}
			return isSuccess;
		}
		#endregion

		#region UPDATE data in database (User Module)

		public bool Update(userBLL u)
		{
			bool isSuccess = false;

			// Create an object for DB connection
			SqlConnection conn = new SqlConnection(myconnstrng);

			try
			{
				// Create a string variable to hold the SQL Query
				string sql = "UPDATE tbl_users SET username=@username, email=@email ,password=@password , full_name=@full_name , contact=@contact , address=@address , added_date=@added_date , image_name=@image_name WHERE user_id=@user_id";

				// Create a SQL Command to execute query and also pass the values to sql query
				SqlCommand cmd = new SqlCommand(sql, conn);

				// Pass the value to SQL Query
				cmd.Parameters.AddWithValue("@username", u.username);
				cmd.Parameters.AddWithValue("@email", u.email);
				cmd.Parameters.AddWithValue("@password", u.password);
				cmd.Parameters.AddWithValue("@full_name", u.full_name);
				cmd.Parameters.AddWithValue("@contact", u.contact);
				cmd.Parameters.AddWithValue("@address", u.address);
				cmd.Parameters.AddWithValue("@added_date", u.added_date);
				cmd.Parameters.AddWithValue("@image_name", u.image_name);
				cmd.Parameters.AddWithValue("@user_id", u.user_id);

				// Open DB Connection
				conn.Open();


				// Create an integer variable to hold the value after the query is executed
				int rows = cmd.ExecuteNonQuery();

				// If the query is executed successfully the value of rows will be greater than 0 
				// Else it will be 0

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
				// Display error message of there is any exception error
				MessageBox.Show(ex.Message);


			}
			finally
			{
				// Close DB Connection
				conn.Close();
			}

			return isSuccess;

		}
		#endregion

		#region Delete Data from DB (User Module)
		public bool Delete(userBLL u)
		{
			// Create a boolean variable and set its default value to false

			bool isSuccess = false;

			// Create an object for SqlConnection
			SqlConnection conn = new SqlConnection(myconnstrng);

			try
			{
				// Create a string variable to hold the sql query to delete data
				String sql = "DELETE FROM tbl_users WHERE user_id=@user_id";

				// Create Sql command to execute the query
				SqlCommand cmd = new SqlCommand(sql, conn);

				// Pass the value through parameters
				cmd.Parameters.AddWithValue("@user_id", u.user_id);

				// Open DB Connection
				conn.Open();


				// Create an integer variable to hold the value after query is executed
				int rows = cmd.ExecuteNonQuery();

				// If the query is executed successfully the value of rows will be greater than 0 
				// Else it will be 0
				if (rows > 0)
				{
					// Query executed Successfully
					isSuccess = true;
				}
				else
				{
					// Failed to execute Query
					isSuccess = false;
				}

	}
			catch (Exception ex)
			{
				// Display Error Message if there is any exception errors
				MessageBox .Show(ex.Message);

			}
			finally
			{
				// Close DB Connection
		       conn.Close();

			}


			return isSuccess;
		}


		#endregion

		#region SEARCH

		public DataTable Search (string keywords)
		{
			// 1. Create a SQL Connection to connect DB
			SqlConnection conn = new SqlConnection(myconnstrng);

			// 2. Create a DataTable to hold the data from DB temporarily
			DataTable dt = new DataTable();

			

			// Write the code to search users
			try
			{
				//  Write the SQL Query to search users from DB
				String sql = "SELECT * FROM tbl_users WHERE user_id LIKE '%" + keywords + "%' OR full_name LIKE '%" + keywords + "%' OR address LIKE '%" + keywords + "%'";

				// Create SQL Command to Execute the Query
				SqlCommand cmd = new SqlCommand(sql, conn);

				// Create SQL Data Adapter to hold the data from DB temporarily
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				// Open DB Connection
				conn.Open();

				// Transfer the data from SqlData Adapter to DataTable
				adapter.Fill(dt);



			}
			catch (Exception ex)
			{
				// Display Error Message if there is any exception errors
				MessageBox.Show(ex.Message);
			}
			finally
			{
				// Close DB Connection
				conn.Close();
			}

			return dt;

		}
		#endregion

		#region
		public userBLL GetIDFromUsername(string username)
		{
			// Create an object of UserBLL and return it
			userBLL u = new userBLL();
			// Create an object of SqlConnection to connect DB
			SqlConnection conn = new SqlConnection(myconnstrng);
			// Create a DataTable to hold the data temporarily
			DataTable dt = new DataTable();


			try
			{
				// SQL query to get the id from username
				string sql = "SELECT user_id FROM tbl_users WHERE username='" + username + "'";
				// Create SQL data adapter
				SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

				// Open DB connection
				conn.Open();

				// Fill the data in data table from Adapter
				adapter.Fill(dt);

				// If there is user based on the username then get the user_id
				if(dt.Rows.Count >0 )
				{
					u.user_id = int.Parse(dt.Rows[0]["user_id"].ToString());
				}

			}
			catch (Exception ex)
			{
				// Display Error Message if there is any exception errors
				MessageBox.Show(ex.Message);
			}
			finally
			{
				// Close DB Connection
				conn.Close();
			}
			return u;
		}
		#endregion

	}
}
