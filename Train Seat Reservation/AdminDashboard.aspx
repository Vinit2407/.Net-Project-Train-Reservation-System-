<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="Train_Seat_Reservation.AdminDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="css/AdminDashboardStyle.css" />
    <title>Admin Dashboard</title>
    <style>
        /* Inline CSS for demonstration purposes, you can move these styles to your external CSS file */
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            color: #333;
            margin: 0;
            padding: 0;
        }

        .container {
            max-width: 800px;
            margin: 50px auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h1 {
            text-align: center;
            color: #007bff;
            margin-bottom: 20px;
        }

        .btn-container {
            text-align: center;
        }

        .btn {
            width: 100%;
            padding: 12px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            color: #fff;
            text-transform: uppercase;
            font-weight: bold;
            transition: background-color 0.3s ease;
            margin-bottom: 10px;
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
            <h1>Admin Dashboard</h1>

            <!-- Buttons Section -->
            <div class="btn-container">
                <asp:Button ID="btnAddNewTrain" runat="server" Text="Add New Train" OnClick="btnAddNewTrain_Click" CssClass="btn btn-secondary" />
                <br />
                <asp:Button ID="btnViewAllTrains" runat="server" Text="View All Trains" OnClick="btnViewAllTrains_Click" CssClass="btn btn-secondary" />
            </div>

            <!-- Available Trains Section -->
            <div class="gridview-container">
                <h3>Available Trains</h3>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" CssClass="table">
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
            <div class="btn-container">
                <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" Text="LogOut" CssClass="btn btn-primary" />
                <br />
            </div>
        </div>
    </form>
</body>
</html>
