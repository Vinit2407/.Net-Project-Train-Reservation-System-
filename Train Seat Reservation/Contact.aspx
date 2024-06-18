<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Train_Seat_Reservation.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .contact-container {
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
            padding: 20px;
            background-color: #f0f4f8;
            font-family: Arial, sans-serif;
        }
        .top-image {
            max-width: 100%;
            height: auto;
            margin-bottom: 20px;
            border-radius: 8px;
        }
        .contact-row {
            display: flex;
            justify-content: center;
            width: 100%;
            margin: 0 auto;
        }
        .contact-col-lg-6 {
            background-color: #ffffff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            text-align: center;
            max-width: 600px;
            width: 100%;
        }
        .contact-title {
            margin-bottom: 10px;
            color: #333;
        }
        .contact-subtitle {
            margin-bottom: 20px;
            color: #666;
        }
        .contact-info address {
            margin-bottom: 15px;
            color: #555;
            font-style: normal;
        }
        .email-link {
            color: #007bff;
            text-decoration: none;
        }
        .email-link:hover {
            text-decoration: underline;
        }
    </style>

    <main aria-labelledby="title" class="contact-container">
        <div style="text-align: center;">
            <asp:Image ID="imgTrain" ImageAlign="AbsMiddle" ImageUrl="~/Images/banner-home-1.jpg" AlternateText="Train Image" style="width: 100%" runat="server" class="top-image" />
        </div>
        <div class="contact-row">
            <div class="contact-col-lg-6">
                <h2 id="title" class="contact-title"><%: Title %></h2>
                <h3 class="contact-subtitle">Our contact page.</h3>
                <div class="contact-info">
                    <address>
                        .Net Mini Project
                    </address>
                    <address>
                        Created by:</address>
                    <address>
                        Vinit Patel</address>
                    <address>
                        CSD 3rd Year</address>
                    <address>
                        &nbsp;</address>

                    <address>
                        <strong>Contact:</strong>   <a href="mailto:patelvinit724@gmail.com" class="email-link">patelvinit724@gmail.com</a><br />
                        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com" class="email-link">Marketing@example.com</a>
                    </address>
                </div>
            </div>
        </div>
    </main>
</asp:Content>
