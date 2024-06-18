<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNewTrain.aspx.cs" Inherits="Train_Seat_Reservation.AddNewTrain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add New Train</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }

        .container {
            display: flex;
            align-items: center;
            justify-content: center;
            height: 100vh;
        }

        .form-container {
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            display: flex;
            flex-direction: column;
            width: 50%;
        }

        .form-container h2 {
            text-align: center;
            margin-bottom: 20px;
        }

        .form-container label {
            margin-bottom: 5px;
        }

        .form-container input[type="text"],
        .form-container input[type="submit"],
        .form-container input[type="radio"] {
            width: 100%;
            padding: 10px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        .form-container input[type="submit"] {
            background-color: #007bff;
            color: #fff;
            border: none;
            cursor: pointer;
        }

        .form-container .radio-container {
            display: flex;
            align-items: center;
            margin-bottom: 10px;
        }

        .form-container .radio-container label {
            margin-right: 15px; /* Increased margin between "Type" and "AC" */
        }

        .form-container .radio-container input[type="radio"] {
            margin-right: 5px; /* Decreased margin between "AC" and its radio button */
        }

        .image-container {
            width: 50%;
            padding: 20px;
        }

        .image-container img {
            width: 100%;
            border-radius: 8px;
        }

        @media screen and (max-width: 768px) {
            .container {
                flex-direction: column;
                align-items: stretch;
            }
            .form-container,
            .image-container {
                width: 100%;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="image-container">
                <asp:Image ID="imgTrain" ImageAlign="AbsMiddle" ImageUrl="~/Train1.png" AlternateText="Train Image" style="width: 100%" runat="server" class="top-image" />
            </div>
            <div class="form-container">
                <h2>Add New Train</h2>
                <div>
                    <asp:Label ID="lblTrainName" runat="server" Text="Train Name:"></asp:Label>
                    <asp:TextBox ID="txtTrainName" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblSource" runat="server" Text="Source:"></asp:Label>
                    <asp:TextBox ID="txtSource" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblDestination" runat="server" Text="Destination:"></asp:Label>
                    <asp:TextBox ID="txtDestination" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblAvailableSeats" runat="server" Text="Available Seats:"></asp:Label>
                    <asp:TextBox ID="txtAvailableSeats" runat="server"></asp:TextBox>
                </div>
                <div class="radio-container">
                    <asp:Label ID="lblType" runat="server" Text="Type:"></asp:Label>
                    <asp:RadioButtonList ID="rblType" runat="server" Width="72px">
                        <asp:ListItem Text="AC" Value="AC"></asp:ListItem>
                        <asp:ListItem Text="Non-AC" Value="Non-AC"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>