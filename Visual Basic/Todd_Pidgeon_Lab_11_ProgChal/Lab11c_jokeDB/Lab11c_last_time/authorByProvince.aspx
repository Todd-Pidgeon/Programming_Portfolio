<%@ Page Language="VB" AutoEventWireup="false" CodeFile="authorByProvince.aspx.vb" Inherits="authorByProvince" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Authors By Province</h1>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="author_name" HeaderText="author_name" SortExpression="author_name" />
                <asp:BoundField DataField="author_prov" HeaderText="author_prov" SortExpression="author_prov" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:jokes_dbConnectionString2 %>" ProviderName="<%$ ConnectionStrings:jokes_dbConnectionString2.ProviderName %>" SelectCommand="author_by_prov" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtProvince" DefaultValue="BC" Name="prov" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        Enter a province:&nbsp; <asp:TextBox ID="txtProvince" runat="server" Width="128px"></asp:TextBox>
&nbsp;
        <asp:Button ID="btnConfirm" runat="server" Text="Confirm" />
    </form>
</body>
</html>
