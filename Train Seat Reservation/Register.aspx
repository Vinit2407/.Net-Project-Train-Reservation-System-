<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Train_Seat_Reservation.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .register-container {
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
            background-color: #f0f4f8;
            padding: 20px;
            font-family: Arial, sans-serif;
        }

        .register-container h2 {
            color: #333;
            margin-bottom: 20px;
        }

        .register-form {
            background-color: #ffffff;
            padding: 30px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            width: 100%;
            max-width: 400px;
        }

        .register-form div {
            margin-bottom: 15px;
            display: flex;
            flex-direction: column;
            text-align: left;
        }

        .register-form label {
            margin-bottom: 5px;
            color: #555;
        }

        .register-form .form-control {
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        .register-form .btn-primary {
            background-color: #007bff;
            color: white;
            padding: 14px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            width: 100%;
            margin-top: 20px;
        }

        .register-form .btn-primary:hover {
            background-color: #0056b3;
        }
    </style>

    <div class="register-container">
        <h2>User Registration</h2>
        <div class="register-form">
            <div>
                <label for="txtFirstName">First Name:</label>
                <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <label for="txtLastName">Last Name:</label>
                <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <label for="txtEmail">Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <label for="txtPhoneNumber">Phone Number:</label>
                <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <label>Gender:</label>
                <asp:RadioButtonList ID="rblGender" runat="server">
                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <div>
                <label for="txtPassword">Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="btn btn-primary" OnClick="btnRegister_Click" />
            </div>
        </div>
    </div>
</asp:Content>
