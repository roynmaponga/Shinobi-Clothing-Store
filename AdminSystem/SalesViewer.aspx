using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSales ASale = (clsSales)Session["ASale"];

        Response.Write("Sale ID: " + ASale.SaleID + "<br />");
        Response.Write("Order ID: " + ASale.OrderID + "<br />");
        Response.Write("Sale Date: " + ASale.SaleDate.ToShortDateString() + "<br />");
        Response.Write("Total Amount: " + ASale.TotalAmount + "<br />");
        Response.Write("Payment Method: " + ASale.PaymentMethod + "<br />");
        Response.Write("Sale Status: " + ASale.SaleStatus + "<br />");
        Response.Write("Is Refunded: " + ASale.IsRefunded + "<br />");
    }
}
