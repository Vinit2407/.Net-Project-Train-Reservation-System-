<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Train_Seat_Reservation._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="margin-top: 6%;">
        <div class="row">
            <div class="col-lg-12">
                <!-- Image centered horizontally -->
                <div style="text-align: center;">
                    <asp:Image ID="imgTrain" ImageAlign="AbsMiddle" ImageUrl="~/Images/banner-home-1.jpg" AlternateText="Train Image" style="width: 100%" runat="server" class="top-image" />
                </div>
            </div>
            <div class="col-lg-12" style="margin-top: 2%">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <div class="panel-title">
                            <h3>Welcome to Train Reservation</h3>
                        </div>
                    </div>
                    <div class="panel-body">
                        <p>Book your tickets conveniently and travel hassle-free with us! Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet.</p>
                        <p>Our website offers a simple and easy-to-use platform for booking train tickets. Whether you're traveling for business or leisure, we've got you covered.</p>
                        <a href="Login.aspx" class="btn">Book Now</a>
                    </div>
                </div>
            </div>
            <div class="col-lg-12" style="margin-top: 2%">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <div class="panel-title">
                            <h3>About Online Train Booking</h3>
                        </div>
                    </div>
                    <div class="panel-body">
                        <p>Online Train Booking System is a Web-Based application that works within a centralized network. It provides facilities to reserve seats, different types of inquiries that need instant and quick reservations.
                            Trains may be used for scheduled train transport, scheduled coach transport, school transport, private hire, or tourism; promotional trains may be used for political campaigns and others are privately operated for a wide range of purposes, including rock and pop band tour vehicles.</p>
                    </div>
                </div>
            </div>
            <div class="col-lg-12" style="margin-top: 2%">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <div class="panel-title">
                            <h3>Why Online Train Booking is Important?</h3>
                        </div>
                    </div>
                    <div class="panel-body">
                        <ul>
                            <li>Fast & Easy Online Train booking.</li>
                            <li>Zero booking fees No Extra Charges for online booking.</li>
                            <li>100 % Secure to book your Train tickets with Online Train Booking System.</li>
                            <li>All Credit/Debit/Internet Banking Accepted.</li>
                            <li>Get tickets to your mobile.</li>
                            <li>Online cancellation and phone support available.</li>
                            <li>The fastest way to book Train tickets.</li>
                            <li>Book Train tickets online for Major routes across India.</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <footer>
        <div class="container">
            <p>&copy; 2024 Train Reservation. All rights reserved.</p>
        </div>
    </footer>
</asp:Content>
