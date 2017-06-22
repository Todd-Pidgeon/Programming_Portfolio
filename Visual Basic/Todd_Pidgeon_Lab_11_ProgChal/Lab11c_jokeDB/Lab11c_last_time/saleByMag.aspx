<%@ Page Language="VB" AutoEventWireup="false" CodeFile="saleByMag.aspx.vb" Inherits="saleByMag" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Sales By Magzine</h1>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="sale_id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="mag_name" HeaderText="mag_name" SortExpression="mag_name" />
                <asp:BoundField DataField="sale_id" HeaderText="sale_id" InsertVisible="False" ReadOnly="True" SortExpression="sale_id" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:jokes_dbConnectionString2 %>" ProviderName="<%$ ConnectionStrings:jokes_dbConnectionString2.ProviderName %>" SelectCommand="sales_by_mag" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtMag" DefaultValue="RD" Name="mag" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
&nbsp;Enter a Magazine ID:
        <asp:TextBox ID="txtMag" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="btnConfirm" runat="server" Text="Confirm" />
    </form>
</body>
</html>
