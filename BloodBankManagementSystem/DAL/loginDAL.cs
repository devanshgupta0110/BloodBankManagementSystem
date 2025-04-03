using BloodBankManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.DAL
{
	internal class loginDAL
	{
		// Create static string to connect the db
		static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


		public bool loginCheck(loginBLL l)
        {
			// Create a boolean variable and set its default value to false
			bool isSuccess = false;

			// Connect Database
			SqlConnection conn = new SqlConnection(myconnstrng);

			try
			{
				// SQL query to check login based on username and password
				string sql = "SELECT * FROM tbl_users WHERE username=@username AND password=@password";

				// Create SQL Command to pass the value to query
				SqlCommand cmd = new SqlCommand(sql, conn);

				// Pass the value to query using parameters
				cmd.Parameters.AddWithValue("@username", l.username);
				cmd.Parameters.AddWithValue("@password", l.password);

				// SQl Data Adapter to get the data from database
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				// Data table to hold the data from database temporarily
				DataTable dt = new DataTable();

				// Fill the data from adapter to data table
				adapter.Fill(dt);

				// Check if the user exists or not
				if (dt.Rows.Count > 0)
				{
					// User exists and login is successful
					isSuccess = true;
				}
				else
				{
					// User does not exist or login is failed
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
	}
}
