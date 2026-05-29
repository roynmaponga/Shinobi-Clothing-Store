<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SalesConfirmDelete.aspx.cs" Inherits="SalesConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete Sale</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Confirm Delete Sale</h2>

            <p>Are you sure you want to delete this sale?</p>

            <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" />
            &nbsp;
            <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" />
        </div>
    </form>
</body>
</html>