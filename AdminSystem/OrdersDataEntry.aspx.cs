
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // variable to store the primary key with page level scope
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the order to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            // if this is not a new record
            if (OrderID != -1)
            {
                // display the current data for the record
                DisplayOrder();
            }
        }
    }
        void DisplayOrder()
        {
            // create an instance of the order book
            clsOrdersCollection OrderBook = new clsOrdersCollection();

            // find the record to update
            OrderBook.ThisOrder.Find(OrderID);

            // display the data for the record
            txtOrderID.Text = OrderBook.ThisOrder.OrderID.ToString();
            txtUserID.Text = OrderBook.ThisOrder.UserID.ToString();
            txtOrderDate.Text = OrderBook.ThisOrder.OrderDate.ToString();
            ddlOrderstatus.SelectedValue = OrderBook.ThisOrder.OrderStatus;
            txtDeliveryAddress.Text = OrderBook.ThisOrder.DeliveryAddress;
            txtTotalAmount.Text = OrderBook.ThisOrder.TotalAmount.ToString();
            chkPaid.Checked = OrderBook.ThisOrder.IsPaid;
        }

    

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instances of clsOrder
        clsOrders AnOrder = new clsOrders();

        int OrderID = Convert.ToInt32(txtOrderID.Text);
        string UserID = txtUserID.Text;
        String TotalAmount = txtTotalAmount.Text;
        string OrderDate = txtOrderDate.Text;
        string OrderStatus = ddlOrderstatus.SelectedValue;
        string DeliveryAddress = txtDeliveryAddress.Text;
        String Error = "";

        Error = AnOrder.Valid(UserID, OrderDate, OrderStatus, DeliveryAddress, TotalAmount);
        if (Error == "")
        {
            // capture the order id
            AnOrder.OrderID = OrderID;
            // capture the user id
            AnOrder.UserID = Convert.ToInt32(UserID);
            // capture the order date
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            // capture the order status
            AnOrder.OrderStatus = OrderStatus;
            // capture the delivery address
            AnOrder.DeliveryAddress = DeliveryAddress;
            // capture the total amount
            AnOrder.TotalAmount = Convert.ToDecimal(TotalAmount);
            // capture is paid
            AnOrder.IsPaid = chkPaid.Checked;

            // create a new instance of the order collection
            clsOrdersCollection OrderList = new clsOrdersCollection();

            // if this is a new record 
            if (OrderID == -1)
            {
                // set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                // add the new record
                OrderList.Add();
            }
            // otherwise it must be an update
            else
            {
                // find the record to update
                OrderList.ThisOrder.Find(OrderID);
                // set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                // update the record
                OrderList.Update();
            }

            // redirect back to the list page
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            // display the error message
            lblerror.Text = Error;
        }
    }

    protected void btmFind_Click(object sender, EventArgs e)
    {
        // create an instance of the order class
        clsOrders AnOrder = new clsOrders();
        //create a variable to store the primary key
        Int32 OrderID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(OrderID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            ddlOrderstatus.SelectedValue = AnOrder.OrderStatus;
            txtDeliveryAddress.Text = AnOrder.DeliveryAddress;
            txtTotalAmount.Text = AnOrder.TotalAmount.ToString();
            chkPaid.Checked = AnOrder.IsPaid;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}