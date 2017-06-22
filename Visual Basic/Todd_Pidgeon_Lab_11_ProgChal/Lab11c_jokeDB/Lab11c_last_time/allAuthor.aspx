<%@ Page Language="VB" AutoEventWireup="false" CodeFile="allAuthor.aspx.vb" Inherits="allAuthor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>All Authors</h1>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="author_name" HeaderText="author_name" SortExpression="author_name" />
                <asp:BoundField DataField="author_prov" HeaderText="author_prov" SortExpression="author_prov" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:jokes_dbConnectionString %>" ProviderName="<%$ ConnectionStrings:jokes_dbConnectionString.ProviderName %>" SelectCommand="SELECT author_name, author_prov FROM author ORDER BY author_prov, author_name"></asp:SqlDataSource>
    </form>
</body>
</html>
