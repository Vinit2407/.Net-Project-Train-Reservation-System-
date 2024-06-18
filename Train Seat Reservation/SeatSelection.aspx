<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeatSelection.aspx.cs" Inherits="Train_Seat_Reservation.SeatSelection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 93%;
            height: 355px;
        }
        .auto-style2 {
            height: 23px;
            width: 76px;
        }
        .auto-style5 {
            height: 82px;
            width: 76px;
        }
        .auto-style6 {
            height: 29px;
            width: 76px;
        }
        .auto-style19 {
            margin-left: 0px;
        }
        .auto-style21 {
            height: 23px;
            width: 125px;
        }
        .auto-style22 {
            height: 29px;
            width: 125px;
        }
        .auto-style23 {
            height: 82px;
            width: 125px;
        }
        .auto-style24 {
            height: 33px;
            text-align: center;
        }
        .auto-style26 {
            height: 33px;
            width: 125px;
            text-align: left;
        }
        .auto-style27 {
            height: 33px;
            text-align: left;
            width: 76px;
        }
        .auto-style28 {
            height: 23px;
            text-align: center;
        }
        .auto-style29 {
            height: 29px;
            text-align: center;
        }
        .auto-style30 {
            height: 82px;
        }
    </style>
</head>
<body style="width: 1170px">
    <form id="form1" runat="server">
        <div>
            <br />
            <b>Select Your Seat :</b><br />
            <br />
            <table border="1" class="auto-style1">
                <tr>
                    <td class="auto-style24">
                        <asp:Button ID="Button1" runat="server" Height="80px" Text="1" Width="80px" OnClick="Button1_Click" />
                    </td>
                    <td class="auto-style26">
                        <asp:Button ID="Button2" runat="server" CssClass="auto-style19" Height="80px" Text="2" Width="80px" OnClick="Button2_Click" />
                    </td>
                    <td class="auto-style24">
                        <asp:Button ID="Button3" runat="server" Height="80px" Text="3" Width="80px" OnClick="Button3_Click" />
                    </td>
                    <td class="auto-style26">
                        <asp:Button ID="Button4" runat="server" Height="80px" Text="4" Width="80px" OnClick="Button4_Click" />
                    </td>
                    <td class="auto-style24">
                        <asp:Button ID="Button5" runat="server" Height="80px" Text="5" Width="80px" OnClick="Button5_Click" />
                    </td>
                    <td class="auto-style26">
                        <asp:Button ID="Button6" runat="server" Height="80px" Text="6" Width="80px" OnClick="Button6_Click" />
                    </td>
                    <td class="auto-style24">
                        <asp:Button ID="Button7" runat="server" Height="80px" Text="7" Width="80px" OnClick="Button7_Click" />
                    </td>
                    <td class="auto-style26">
                        <asp:Button ID="Button8" runat="server" Height="80px" Text="8" Width="80px" OnClick="Button8_Click" />
                    </td>
                    <td class="auto-style24">
                        <asp:Button ID="Button9" runat="server" Height="80px" Text="9" Width="80px" OnClick="Button9_Click" />
                    </td>
                    <td class="auto-style27">
                        <asp:Button ID="Button10" runat="server" Height="80px" Text="10" Width="80px" OnClick="Button10_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style28">
                        <asp:Button ID="Button11" runat="server" Height="80px" Text="11" Width="80px" OnClick="Button11_Click" />
                    </td>
                    <td class="auto-style21">
                        <asp:Button ID="Button12" runat="server" Height="80px" Text="12" Width="80px" OnClick="Button12_Click" />
                    </td>
                    <td class="auto-style28">
                        <asp:Button ID="Button13" runat="server" Height="80px" Text="13" Width="80px" OnClick="Button13_Click" />
                    </td>
                    <td class="auto-style21">
                        <asp:Button ID="Button14" runat="server" Height="80px" Text="14" Width="80px" OnClick="Button14_Click" />
                    </td>
                    <td class="auto-style28">
                        <asp:Button ID="Button15" runat="server" Height="80px" Text="15" Width="80px" OnClick="Button15_Click" />
                    </td>
                    <td class="auto-style21">
                        <asp:Button ID="Button16" runat="server" Height="80px" Text="16" Width="80px" OnClick="Button16_Click" />
                    </td>
                    <td class="auto-style28">
                        <asp:Button ID="Button17" runat="server" Height="80px" Text="17" Width="80px" OnClick="Button17_Click" />
                    </td>
                    <td class="auto-style21">
                        <asp:Button ID="Button18" runat="server" Height="80px" Text="18" Width="80px" OnClick="Button18_Click" />
                    </td>
                    <td class="auto-style28">
                        <asp:Button ID="Button19" runat="server" Height="80px" Text="19" Width="80px" OnClick="Button19_Click" />
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="Button20" runat="server" Height="80px" Text="20" Width="80px" OnClick="Button20_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style29">
                        <asp:Button ID="Button21" runat="server" Height="80px" Text="21" Width="80px" OnClick="Button21_Click" />
                    </td>
                    <td class="auto-style22">
                        <asp:Button ID="Button22" runat="server" Height="80px" Text="22" Width="80px" OnClick="Button22_Click" />
                    </td>
                    <td class="auto-style29">
                        <asp:Button ID="Button23" runat="server" Height="80px" Text="23" Width="80px" OnClick="Button23_Click" />
                    </td>
                    <td class="auto-style22">
                        <asp:Button ID="Button24" runat="server" Height="80px" Text="24" Width="80px" OnClick="Button24_Click" />
                    </td>
                    <td class="auto-style29">
                        <asp:Button ID="Button25" runat="server" Height="80px" Text="25" Width="80px" OnClick="Button25_Click" />
                    </td>
                    <td class="auto-style22">
                        <asp:Button ID="Button26" runat="server" Height="80px" Text="26" Width="80px" OnClick="Button26_Click" />
                    </td>
                    <td class="auto-style29">
                        <asp:Button ID="Button27" runat="server" Height="80px" Text="27" Width="80px" OnClick="Button27_Click" />
                    </td>
                    <td class="auto-style22">
                        <asp:Button ID="Button28" runat="server" Height="80px" Text="28" Width="80px" OnClick="Button28_Click" />
                    </td>
                    <td class="auto-style29">
                        <asp:Button ID="Button29" runat="server" Height="80px" Text="29" Width="80px" OnClick="Button29_Click" />
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="Button30" runat="server" Height="80px" Text="30" Width="80px" OnClick="Button30_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style30">
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button31" runat="server" Height="80px" Text="31" Width="80px" OnClick="Button31_Click" />
                    </td>
                    <td class="auto-style23">
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button32" runat="server" Height="80px" Text="32" Width="80px" OnClick="Button32_Click" />
                    </td>
                    <td class="auto-style30">
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button33" runat="server" Height="80px" Text="33" Width="80px" OnClick="Button33_Click" />
                    </td>
                    <td class="auto-style23">
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button34" runat="server" Height="80px" Text="34" Width="80px" OnClick="Button34_Click" />
                    </td>
                    <td class="auto-style30">
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button35" runat="server" Height="80px" Text="35" Width="80px" OnClick="Button35_Click" />
                    </td>
                    <td class="auto-style23">
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button36" runat="server" Height="80px" Text="36" Width="80px" OnClick="Button36_Click" />
                    </td>
                    <td class="auto-style30">
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button37" runat="server" Height="80px" Text="37" Width="80px" OnClick="Button37_Click" />
                    </td>
                    <td class="auto-style23">
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button38" runat="server" Height="80px" Text="38" Width="80px" OnClick="Button38_Click" />
                    </td>
                    <td class="auto-style30">
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button39" runat="server" Height="80px" Text="39" Width="80px" OnClick="Button39_Click" />
                    </td>
                    <td class="auto-style5">
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button40" runat="server" Height="80px" Text="40" Width="80px" OnClick="Button40_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button41" runat="server" Height="50px" OnClick="Button41_Click" Text="Book Now" Width="125px" BackColor="#0066FF" Font-Bold="True" ForeColor="White" />
        </p>
    </form>
</body>
</html>
