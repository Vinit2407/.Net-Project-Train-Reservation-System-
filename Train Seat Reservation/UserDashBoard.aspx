<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserDashboard.aspx.cs" Inherits="Train_Seat_Reservation.UserDashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Dashboard</title>
    <link rel="stylesheet" href="styles.css" /> <!-- Link to your CSS file -->
    <style>
        /* Inline CSS for demonstration purposes, you can move these styles to your external CSS file */
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            color: #333;
        }

        .container {
            max-width: 800px;
            margin: 50px auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h2 {
            text-align: center;
            color: #007bff;
            margin-bottom: 20px;
        }

        h3 {
            color: #555;
            margin-bottom: 10px;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .form-control {
            width: calc(100% - 24px); /* Adjusted width */
            padding: 12px;
            border-radius: 5px;
            border: 1px solid #ccc;
            margin-bottom: 10px; /* Added margin bottom */
        }

        .btn-primary,
        .btn-secondary {
            width: 100%;
            padding: 12px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            color: #fff;
            text-transform: uppercase;
            font-weight: bold;
            transition: background-color 0.3s ease;
        }

        .btn-primary {
            background-color: #007bff;
        }

        .btn-secondary {
            background-color: #6c757d;
        }

        .btn-primary:hover,
        .btn-secondary:hover {
            background-color: #0056b3;
        }

        /* Added styles for GridView */
        .gridview-container {
            margin-top: 20px;
        }

        .gridview-container table {
            width: 100%;
            border-collapse: collapse;
        }

        .gridview-container th,
        .gridview-container td {
            padding: 10px;
            border: 1px solid #ccc;
            text-align: left;
        }

        .gridview-container th {
            background-color: #f2f2f2;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>User Dashboard</h2>

            <!-- Ticket Booking Section -->
            <div class="form-group">
                <h3>Book a Ticket</h3>
                <asp:Label ID="lblBookingMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
                <div>
                    <h5>Source :</h5>
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Source" DataValueField="Source" CssClass="form-control">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TrainReservationSystemConnectionString %>" SelectCommand="SELECT DISTINCT [Source] FROM [Trains]"></asp:SqlDataSource>
                </div>
                <div>
                    <h5>Destination :</h5>
                    <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Destination" DataValueField="Destination" CssClass="form-control">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:TrainReservationSystemConnectionString %>" SelectCommand="SELECT DISTINCT [Destination] FROM [Trains]"></asp:SqlDataSource>
                    <asp:Label ID="Label1" runat="server" Font-Size="Small" ForeColor="Red"></asp:Label>

                </div>
                <div>
                    <asp:Button ID="btnSearchTrains" runat="server" Text="Search Trains" OnClick="btnSearchTrains_Click" CssClass="btn btn-primary" />
                    <asp:DropDownList ID="DropDownList3" runat="server" Visible="false">
                    </asp:DropDownList>
                    <asp:Button ID="btnBookTicket" runat="server" Text="Book Ticket" Visible="false" OnClick="btnBookTicket_Click" CssClass="btn btn-primary" />
                </div>
            </div>

            <!-- Available Trains Section -->
            <div class="gridview-container">
                <h3>Available Trains</h3>
                <asp:Button ID="btnAvailableTrains" runat="server" Text="All Trains" OnClick="btnAvailableTrain_Click" CssClass="btn btn-secondary" />
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Train Name" />
                        <asp:BoundField DataField="Source" HeaderText="Source" />
                        <asp:BoundField DataField="Destination" HeaderText="Destination" />
                        <asp:BoundField DataField="Available Seats" HeaderText="Available Seats" />
                        <asp:BoundField DataField="Type" HeaderText="Type" />
                    </Columns>
                </asp:GridView>
            </div>

            <!-- Logout Button -->
            <div>
                <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-secondary" OnClick="btnLogout_Click" />
            </div>
        </div>
    </form>
</body>
</html>