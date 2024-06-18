<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Train_Seat_Reservation.AdminLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .admin-container {
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center;
            min-height: 70vh;
            background-color: #f0f4f8;
            padding: 20px;
            font-family: Arial, sans-serif;
        }

        .admin-container h2 {
            color: #333;
            margin-bottom: 20px;
        }

        .admin-form {
            background-color: #ffffff;
            padding: 30px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            width: 100%;
            max-width: 400px;
            text-align: center;
        }

        .form-group {
            font-size: large;
            margin-bottom: 15px;
        }

        .form-control {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            margin-bottom: 10px;
        }

        .btn-primary {
            background-color: #007bff;
            color: white;
            padding: 14px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            width: 100%;
        }

        .btn-primary:hover {
            background-color: #0056b3;
        }

        .text-danger {
            color: #dc3545;
        }
    </style>

    <div class="admin-container">
        <h2>Admin Login</h2>
        <div class="admin-form">
            <asp:Label ID="lblMessage" runat="server" Text="" CssClass="text-danger"></asp:Label>
            <div class="form-group">
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" placeholder="Name"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control" placeholder="Phone Number"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Password"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
            </div>
        </div>
    </div>
</asp:Content>
