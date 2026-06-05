<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

<title>Delete User</title>

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css"
rel="stylesheet" />

</head>

<body class="bg-light">

<form id="form1" runat="server">

<div class="container mt-5">

<div class="card shadow p-4 mx-auto"
style="max-width:500px; border-radius:20px;">

<div class="text-center mb-3">

<asp:ImageButton ID="imgLogo"
runat="server"
ImageUrl="~/Images/ShinobiLogo.jpg"
Width="80px"
OnClick="imgLogo_Click"/>

</div>

<h2 class="text-center fw-bold mb-4">

Delete User

</h2>

<p class="text-center">

Are you sure you want to delete this user?

</p>

<div class="d-flex justify-content-center gap-3 mt-4">

<asp:Button ID="BtnYes"
runat="server"
Text="Yes"
CssClass="btn btn-danger rounded-pill px-5"
OnClick="BtnYes_Click"/>

<asp:Button ID="BtnNo"
runat="server"
Text="No"
CssClass="btn btn-secondary rounded-pill px-5"
OnClick="BtnNo_Click"/>

</div>

</div>

</div>

</form>

</body>

</html>