<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 96%;
        }
        .auto-style3 {
            width: 30px;
        }
        .auto-style5 {
            width: 83px;
        }
        .auto-style6 {
            width: 161px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Museum Tours</h1>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">Select Language</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">Museum Section</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:RadioButton ID="radEnglish" runat="server" Text="English" />
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    <asp:CheckBox ID="chkMes" runat="server" Text="Ancient Mesopotamia" />
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:RadioButton ID="radGerman" runat="server" Text="German" />
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    <asp:CheckBox ID="chkEuro" runat="server" Text="Ancient Europe" />
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:RadioButton ID="radChinese" runat="server" Text="Chinese" />
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    <asp:CheckBox ID="chkMed" runat="server" Text="Medieval Europe" />
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    <asp:CheckBox ID="chkAsia" runat="server" Text="East Asia" />
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Button ID="btnContinue" runat="server" Text="Calculate" />
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
