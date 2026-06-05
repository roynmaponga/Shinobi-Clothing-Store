<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 102px">
            <asp:Label ID="lblOrderid" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Order ID"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderID" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 159px; top: 11px; position: absolute; width: 129px"></asp:TextBox>
        </div>
        <asp:TextBox ID="txtUserID" runat="server" OnTextChanged="TextBox2_TextChanged" style="z-index: 1; left: 160px; top: 50px; position: absolute; width: 129px"></asp:TextBox>
        <asp:Label ID="lblOrderdate" runat="server" style="z-index: 1; left: 9px; top: 92px; position: absolute" Text="OrderDate" width="72px"></asp:Label>
        <p>
            <asp:Label ID="lblUserid" runat="server" style="z-index: 1; left: 8px; top: 51px; position: absolute" Text="UserID" width="72px"></asp:Label>
            <asp:TextBox ID="txtOrderDate" runat="server" OnTextChanged="TextBox3_TextChanged" style="z-index: 1; left: 159px; top: 99px; position: absolute; width: 129px; height: 19px"></asp:TextBox>
        </p>
        <asp:Label ID="lblTotalamount" runat="server" style="z-index: 1; left: 10px; top: 138px; position: absolute" Text="TotalAmount" width="72px"></asp:Label>
        <asp:TextBox ID="txtTotalAmount" runat="server" OnTextChanged="TextBox4_TextChanged" style="z-index: 1; left: 158px; top: 134px; position: absolute; width: 129px"></asp:TextBox>
        <asp:Button ID="btmFind" runat="server" OnClick="btmFind_Click" style="z-index: 1; left: 328px; top: 31px; position: absolute" Text="Find" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblOrderstatus" runat="server" style="z-index: 1; left: 14px; top: 183px; position: absolute; height: 22px; right: 849px;" Text="OrderStatus" width="72px"></asp:Label>
        <asp:DropDownList ID="ddlOrderstatus" runat="server" style="z-index: 1; left: 157px; top: 179px; position: absolute" width="129px">
            <asp:ListItem>Out for delivery</asp:ListItem>
            <asp:ListItem>In transit</asp:ListItem>
            <asp:ListItem>Delivered</asp:ListItem>
        </asp:DropDownList>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkPaid" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 148px; top: 263px; position: absolute" Text="Paid" />
            <asp:Label ID="lblDeliveryAddress" runat="server" style="z-index: 1; left: 11px; top: 222px; position: absolute" Text="DeliveyAddress"></asp:Label>
            <asp:TextBox ID="txtDeliveryAddress" runat="server" style="z-index: 1; left: 155px; top: 221px; position: absolute"></asp:TextBox>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 12px; top: 362px; position: absolute" Text="OK" />
        <asp:Label ID="lblerror" runat="server" style="z-index: 1; left: 18px; top: 310px; position: absolute"></asp:Label>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 97px; top: 361px; position: absolute; margin-bottom: 0px" Text="Cancel" />
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 237px; top: 359px; position: absolute" Text="Return To the main menu" />
    </form>
</body>
</html>
