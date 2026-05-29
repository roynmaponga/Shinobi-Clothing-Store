<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SalesList.aspx.cs" Inherits="SalesList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sales List</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Sales List</h2>

            <asp:ListBox ID="lstSalesList" runat="server" Width="300px" Height="200px"></asp:ListBox>

            <br />
            <br />

            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            &nbsp;
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
            &nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />

            <br />
            <br />

            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>