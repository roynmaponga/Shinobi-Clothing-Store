<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SalesDataEntry.aspx.cs" Inherits="SalesDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sales Data Entry</title>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</head>

<body class="bg-light">
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="card shadow p-4 mx-auto" style="max-width: 650px;">

                <h2 class="text-center mb-4">Sales Data Entry</h2>

                <div class="mb-3">
                    <asp:Label ID="lblSaleID" runat="server" Text="Sale ID" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtSaleID" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                </div>

                <div class="mb-3">
                    <asp:Label ID="lblOrderID" runat="server" Text="Order ID" CssClass="form-label"></asp:Label>
                    <asp:DropDownList ID="ddlOrderID" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>

                <div class="mb-3">
                    <asp:Label ID="lblSaleDate" runat="server" Text="Sale Date" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtSaleDate" runat="server" CssClass="form-control" placeholder="Example: 29/05/2026"></asp:TextBox>
                </div>

                <div class="mb-3">
                    <asp:Label ID="lblTotalAmount" runat="server" Text="Total Amount" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtTotalAmount" runat="server" CssClass="form-control" placeholder="Example: 21.00"></asp:TextBox>
                </div>

                <div class="mb-3">
                    <asp:Label ID="lblPaymentMethod" runat="server" Text="Payment Method" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtPaymentMethod" runat="server" CssClass="form-control" placeholder="Example: card or cash"></asp:TextBox>
                </div>

                <div class="mb-3">
                    <asp:Label ID="lblSaleStatus" runat="server" Text="Sale Status" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtSaleStatus" runat="server" CssClass="form-control" placeholder="Example: completed or pending"></asp:TextBox>
                </div>

                <div class="form-check mb-4">
                    <asp:CheckBox ID="chkIsRefunded" runat="server" CssClass="form-check-input" />
                    <asp:Label ID="lblIsRefunded" runat="server" Text="Is Refunded" CssClass="form-check-label"></asp:Label>
                </div>

                <div class="d-flex gap-2">
                    <asp:Button ID="btnOK" runat="server" Text="OK" CssClass="btn btn-primary" OnClick="btnOK_Click" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-secondary" OnClick="btnCancel_Click" />
                    <asp:Button ID="btnReturn" runat="server" Text="Return to Main Menu" CssClass="btn btn-dark" OnClick="btnReturn_Click" />
                </div>

                <br />

                <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>

            </div>
        </div>
    </form>
</body>
</html>