<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Train_Seat_Reservation.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .login-container {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 70vh;
            background-color: #f0f4f8;
            font-family: Arial, sans-serif;
        }
        .login-box {
            background-color: #ffffff;
            padding: 20px 30px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            width: 100%;
            max-width: 400px;
            text-align: center;
        }
        .login-box h2 {
            margin-bottom: 20px;
            color: #333;
        }
        .login-box .form-control {
            width: 100%;
            padding: 10px;
            margin: 15px 0;
            border: 1px solid #ccc;
            border-radius: 4px;
        }
        .login-box .btn-primary {
            background-color: #007bff;
            color: #fff;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        .login-box .btn-primary:hover {
            background-color: #0056b3;
        }
        .login-box .text-danger {
            color: #d9534f;
        }
    </style>

    <div class="login-container">
        <div class="login-box">
            <h2>Login</h2>
            <asp:Label ID="lblMessage" runat="server" Text="" CssClass="text-danger"></asp:Label>
            <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="form-control" placeholder="Phone Number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPhoneNumber" runat="server" ControlToValidate="txtPhoneNumber" ErrorMessage="Phone number is required." Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required." Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
        </div>
    </div>
</asp:Content>
