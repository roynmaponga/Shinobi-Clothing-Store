<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

<title>Users Viewer</title>

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

<h2 class="text-center mb-4">

Users Viewer

</h2>

<div class="d-grid">

<asp:Button ID="BtnBack"
runat="server"
Text="Back"
CssClass="btn btn-dark rounded-pill"
OnClick="BtnBack_Click"/>

</div>

</div>

</div>

</form>

</body>

</html>