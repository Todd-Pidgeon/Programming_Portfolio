<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kayak Tour</title>
    <style type="text/css">
        .newStyle1 {
            font-family: Verdana;
            font-size: .85em;
        }
        .auto-style1 {
            text-align: right;
        }
        .auto-style2 {
            width: 94px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>Sign up for a Kayak Tour</h2>
    
    </div>
        <table class="newStyle1">
            <tr>
                <td class="auto-style1">Select a tour:</td>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlTour" runat="server">
                        <asp:ListItem>(select)</asp:ListItem>
                        <asp:ListItem>Key Largo</asp:ListItem>
                        <asp:ListItem>John Pennekamp</asp:ListItem>
                        <asp:ListItem>Flamingo Park</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Tours.aspx" Target="_blank">Tour descriptions</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td><strong>Optional</strong> <strong>equipment</strong></td>
                <td>&nbsp;</td>
                <td class="auto-style2"><strong>Select Kayak</strong></td>
                <td>&nbsp;</td>
                <td><strong>Summary</strong></td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBoxList ID="chkEquipment" runat="server">
                        <asp:ListItem>Expert paddle</asp:ListItem>
                        <asp:ListItem>Mask &amp; snorkel</asp:ListItem>
                        <asp:ListItem>Compass</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:ListBox ID="lstKayak" runat="server" Height="92px">
                        <asp:ListItem>Owner supplied</asp:ListItem>
                        <asp:ListItem>Solo touring</asp:ListItem>
                        <asp:ListItem>Tandem touring</asp:ListItem>
                        <asp:ListItem>Solo recreational</asp:ListItem>
                        <asp:ListItem>Tandem recreational</asp:ListItem>
                    </asp:ListBox>
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:ListBox ID="lstSummary" runat="server"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnConfirm" runat="server" Text="Confirm" />
                </td>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
