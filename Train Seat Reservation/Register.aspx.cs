using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Security.Policy;

namespace Train_Seat_Reservation
{
    public partial class Register : System.Web.UI.Page
    {
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=TrainReservationSystem;Integrated Security=True";
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string gender = rblGender.SelectedValue;
            string password = txtPassword.Text;

            if (UserExists(phoneNumber))
            {
                Response.Write("<script>alert('User with the same Phone Number already exists. Please use a different Phone Number.');</script>");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO [User Info] (Fname, Lname, Email, Phone, Gender, Password) VALUES (@Fname, @Lname, @Email, @Phone, @Gender, @Password)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Fname", firstName);
                    command.Parameters.AddWithValue("@Lname", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phoneNumber);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Password", password);
                    command.ExecuteNonQuery();
                    Response.Redirect("Default.aspx");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('An error occurred while registering. Please try again later.');</script>");
            }
        }
        private bool UserExists(string Phone)
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=TrainReservationSystem;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM [User Info] WHERE Phone = @Phone";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Phone", Phone);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
    }
}