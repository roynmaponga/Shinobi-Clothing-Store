using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }
        void DisplayOrders()
    {
            // create an instance of the Orders collection
            clsOrdersCollection Orders = new clsOrdersCollection();

            // set the data source to list of orders in the collection
            lstOrdersList.DataSource = Orders.OrdersList;

            // set the name of the primary key
            lstOrdersList.DataValueField = "OrderID";

            // set the data field to display in the list box
            lstOrdersList.DataTextField = "OrderStatus";

            // bind the data to the list
            lstOrdersList.DataBind();
        }
    
}