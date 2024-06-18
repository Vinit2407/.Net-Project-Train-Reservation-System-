<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ETicket.aspx.cs" Inherits="Train_Seat_Reservation.ETicket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>E-Ticket</title>
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
        }

        h3 {
            color: #555;
        }

        .ticket-info {
            margin-bottom: 20px;
        }

        .ticket-info label {
            font-weight: bold;
        }

        .seat-list {
            margin-bottom: 20px;
        }

        .seat-list label {
            display: block;
            margin-bottom: 5px;
        }

        .fare-info {
            margin-bottom: 20px;
        }

        .fare-info label {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>E-Ticket</h2>

            <!-- Ticket Information Section -->
            <div class="ticket-info">
                <h3>Ticket Information</h3>
                <div>
                    <label>Train Name:</label>
                    <asp:Label ID="lblTrainName" runat="server" Text=""></asp:Label>
                </div>
                <div>
                    <label>Source:</label>
                    <asp:Label ID="lblSource" runat="server" Text=""></asp:Label>
                </div>
                <div>
                    <label>Destination:</label>
                    <asp:Label ID="lblDestination" runat="server" Text=""></asp:Label>
                </div>
            </div>

            <!-- Selected Seats Section -->
            <div class="seat-list">
                <h3>Selected Seats</h3>
                <asp:Label ID="lblSelectedSeats" runat="server" Text=""></asp:Label>
            </div>

            <!-- Fare Information Section -->
            <div class="fare-info">
                <h3>Fare Information</h3>
                <div>
                    <label>Total Fare:</label>
                    <asp:Label ID="lblTotalFare" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
        <asp:Button ID="Button1" runat="server" Height="50px" OnClick="Button1_Click" Text="Exit" Width="124px" />
    </form>
</body>
</html>
