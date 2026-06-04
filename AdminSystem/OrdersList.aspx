<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 557px; position: absolute; height: 15px" Text="lblError"></asp:Label>
            <asp:ListBox ID="lstOrdersList" runat="server" style="z-index: 1; left: 9px; top: 7px; position: absolute; height: 459px; width: 506px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 20px; top: 503px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 91px; top: 504px; position: absolute" Text="Edit" />
    </form>
</body>
</html>
