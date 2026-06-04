<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SalesConfirmDelete.aspx.cs" Inherits="SalesConfirmDeletePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete Sale</title>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</head>

<body class="bg-light">
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="card shadow p-4 mx-auto" style="max-width: 550px;">

                <h2 class="text-center text-danger mb-4">Confirm Delete Sale</h2>

                <div class="alert alert-warning text-center">
                    Are you sure you want to delete this sale?
                </div>

                <div class="d-flex justify-content-center gap-3">
                    <asp:Button ID="btnYes" runat="server" Text="Yes, Delete" CssClass="btn btn-danger" OnClick="btnYes_Click" />
                    <asp:Button ID="btnNo" runat="server" Text="No, Cancel" CssClass="btn btn-secondary" OnClick="btnNo_Click" />
                </div>

                <br />

                <asp:Label ID="lblError" runat="server" CssClass="text-danger text-center"></asp:Label>

            </div>
        </div>
    </form>
</body>
</html>