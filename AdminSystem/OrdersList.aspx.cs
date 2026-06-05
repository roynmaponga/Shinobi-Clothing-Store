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
        lstOrdersList.DataTextField = "DeliveryAddress";

        // bind the data to the list
        lstOrdersList.DataBind();
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;

        Response.Redirect("OrdersDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be edited
        Int32 OrderID;

        // if a record has been selected from the list
        if (lstOrdersList.SelectedIndex != -1)
        {
            // get the primary key value of the record to edit
            OrderID = Convert.ToInt32(lstOrdersList.SelectedValue);

            // store the data in the session object
            Session["OrderID"] = OrderID;

            // redirect to the edit page
            Response.Redirect("OrdersDataEntry.aspx");
        }
        else // if no record has been selected
        {
            // display an error message
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be deleted
        Int32 OrderID;

        // if a record has been selected from the list
        if (lstOrdersList.SelectedIndex != -1)
        {
            // get the primary key value of the record to delete
            OrderID = Convert.ToInt32(lstOrdersList.SelectedValue);

            // store the data in the session object
            Session["OrderID"] = OrderID;

            // redirect to the delete page
            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        // if no record has been selected
        else
        {
            // display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)

    {
        // create an instance of the order collection object
        clsOrdersCollection AnOrder = new clsOrdersCollection();
        // retrieve the value of order status from the presentation layer
        AnOrder.ReportByOrderStatus(txtFilter.Text);

        // CHANGE THIS TO ORDERSLIST (WITH AN 'S')
        lstOrdersList.DataSource = AnOrder.OrdersList;

        // set the name of the primary key
        lstOrdersList.DataValueField = "OrderID";
        // set the name of the field to display
        lstOrdersList.DataTextField = "DeliveryAddress";
        // bind the data to the list
        lstOrdersList.DataBind();
    }

    protected void btnclear_Click(object sender, EventArgs e)

    {
        // create an instance of the order object
        clsOrdersCollection AnOrder = new clsOrdersCollection();
        // set an empty string
        AnOrder.ReportByOrderStatus("");
        // clear any existing filter to tidy up the interface
        txtFilter.Text = "";

        // CHANGE THIS TO ORDERSLIST (WITH AN 'S')
        lstOrdersList.DataSource = AnOrder.OrdersList;

        // set the name of the primary key
        lstOrdersList.DataValueField = "OrderID";
        // set the name of the field to display
        lstOrdersList.DataTextField = "DeliveryAddress";
        // bind the data to the list
        lstOrdersList.DataBind();
    }

    protected void lstOrdersList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}