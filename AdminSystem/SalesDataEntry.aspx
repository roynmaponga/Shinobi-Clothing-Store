<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SalesDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
    <h2>Sales Data Entry</h2>

    <asp:Label ID="lblSaleID" runat="server" Text="Sale ID"></asp:Label>
    <asp:TextBox ID="txtSaleID" runat="server"></asp:TextBox>
    <br /><br />

    <asp:Label ID="lblOrderID" runat="server" Text="Order ID"></asp:Label>
    <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
    <br /><br />

    <asp:Label ID="lblSaleDate" runat="server" Text="Sale Date"></asp:Label>
    <asp:TextBox ID="txtSaleDate" runat="server"></asp:TextBox>
    <br /><br />

    <asp:Label ID="lblTotalAmount" runat="server" Text="Total Amount"></asp:Label>
    <asp:TextBox ID="txtTotalAmount" runat="server"></asp:TextBox>
    <br /><br />

    <asp:Label ID="lblPaymentMethod" runat="server" Text="Payment Method"></asp:Label>
    <asp:TextBox ID="txtPaymentMethod" runat="server"></asp:TextBox>
    <br /><br />

    <asp:Label ID="lblSaleStatus" runat="server" Text="Sale Status"></asp:Label>
    <asp:TextBox ID="txtSaleStatus" runat="server"></asp:TextBox>
    <br /><br />

    <asp:Label ID="lblIsRefunded" runat="server" Text="Is Refunded"></asp:Label>
    <asp:CheckBox ID="chkIsRefunded" runat="server" />
    <br /><br />

    <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br /><br />

    <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
</div>
    </form>
</body>
</html>
