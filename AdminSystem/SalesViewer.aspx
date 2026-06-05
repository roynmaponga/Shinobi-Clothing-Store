<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SalesViewer.aspx.cs" Inherits="_1_Viewer" %>



<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Sales Viewer</title>



    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>

</head>



<body class="bg-light">

    <form id="form1" runat="server">

        <div class="container mt-5">



            <div class="card shadow p-4 mx-auto" style="max-width: 650px;">



                <h2 class="text-center mb-4">Sales Viewer</h2>



                <div class="alert alert-info">

                    <strong>Sale record saved successfully.</strong>

                </div>



                <table class="table table-bordered table-striped">

                    <tr>

                        <th>Sale ID</th>

                        <td><asp:Label ID="lblSaleID" runat="server"></asp:Label></td>

                    </tr>

                    <tr>

                        <th>Order ID</th>

                        <td><asp:Label ID="lblOrderID" runat="server"></asp:Label></td>

                    </tr>

                    <tr>

                        <th>Sale Date</th>

                        <td><asp:Label ID="lblSaleDate" runat="server"></asp:Label></td>

                    </tr>

                    <tr>

                        <th>Total Amount</th>

                        <td><asp:Label ID="lblTotalAmount" runat="server"></asp:Label></td>

                    </tr>

                    <tr>

                        <th>Payment Method</th>

                        <td><asp:Label ID="lblPaymentMethod" runat="server"></asp:Label></td>

                    </tr>

                    <tr>

                        <th>Sale Status</th>

                        <td><asp:Label ID="lblSaleStatus" runat="server"></asp:Label></td>

                    </tr>

                    <tr>

                        <th>Is Refunded</th>

                        <td><asp:Label ID="lblIsRefunded" runat="server"></asp:Label></td>

                    </tr>

                </table>



                <div class="d-flex gap-2">

                    <asp:Button ID="btnBackToList" runat="server" Text="Back to Sales List" CssClass="btn btn-primary" OnClick="btnBackToList_Click" />

                    <asp:Button ID="btnMainMenu" runat="server" Text="Return to Main Menu" CssClass="btn btn-dark" OnClick="btnMainMenu_Click" />

                </div>



                <br />



                <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>



            </div>



        </div>

    </form>

</body>

</html>