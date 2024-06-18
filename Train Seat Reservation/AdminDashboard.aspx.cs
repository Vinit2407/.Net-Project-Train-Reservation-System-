using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Train_Seat_Reservation
{
    public partial class AdminDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddNewTrain_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNewTrain.aspx");
        }

        protected void btnViewAllTrains_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=TrainReservationSystem;Integrated Security=True";
            string query = "SELECT Name, Source, Destination, [Available Seats], Type FROM [Trains]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        GridView2.DataSource = reader;
                        GridView2.DataBind();
                    }
                    else
                    {
                        //Label1.Text = "No trains available.";
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("Error : " + ex.ToString());
                }
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }
    }
}