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

            <asp:Label ID="lblLoggedIn" runat="server" ForeColor="Blue"></asp:Label>

            <br />
            <br />

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

            <asp:Label ID="lblSaleStatus" runat="server" Text="Enter Sale Status:"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtSaleStatus" runat="server"></asp:TextBox>

            <br />
            <br />

            <asp:Button ID="btnApply" runat="server" Text="Apply Filter" OnClick="btnApply_Click" />
            &nbsp;
            <asp:Button ID="btnClear" runat="server" Text="Clear Filter" OnClick="btnClear_Click" />

            <br />
            <br />

            <asp:Button ID="btnReturn" runat="server" Text="Return to Main Menu" OnClick="btnReturn_Click" />

            <br />
            <br />

            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>