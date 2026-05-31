<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

    <asp:ListBox ID="lstUsers"
        runat="server"
        Height="250px"
        Width="600px">
    </asp:ListBox>

    <br /><br />

    <asp:Button ID="BtnAdd"
        runat="server"
        Text="Add"
        OnClick="BtnAdd_Click" />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="BtnEdit"        
        runat="server"
        Text="Edit"
        OnClick="BtnEdit_Click" />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="BtnDelete"
        runat="server"
        Text="Delete"
        OnClick="BtnDelete_Click" />

</div>
    </form>
</body>
</html>
