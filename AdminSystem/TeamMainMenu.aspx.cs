using System;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSales_Click(object sender, EventArgs e)
    {
        Response.Redirect("SalesList.aspx");
    }

    protected void btnOrders_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersList.aspx");
    }

    protected void btnProducts_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductsList.aspx");
    }

    protected void btnUsers_Click(object sender, EventArgs e)
    {
        Response.Redirect("UsersList.aspx");
    }
}