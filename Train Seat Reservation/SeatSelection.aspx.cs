using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using Microsoft.Ajax.Utilities;

namespace Train_Seat_Reservation
{
    public partial class SeatSelection : System.Web.UI.Page
    {
        static int seatbookno = -1;
        static List<int> totalseats = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                seatstatus();
            }
        }
        private void seatstatus()
        {
            string trainId = Request.QueryString["trainId"];
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=TrainReservationSystem;Integrated Security=True";
            string query = "SELECT * FROM "+trainId+"";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            int rows = ds.Tables[0].Rows.Count;
            int i = 0;
            while (i < rows)
            {
                string status = ds.Tables[0].Rows[i]["Status"].ToString();
                if (status == "A         ")
                {
                 
                    if (i == 0 )
                    {;
                        Button1.BackColor=System.Drawing.Color.Gray;
                    }
                    if (i == 1 )
                    {
                        Button2.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 2 )
                    {
                        Button3.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 3)
                    {
                        Button4.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 4 )
                    {
                        Button5.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 5 )
                    {
                        Button6.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 6 )
                    {
                        Button7.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 7 )
                    {
                        Button8.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 8 )
                    {
                        Button9.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 9 )
                    {
                        Button10.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 10 )
                    {
                        Button11.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 11 )
                    {
                        Button12.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 12 )
                    {
                        Button13.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 13 )
                    {
                        Button14.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 14 )
                    {
                        Button15.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 15 )
                    {
                        Button16.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 16 )
                    {
                        Button17.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 17 )
                    {
                        Button18.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 18 )
                    {
                        Button19.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 19 )
                    {
                        Button20.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 20 )
                    {
                        Button21.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 21 )
                    {
                        Button22.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 22 )
                    {
                        Button23.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 23 )
                    {
                        Button24.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 24 )
                    {
                        Button25.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 25 )
                    {
                        Button26.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 26 )
                    {
                        Button27.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 27 )
                    {
                        Button28.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 28 )
                    {
                        Button29.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 29 )
                    {
                        Button30.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 30 )
                    {
                        Button31.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 31 )
                    {
                        Button32.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 32 )
                    {
                        Button33.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 33 )
                    {
                        Button34.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 34 )
                    {
                        Button35.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 35 )
                    {
                        Button36.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 36 )
                    {
                        Button37.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 37 )
                    {
                        Button38.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 38 )
                    {
                        Button39.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 39 )
                    {
                        Button40.BackColor = System.Drawing.Color.Gray;
                    }
                }
                if (status == "B         ")
                {
                    if (i == 0 )
                    {
                        Button1.BackColor = System.Drawing.Color.Red;
                        Button1.Enabled = false;
                    }
                    if (i == 1 )
                    {
                        Button2.BackColor = System.Drawing.Color.Red;
                        Button2.Enabled = false;
                    }
                    if (i == 2 )
                    {
                        Button3.BackColor = System.Drawing.Color.Red;
                        Button3.Enabled = false;
                    }
                    if (i == 3 )
                    {
                        Button4.BackColor = System.Drawing.Color.Red;
                        Button4.Enabled = false;
                    }
                    if (i == 4 )
                    {
                        Button5.BackColor = System.Drawing.Color.Red;
                        Button5.Enabled = false;
                    }
                    if (i == 5 )
                    {
                        Button6.BackColor = System.Drawing.Color.Red;
                        Button6.Enabled = false;
                    }
                    if (i == 6 )
                    {
                        Button7.BackColor = System.Drawing.Color.Red;
                        Button7.Enabled = false;
                    }
                    if (i == 7 )
                    {
                        Button8.BackColor = System.Drawing.Color.Red;
                        Button8.Enabled = false;
                    }
                    if (i == 8 )
                    {
                        Button9.BackColor = System.Drawing.Color.Red;
                        Button9.Enabled = false;
                    }
                    if (i == 9 )
                    {
                        Button10.BackColor = System.Drawing.Color.Red;
                        Button10.Enabled = false;
                    }
                    if (i == 10 )
                    {
                        Button11.BackColor = System.Drawing.Color.Red;
                        Button11.Enabled = false;
                    }
                    if (i == 11 )
                    {
                        Button12.BackColor = System.Drawing.Color.Red;
                        Button12.Enabled = false;
                    }
                    if (i == 12 )
                    {
                        Button13.BackColor = System.Drawing.Color.Red;
                        Button13.Enabled = false;
                    }
                    if (i == 13 )
                    {
                        Button14.BackColor = System.Drawing.Color.Red;
                        Button14.Enabled = false;
                    }
                    if (i == 14 )
                    {
                        Button15.BackColor = System.Drawing.Color.Red;
                        Button15.Enabled = false;
                    }
                    if (i == 15 )
                    {
                        Button16.BackColor = System.Drawing.Color.Red;
                        Button16.Enabled = false;
                    }
                    if (i == 16 )
                    {
                        Button17.BackColor = System.Drawing.Color.Red;
                        Button17.Enabled = false;
                    }
                    if (i == 17 )
                    {
                        Button18.BackColor = System.Drawing.Color.Red;
                        Button18.Enabled = false;
                    }
                    if (i == 18 )
                    {
                        Button19.BackColor = System.Drawing.Color.Red;
                        Button19.Enabled = false;
                    }
                    if (i == 19 )
                    {
                        Button20.BackColor = System.Drawing.Color.Red;
                        Button20.Enabled = false;
                    }
                    if (i == 20 )
                    {
                        Button21.BackColor = System.Drawing.Color.Red;
                        Button21.Enabled = false;
                    }
                    if (i == 21 )
                    {
                        Button22.BackColor = System.Drawing.Color.Red;
                        Button22.Enabled = false;
                    }
                    if (i == 22 )
                    {
                        Button23.BackColor = System.Drawing.Color.Red;
                        Button23.Enabled = false;
                    }
                    if (i == 23 )
                    {
                        Button24.BackColor = System.Drawing.Color.Red;
                        Button24.Enabled = false;
                    }
                    if (i == 24 )
                    {
                        Button25.BackColor = System.Drawing.Color.Red;
                        Button25.Enabled = false;
                    }
                    if (i == 25 )
                    {
                        Button26.BackColor = System.Drawing.Color.Red;
                        Button26.Enabled = false;
                    }
                    if (i == 26 )
                    {
                        Button27.BackColor = System.Drawing.Color.Red;
                        Button27.Enabled = false;
                    }
                    if (i == 27 )
                    {
                        Button28.BackColor = System.Drawing.Color.Red;
                        Button28.Enabled = false;
                    }
                    if (i == 28 )
                    {
                        Button29.BackColor = System.Drawing.Color.Red;
                        Button29.Enabled = false;
                    }
                    if (i == 29 )
                    {
                        Button30.BackColor = System.Drawing.Color.Red;
                        Button30.Enabled = false;
                    }
                    if (i == 30 )
                    {
                        Button31.BackColor = System.Drawing.Color.Red;
                        Button31.Enabled = false;
                    }
                    if (i == 31 )
                    {
                        Button32.BackColor = System.Drawing.Color.Red;
                        Button32.Enabled = false;
                    }
                    if (i == 32 )
                    {
                        Button33.BackColor = System.Drawing.Color.Red;
                        Button33.Enabled = false;
                    }
                    if (i == 33  )
                    {
                        Button34.BackColor = System.Drawing.Color.Red;
                        Button34.Enabled = false;
                    }
                    if (i == 34  )
                    {
                        Button35.BackColor = System.Drawing.Color.Red;
                        Button35.Enabled = false;
                    }
                    if (i == 35 )
                    {
                        Button36.BackColor = System.Drawing.Color.Red;
                        Button36.Enabled = false;
                    }
                    if (i == 36 )
                    {
                        Button37.BackColor = System.Drawing.Color.Red;
                        Button37.Enabled = false;
                    }
                    if (i == 37 )
                    {
                        Button38.BackColor = System.Drawing.Color.Red;
                        Button38.Enabled = false;
                    }
                    if (i == 38 )
                    {
                        Button39.BackColor = System.Drawing.Color.Red;
                        Button39.Enabled = false;
                    }
                    if (i == 39 )
                    {
                        Button40.BackColor = System.Drawing.Color.Red;
                        Button40.Enabled = false;
                    }
                }
                i=i+1;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            seatbookno = 1;
            Button1.BackColor = System.Drawing.Color.Green;
            totalseats.Add( seatbookno );
            //seatstatus();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            seatbookno = 2;
            Button2.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            seatbookno = 3;
            Button3.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            seatbookno = 4;
            Button4.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            seatbookno = 5;
            Button5.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            seatbookno = 6;
            Button6.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            seatbookno = 7;
            Button7.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            seatbookno = 8;
            Button8.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            seatbookno = 9;
            Button9.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            seatbookno = 10;
            Button10.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            seatbookno = 11;
            Button11.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            seatbookno = 12;
            Button12.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            seatbookno = 13;
            Button13.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            seatbookno = 14;
            Button14.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            seatbookno = 15;
            Button15.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            seatbookno = 16;
            Button16.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            seatbookno = 17;
            Button17.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            seatbookno = 18;
            Button18.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            seatbookno = 19;
            Button19.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            seatbookno = 20;
            Button20.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            seatbookno = 21;
            Button21.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            seatbookno = 22;
            Button22.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button23_Click(object sender, EventArgs e)
        {
            seatbookno = 23;
            Button23.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            seatbookno = 24;
            Button24.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button25_Click(object sender, EventArgs e)
        {
            seatbookno = 25;
            Button25.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button26_Click(object sender, EventArgs e)
        {
            seatbookno = 26;
            Button26.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button27_Click(object sender, EventArgs e)
        {
            seatbookno = 27;
            Button27.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button28_Click(object sender, EventArgs e)
        {
            seatbookno = 28;
            Button28.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button29_Click(object sender, EventArgs e)
        {
            seatbookno = 29;
            Button29.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button30_Click(object sender, EventArgs e)
        {
            seatbookno = 30;
            Button30.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button31_Click(object sender, EventArgs e)
        {
            seatbookno = 31;
            Button31.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button32_Click(object sender, EventArgs e)
        {
            seatbookno = 32;
            Button32.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button33_Click(object sender, EventArgs e)
        {
            seatbookno = 33;
            Button33.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button34_Click(object sender, EventArgs e)
        {
            seatbookno = 34;
            Button34.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button35_Click(object sender, EventArgs e)
        {
            seatbookno = 35;
            Button35.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button36_Click(object sender, EventArgs e)
        {
            seatbookno = 36;
            Button36.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button37_Click(object sender, EventArgs e)
        {
            seatbookno = 37;
            Button37.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button38_Click(object sender, EventArgs e)
        {
            seatbookno = 38;
            Button38.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button39_Click(object sender, EventArgs e)
        {
            seatbookno = 39;
            Button39.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button40_Click(object sender, EventArgs e)
        {
            seatbookno = 40;
            Button40.BackColor = System.Drawing.Color.Green;
            totalseats.Add(seatbookno);
            //seatstatus();
        }

        protected void Button41_Click(object sender, EventArgs e)
        {
            if (Session["PhoneNumber"] != null)
            {
                string num = Session["PhoneNumber"].ToString();
                string trainId = Request.QueryString["trainId"];
                string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=TrainReservationSystem;Integrated Security=True";
                foreach (int item in totalseats)
                {
                    string query = "UPDATE [" + trainId + "] SET Status = 'B' WHERE [Seat Number] = " + item;

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();

                        string query2 = "INSERT INTO [Booking List] (Phone , [Train Name] , [Seat Number]) VALUES (@Phone,@TrainName,@SeatNumber)";
                        SqlCommand cmd2 = new SqlCommand(query2, con);
                        cmd2.Parameters.AddWithValue("@Phone", num);
                        cmd2.Parameters.AddWithValue("@TrainName", trainId);
                        cmd2.Parameters.AddWithValue("@SeatNumber", item);
                        cmd2.ExecuteNonQuery();

                        string query3 = "SELECT [Available Seats] FROM Trains WHERE Name = @TrainId";
                        SqlCommand cmd3 = new SqlCommand(query3, con);
                        cmd3.Parameters.AddWithValue("@TrainId", trainId);
                        int count = Convert.ToInt32(cmd3.ExecuteScalar());
                        count--;

                        string query4 = "UPDATE Trains SET [Available Seats] = @Count WHERE Name = @TrainId";
                        SqlCommand cmd4 = new SqlCommand(query4, con);
                        cmd4.Parameters.AddWithValue("@Count", count);
                        cmd4.Parameters.AddWithValue("@TrainId", trainId);
                        cmd4.ExecuteNonQuery();
                    }
                }
                string seatNumbers = string.Join(",", totalseats);
                Response.Redirect("ETicket.aspx?seatnumber="+seatNumbers+"&trainid="+trainId);
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}