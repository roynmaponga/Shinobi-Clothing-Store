<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersLogin.aspx.cs" Inherits="_1_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />

</head>

<body class="bg-light">

<form id="form1" runat="server">

<div class="container mt-5">

<div class="card shadow p-4 mx-auto" style="max-width:500px;">

<div class="text-center mb-3">

<asp:ImageButton ID="imgLogo"
runat="server"
ImageUrl="~/Images/ShinobiLogo.jpg"
Width="90px"
CssClass="img-fluid"
OnClick="imgLogo_Click" />

</div>

<h2 class="text-center mb-4">

User Login

</h2>

<div class="mb-3">

<label>Email</label>

<asp:TextBox ID="txtEmail"
runat="server"
CssClass="form-control">
</asp:TextBox>

</div>

<div class="mb-3">

<label>Password</label>

<asp:TextBox ID="txtPassword"
runat="server"
TextMode="Password"
CssClass="form-control">
</asp:TextBox>

</div>

<asp:Button ID="btnLogin"
runat="server"
Text="Login"
CssClass="btn btn-dark w-100"
OnClick="btnLogin_Click" />

<br />
<br />

<asp:Label ID="lblError"
runat="server"
CssClass="text-danger">
</asp:Label>

</div>

</div>

</form>

</body>
</html>