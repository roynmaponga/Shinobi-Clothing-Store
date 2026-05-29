<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Team Main Menu</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; margin-top:50px;">

            <h2>SHINOBI Team Main Menu</h2>

            <p>Please choose a section to continue.</p>

            <asp:Button ID="btnSales" runat="server" Text="Sales" OnClick="btnSales_Click" />
            <br /><br />

            <asp:Button ID="btnOrders" runat="server" Text="Orders" OnClick="btnOrders_Click" />
            <br /><br />

            <asp:Button ID="btnProducts" runat="server" Text="Products" OnClick="btnProducts_Click" />
            <br /><br />

            <asp:Button ID="btnUsers" runat="server" Text="Users" OnClick="btnUsers_Click" />

        </div>
    </form>
</body>
</html>