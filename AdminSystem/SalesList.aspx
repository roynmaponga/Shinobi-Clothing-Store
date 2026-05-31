<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SalesList.aspx.cs" Inherits="SalesList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sales List</title>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</head>

<body class="bg-light">
    <form id="form1" runat="server">
        <div class="container mt-5">

            <div class="card shadow p-4">
                <h2 class="text-center mb-3">Sales List</h2>

                <div class="alert alert-info">
                    <asp:Label ID="lblLoggedIn" runat="server"></asp:Label>
                </div>

                <div class="mb-3">
                    <asp:ListBox ID="lstSalesList" runat="server" CssClass="form-control" Height="220px"></asp:ListBox>
                </div>

                <div class="mb-4">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="btn btn-primary me-2" OnClick="btnAdd_Click" />
                    <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="btn btn-warning me-2" OnClick="btnEdit_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="btnDelete_Click" />
                </div>

                <div class="card p-3 mb-4">
                    <h5>Filter Sales</h5>

                    <div class="mb-3">
                        <asp:Label ID="lblSaleStatus" runat="server" Text="Enter Sale Status:" CssClass="form-label"></asp:Label>
                        <asp:TextBox ID="txtSaleStatus" runat="server" CssClass="form-control" placeholder="Example: completed or pending"></asp:TextBox>
                    </div>

                    <asp:Button ID="btnApply" runat="server" Text="Apply Filter" CssClass="btn btn-success me-2" OnClick="btnApply_Click" />
                    <asp:Button ID="btnClear" runat="server" Text="Clear Filter" CssClass="btn btn-secondary" OnClick="btnClear_Click" />
                </div>

                <asp:Button ID="btnReturn" runat="server" Text="Return to Main Menu" CssClass="btn btn-dark" OnClick="btnReturn_Click" />

                <br />
                <br />

                <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>
            </div>

        </div>
    </form>
</body>
</html>