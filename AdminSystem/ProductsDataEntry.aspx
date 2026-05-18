<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>&nbsp;</p>
        <p>
&nbsp;<asp:Label ID="lblproductname" runat="server" style="z-index: 1; left: 233px; top: 91px; position: absolute; width: 89px" Text="Product name"></asp:Label>
            <asp:Label ID="lblsize" runat="server" style="z-index: 1; left: 239px; top: 169px; position: absolute; width: 57px" Text="Size"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="tstproductname" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 360px; top: 85px; position: absolute; height: 17px; width: 129px; margin-bottom: 10px"></asp:TextBox>
            <asp:TextBox ID="tstcategory" runat="server" style="z-index: 1; left: 360px; top: 125px; position: absolute; height: 16px; width: 130px; bottom: 510px;"></asp:TextBox>
            <asp:Label ID="lblcategory" runat="server" style="z-index: 1; left: 233px; top: 126px; position: absolute; height: 25px; width: 90px; margin-bottom: 0px" Text="Category"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblcolour" runat="server" style="z-index: 1; left: 238px; top: 205px; position: absolute; width: 68px; height: 16px" Text="colour"></asp:Label>
            <asp:TextBox ID="tstsize" runat="server" style="z-index: 1; left: 359px; top: 170px; position: absolute; width: 131px; height: 14px" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtcolor" runat="server" style="z-index: 1; left: 359px; top: 208px; position: absolute; height: 15px; width: 130px"></asp:TextBox>
            <asp:TextBox ID="tstprice" runat="server" style="z-index: 1; left: 360px; top: 244px; position: absolute; height: 15px; width: 128px"></asp:TextBox>
            <asp:TextBox ID="tststockquantitu" runat="server" style="z-index: 1; left: 363px; top: 289px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblprice" runat="server" style="z-index: 1; left: 237px; top: 245px; position: absolute" Text="Price"></asp:Label>
        <p>
            <asp:Label ID="lblstockquantity" runat="server" style="z-index: 1; left: 235px; top: 290px; position: absolute" Text="StockQuantity"></asp:Label>
        </p>
        <p>
            <asp:Button ID="lblok" runat="server" OnClick="lblok_Click" style="z-index: 1; left: 301px; top: 348px; position: absolute; width: 63px; right: 861px" Text="ok" />
        </p>
        <asp:Button ID="lblcancel" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 390px; top: 347px; position: absolute; height: 28px; width: 61px;" Text="cancel" />
    </form>
</body>
</html>
