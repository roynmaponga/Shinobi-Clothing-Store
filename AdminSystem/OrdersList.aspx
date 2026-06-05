<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 628px; position: absolute; height: 17px" Text="lblError"></asp:Label>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 15px; top: 526px; position: absolute" Text="Enter by DeliveryAddress"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 242px; top: 521px; position: absolute"></asp:TextBox>
            <asp:ListBox ID="lstOrdersList" runat="server" style="z-index: 1; left: 7px; top: 21px; position: absolute; height: 368px; width: 506px" OnSelectedIndexChanged="lstOrdersList_SelectedIndexChanged"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 14px; top: 423px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 100px; top: 424px; position: absolute" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 182px; top: 425px; position: absolute; right: 803px" Text="Delete" />
        <asp:Button ID="btnApplyFilter_Click" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 9px; top: 571px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnclear" runat="server" OnClick="btnclear_Click" style="z-index: 1; left: 152px; top: 569px; position: absolute" Text="Clear Filter" />
    </form>
</body>
</html>
