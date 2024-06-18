using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Train_Seat_Reservation
{
    public partial class Login : Page
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
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;

            if (IsValidUser(phoneNumber, password))
            {
                Session["PhoneNumber"]=phoneNumber;
                Response.Redirect("UserDashboard.aspx");
            }
            else if (IsAdmin(phoneNumber, password))
            {
                Response.Redirect("AdminDashboard.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid phone number or password.";
            }
        }

        private bool IsValidUser(string phoneNumber, string password)
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=TrainReservationSystem;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM [User Info] WHERE Phone = @phone AND Password = @password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@phone", phoneNumber);
                command.Parameters.AddWithValue("@password", password);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        private bool IsAdmin(string phoneNumber, string password)
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=TrainReservationSystem;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM [Admin] WHERE Phone = @phone AND Password = @password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@phone", phoneNumber);
                command.Parameters.AddWithValue("@password", password);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
