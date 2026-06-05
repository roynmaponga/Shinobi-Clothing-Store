<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Team Main Menu</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="card shadow p-4 mx-auto" style="max-width: 500px;">
                <h2 class="text-center mb-3">SHINOBI Team Main Menu</h2>
                <p class="text-center text-muted">Please choose a section to continue.</p>
                <p class="text-center">

    Logged in as:
    <asp:Label ID="lblUser"
        runat="server">
    </asp:Label>
</p>

                <div class="d-grid gap-3">
                    <asp:Button ID="btnSales" runat="server" Text="Sales" CssClass="btn btn-primary" OnClick="btnSales_Click" />
                    <asp:Button ID="btnOrders" runat="server" Text="Orders" CssClass="btn btn-secondary" OnClick="btnOrders_Click" />
                    <asp:Button ID="btnProducts" runat="server" Text="Products" CssClass="btn btn-success" OnClick="btnProducts_Click" />
                    <asp:Button ID="btnUsers" runat="server" Text="Users" CssClass="btn btn-dark" OnClick="btnUsers_Click" />
                    <asp:Button ID="btnLogout"
    runat="server"
    Text="Logout"
    CssClass="btn btn-danger"
    OnClick="btnLogout_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>