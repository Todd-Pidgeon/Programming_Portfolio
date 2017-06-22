<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Room Charge Calculator</title>
    <style type="text/css">
        .auto-style1 {
            width: 81%;
        }
        .auto-style6 {
            width: 121px;
        }
        .auto-style7 {
            width: 121px;
            text-align: right;
        }
        .auto-style12 {
            width: 121px;
            height: 23px;
        }
        .auto-style14 {
            width: 106px;
            height: 23px;
            text-align: right;
        }
        .auto-style21 {
            width: 106px;
            text-align: right;
        }
        .auto-style22 {
            width: 106px;
        }
        .auto-style23 {
            width: 106px;
            height: 23px;
        }
        .auto-style26 {
            width: 121px;
            height: 23px;
            text-align: right;
        }
        .auto-style27 {
            width: 347px;
        }
        .auto-style28 {
            width: 347px;
            height: 23px;
        }
        .auto-style29 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 class="auto-style29">Highlander Hotel</h1>
        <p class="auto-style29">
            Today&#39;s Date:&nbsp;
            <asp:Label ID="lblDate" runat="server"></asp:Label>
        </p>
        <p class="auto-style29">
            Time:&nbsp; <asp:Label ID="lblTime" runat="server"></asp:Label>
        </p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style22">Room Infomation</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style6">Additional Charges</td>
                <td class="auto-style27">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style27">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style21">Nights:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtNights" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">Room Service:</td>
                <td class="auto-style27">
                    <asp:TextBox ID="txtRoomService" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style21">Nightly Charge:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtNightlyCharges" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">Telephone:</td>
                <td class="auto-style27">
                    <asp:TextBox ID="txtTelephone" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">Misc:</td>
                <td class="auto-style27">
                    <asp:TextBox ID="txtMisc" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style27">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style6">Total Charges:</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style27">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style27">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style7">Room Charges:</td>
                <td class="auto-style6">
                    <asp:Label ID="lblRoomCharges" runat="server"></asp:Label>
                </td>
                <td class="auto-style27">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style7">Additional Charges:</td>
                <td class="auto-style6">
                    <asp:Label ID="lblAdditionalCharges" runat="server"></asp:Label>
                </td>
                <td class="auto-style27">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style26">Subtotal:</td>
                <td class="auto-style12">
                    <asp:Label ID="lblSubtotal" runat="server"></asp:Label>
                </td>
                <td class="auto-style28"></td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style26">Tax:</td>
                <td class="auto-style12">
                    <asp:Label ID="lblTax" runat="server"></asp:Label>
                </td>
                <td class="auto-style28">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style26">Total Charges:</td>
                <td class="auto-style12">
                    <asp:Label ID="lblTotalCharges" runat="server"></asp:Label>
                </td>
                <td class="auto-style28">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style23">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style28">
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style23"></td>
                <td class="auto-style12">
                    <asp:Button ID="btnCalculate" runat="server" Text="Calculate Charges" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="btnClear" runat="server" Text="Clear" Width="132px" />
                </td>
                <td class="auto-style28">
                    <asp:Button ID="btnExit" runat="server" Text="Exit" Width="134px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
