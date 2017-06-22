<%@ Page Language="VB" AutoEventWireup="false" CodeFile="allMags.aspx.vb" Inherits="allMags" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>All Magazines</h1>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="mag_name" HeaderText="mag_name" SortExpression="mag_name" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:jokes_dbConnectionString2 %>" ProviderName="<%$ ConnectionStrings:jokes_dbConnectionString2.ProviderName %>" SelectCommand="SELECT mag_name FROM magazine ORDER BY mag_name DESC"></asp:SqlDataSource>
    </form>
</body>
</html>
