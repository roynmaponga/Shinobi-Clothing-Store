<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

<title>Users List</title>
    

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css"
rel="stylesheet" />

</head>

<body class="bg-light">

<form id="form1" runat="server">

<div class="container mt-5">

<div class="card shadow p-4 mx-auto"
style="max-width:700px; border-radius:20px;">

<div class="text-center mb-3">

<asp:ImageButton ID="imgLogo"
runat="server"
ImageUrl="~/Images/ShinobiLogo.jpg"
Width="80px"
OnClick="imgLogo_Click"/>

</div>

<h2 class="text-center mb-4 fw-bold">

Users List

</h2>

<asp:Label ID="lblMessage"
runat="server"
ClientIDMode="Static"
CssClass="text-success fw-bold d-block text-center mb-3">
</asp:Label>

<asp:ListBox ID="lstUsers"
runat="server"
Height="100px"
CssClass="form-control">
</asp:ListBox>

<br />

<div class="d-flex justify-content-center gap-3 mb-4">

<asp:Button ID="BtnAdd"
runat="server"
Text="Add"
CssClass="btn btn-success rounded-pill px-4"
OnClick="BtnAdd_Click"/>

<asp:Button ID="BtnEdit"
runat="server"
Text="Edit"
CssClass="btn btn-primary rounded-pill px-4"
OnClick="BtnEdit_Click"/>

<asp:Button ID="BtnDelete"
runat="server"
Text="Delete"
CssClass="btn btn-danger rounded-pill px-4"
OnClick="BtnDelete_Click"/>

</div>

<div class="mb-3">

<label class="form-label">

Filter By Email

</label>

<asp:TextBox ID="txtFilterEmail"
runat="server"
CssClass="form-control">
</asp:TextBox>

</div>

<div class="d-flex justify-content-center gap-3">

<asp:Button ID="BtnApplyFilter"
runat="server"
Text="Apply Filter"
CssClass="btn btn-dark rounded-pill px-4"
OnClick="BtnApplyFilter_Click"/>

<asp:Button ID="BtnClearFilter"
runat="server"
Text="Clear Filter"
CssClass="btn btn-secondary rounded-pill px-4"
OnClick="BtnClearFilter_Click"/>

</div>

</div>

</div>

</form>

</body>

</html>