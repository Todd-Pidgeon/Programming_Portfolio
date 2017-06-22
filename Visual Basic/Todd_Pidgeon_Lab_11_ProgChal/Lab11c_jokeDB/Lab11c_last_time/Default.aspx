<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Tennis DB query Selector</h1>
        <br />
    
    </div>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/allAuthor.aspx">All the authors </asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/authorByProvince.aspx">Authors by Province</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/allMags.aspx">All the Magazines</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="~/allMags.aspx">Sales by Magazine</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton5" runat="server" PostBackUrl="~/addUpdate.aspx">Add/Update Records</asp:LinkButton>
    </form>
</body>
</html>
