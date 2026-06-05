<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<title>Users Data Entry</title>

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />

</head>

<body class="bg-light">

<form id="form1" runat="server">

<div class="container d-flex justify-content-center mt-4">

<div class="card shadow p-4" style="width:500px; border-radius:20px;">

<div class="text-center mb-3">

<asp:ImageButton ID="imgLogo"
runat="server"
ImageUrl="~/Images/ShinobiLogo.jpg"
Width="90px"
OnClick="imgLogo_Click"/>

</div>

<h2 class="text-center mb-3 fw-bold"
style="font-size:2rem;">

User Data Entry

</h2>

<div class="mb-3">

<label>User ID</label>

<asp:TextBox ID="txtUserID"
runat="server"
CssClass="form-control">
</asp:TextBox>

</div>

<div class="mb-3">

<label>First Name</label>

<asp:TextBox ID="txtFirstName"
runat="server"
CssClass="form-control">
</asp:TextBox>

</div>

<div class="mb-3">

<label>Last Name</label>

<asp:TextBox ID="txtLastName"
runat="server"
CssClass="form-control">
</asp:TextBox>

</div>

<div class="mb-3">

<label>Email</label>

<asp:TextBox ID="txtEmail"
runat="server"
CssClass="form-control">
</asp:TextBox>

</div>

<div class="mb-3">

<label>Password</label>

<asp:TextBox ID="txtPasswordHash"
runat="server"
CssClass="form-control"
TextMode="Password">
</asp:TextBox>

</div>

<asp:TextBox ID="txtCreatedAt"
runat="server"
CssClass="form-control"
TextMode="Date">
</asp:TextBox>

<div class="form-check mt-3 mb-4">

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

<asp:CheckBox ID="chkIsActive"
runat="server" />

<label class="form-check-label">

Active User&nbsp; </label>

</div>

<div class="d-flex justify-content-between gap-2">

<asp:Button ID="BtnOK"
runat="server"
Text="OK"
CssClass="btn btn-success flex-fill rounded-pill"
OnClick="BtnOK_Click" />

<asp:Button ID="BtnFind"
runat="server"
Text="Find"
CssClass="btn btn-primary flex-fill rounded-pill"
OnClick="BtnFind_Click" />

<asp:Button ID="BtnCancel"
runat="server"
Text="Cancel"
CssClass="btn btn-danger flex-fill rounded-pill"
OnClick="BtnCancel_Click" />


</div>

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