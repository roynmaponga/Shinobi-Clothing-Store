<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 160px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
  <div style="width: 493px; height: 97px; margin-left: 200px">

      <p class="auto-style1" style="width: 326px; height: 88px">
&nbsp;&nbsp;&nbsp; Are you sure you want to delete this user?

    <br class="auto-style1" /><br class="auto-style1" />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="BtnYes"
        runat="server"
        Text="Yes"
        OnClick="BtnYes_Click" />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    &nbsp;

    <asp:Button ID="BtnNo"
        runat="server"
        Text="No"
        OnClick="BtnNo_Click" />

      </p>

</div>
    </form>
</body>
</html>
