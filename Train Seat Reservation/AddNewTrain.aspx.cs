using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Train_Seat_Reservation
{
    public partial class AddNewTrain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string trainName = txtTrainName.Text;
            string source = txtSource.Text;
            string destination = txtDestination.Text;
            int availableSeats = Convert.ToInt32(txtAvailableSeats.Text);
            string type = rblType.SelectedValue;

            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=TrainReservationSystem;Integrated Security=True";
            string query = "INSERT INTO Trains (Name, Source, Destination, [Available Seats], Type) VALUES (@Name, @Source, @Destination, @AvailableSeats, @Type)";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", trainName);
                    command.Parameters.AddWithValue("@Source", source);
                    command.Parameters.AddWithValue("@Destination", destination);
                    command.Parameters.AddWithValue("@AvailableSeats", availableSeats);
                    command.Parameters.AddWithValue("@Type", type);
                    connection.Open();
                    command.ExecuteNonQuery();

                    string createTableQuery = "CREATE TABLE " + trainName + " ([Seat Number] INT PRIMARY KEY, [Status] NCHAR(10) NOT NULL)";
                    SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection);
                    createTableCommand.ExecuteNonQuery();

                    string fillSeatsQuery = "INSERT INTO " + trainName + " ([Seat Number], Status) VALUES ";
                    for (int i = 1; i <= 40; i++)
                    {
                        fillSeatsQuery += "(" + i + ", 'A'), ";
                    }
                    fillSeatsQuery = fillSeatsQuery.TrimEnd(',', ' '); // Remove the last comma and space
                    SqlCommand fillSeatsCommand = new SqlCommand(fillSeatsQuery, connection);
                    fillSeatsCommand.ExecuteNonQuery();
                }
                Response.Redirect("AdminDashboard.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }
    }
}