using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // create a new instances of clsOrders
        clsOrders AnOrder = new clsOrders();

        // get the data from the session obkject
        AnOrder = (clsOrders)Session["AnOrder"];

        // display the data form web page screen
        Response.Write("Order ID :" + AnOrder.OrderID + "<br/>");

        Response.Write("User ID : " + AnOrder.UserID + "<br/>");

        Response.Write("Order Date : " + AnOrder.OrderDate + "<br/>");

        Response.Write("Total amount : £ " + AnOrder.TotalAmount + "<br/>");

        Response.Write("Delivery status : " + AnOrder.DeliveryStatus+ "<br/>");

        Response.Write("IS Paid : " + AnOrder.IsPaid + "<br/>");


    }
}