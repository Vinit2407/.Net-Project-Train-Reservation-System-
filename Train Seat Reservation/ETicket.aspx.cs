using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Train_Seat_Reservation
{
    public partial class ETicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            generate_ticket();
        }
        void generate_ticket()
        {
            try
            {
                int fare = 0;
                string trainId = Request.QueryString["trainid"];
                string seatNumbersStr = Request.QueryString["seatnumber"];
                List<int> seatNumbers = seatNumbersStr.Split(',').Select(int.Parse).ToList();
                int count = seatNumbers.Count;

                string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=TrainReservationSystem;Integrated Security=True";
                string query = "SELECT Source, Destination, Type FROM Trains WHERE Name = @TrainId";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@TrainId", trainId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = dataSet.Tables[0].Rows[0];
                        string source = row["Source"].ToString();
                        string destination = row["Destination"].ToString();
                        string type = row["Type"].ToString();

                        if (type == "AC        ")
                        {
                            fare = count * 80;
                        }
                        else
                        {
                            fare = count * 35;
                        }

                        lblTrainName.Text = trainId;
                        lblSource.Text = source;
                        lblDestination.Text = destination;
                        lblSelectedSeats.Text = seatNumbersStr;
                        lblTotalFare.Text = fare.ToString();
                    }
                    else
                    {
                        Response.Write("<script>alert('An error occurred while Generating Ticket. Please try again later.');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('An error occurred while Generating Ticket"+ex.ToString()+". Please try again later.');</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }
    }
}