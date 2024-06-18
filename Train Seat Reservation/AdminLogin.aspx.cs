using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Train_Seat_Reservation
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMessage.Text = "";
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Please enter all fields.";
                return;
            }
            if (ValidateAdminCredentials(name, phone, password))
            {
                Session["PhoneNumber"] = phone; 
                Response.Redirect("AdminDashboard.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid credentials. Please try again.";
            }
        }

        private bool ValidateAdminCredentials(string name, string phone, string password)
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=TrainReservationSystem;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM [Admin] WHERE Name = @name AND Phone = @phone AND Password = @password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@password", password);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
    }
}