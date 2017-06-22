<%@ Page Language="VB" AutoEventWireup="false" CodeFile="addUpdate.aspx.vb" Inherits="addUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Add/Update Records</h1>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="author_id,joke_id,mag_id,sale_id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="author_id" HeaderText="author_id" ReadOnly="True" SortExpression="author_id" />
                <asp:BoundField DataField="author_name" HeaderText="author_name" SortExpression="author_name" />
                <asp:BoundField DataField="author_city" HeaderText="author_city" SortExpression="author_city" />
                <asp:BoundField DataField="author_prov" HeaderText="author_prov" SortExpression="author_prov" />
                <asp:BoundField DataField="joke_id" HeaderText="joke_id" InsertVisible="False" ReadOnly="True" SortExpression="joke_id" />
                <asp:BoundField DataField="joke_question" HeaderText="joke_question" SortExpression="joke_question" />
                <asp:BoundField DataField="joke_answer" HeaderText="joke_answer" SortExpression="joke_answer" />
                <asp:BoundField DataField="roy_chrg" HeaderText="roy_chrg" SortExpression="roy_chrg" />
                <asp:BoundField DataField="joke_type" HeaderText="joke_type" SortExpression="joke_type" />
                <asp:BoundField DataField="author_id1" HeaderText="author_id1" SortExpression="author_id1" />
                <asp:BoundField DataField="mag_id" HeaderText="mag_id" ReadOnly="True" SortExpression="mag_id" />
                <asp:BoundField DataField="mag_name" HeaderText="mag_name" SortExpression="mag_name" />
                <asp:BoundField DataField="mag_city" HeaderText="mag_city" SortExpression="mag_city" />
                <asp:BoundField DataField="mag_prov" HeaderText="mag_prov" SortExpression="mag_prov" />
                <asp:BoundField DataField="sale_id" HeaderText="sale_id" InsertVisible="False" ReadOnly="True" SortExpression="sale_id" />
                <asp:BoundField DataField="sale_date" HeaderText="sale_date" SortExpression="sale_date" />
                <asp:BoundField DataField="joke_id1" HeaderText="joke_id1" SortExpression="joke_id1" />
                <asp:BoundField DataField="mag_id1" HeaderText="mag_id1" SortExpression="mag_id1" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:jokes_dbConnectionString2 %>" ProviderName="<%$ ConnectionStrings:jokes_dbConnectionString2.ProviderName %>" SelectCommand="SELECT author.*, joke.*, magazine.*, sale.* FROM author INNER JOIN joke ON author.author_id = joke.author_id INNER JOIN sale ON joke.joke_id = sale.joke_id INNER JOIN magazine ON sale.mag_id = magazine.mag_id"></asp:SqlDataSource>
    </form>
</body>
</html>
