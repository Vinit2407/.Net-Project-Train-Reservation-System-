using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Train_Seat_Reservation
{
    public partial class UserDashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = "";
            }
        }

        protected void btnSearchTrains_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            string sourceStation = DropDownList1.SelectedValue.ToString();
            string destinationStation = DropDownList2.SelectedValue.ToString();
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=TrainReservationSystem;Integrated Security=True";
            string query = "SELECT Name FROM [Trains] WHERE Source = '" + sourceStation + "' AND Destination = '" + destinationStation + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    DropDownList3.Items.Clear();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string name = reader["Name"].ToString();
                            DropDownList3.Items.Add(name);
                            DropDownList3.Visible = true;
                            btnBookTicket.Visible = true;
                        }
                        reader.Close();
                    }
                    else
                    {
                        Label1.Text = "Train not available from selected source to destination";
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Error : " + ex.ToString());
                }
            }
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }

        protected void btnAvailableTrain_Click(object sender, EventArgs e)
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
                        GridView1.DataSource = reader;
                        GridView1.DataBind();
                    }
                    else
                    {
                        Label1.Text = "No trains available.";
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("Error : " + ex.ToString());
                }
            }
        }

        protected void btnBookTicket_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DropDownList3.SelectedValue))
            {
                string trainName = DropDownList3.SelectedValue.ToString();
                Response.Redirect("SeatSelection.aspx?trainId=" + trainName);
            }
            else
            {
                Label1.Text = "Please select a train.";
            }
        }
    }
}