
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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

        string OrderID = txtOrderID.Text;
        string UserID = txtUserID.Text;
        String TotalAmount = txtTotalAmount.Text;
        string OrderDate = txtOrderDate.Text;
        string DeliveryStatus = ddlDeliveryStatus.SelectedValue;
        String Error = "";

        Error = AnOrder.Valid(OrderID, UserID, TotalAmount, OrderDate, DeliveryStatus);

        if (Error == "")
        {


            // capture order id
            AnOrder.OrderID = Convert.ToInt32(txtOrderID.Text);
            //capture user id
            AnOrder.UserID = Convert.ToInt32(txtUserID.Text);
            // capture total amount
            AnOrder.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
            // capture order date
            AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            //capture delivery status
            AnOrder.DeliveryStatus = ddlDeliveryStatus.SelectedValue;

            // apture is paid check box

            AnOrder.IsPaid = chkPaid.Checked;

            //create new instances of order collection
            clsOrdersCollection Orderslist = new clsOrdersCollection();
            //set the thisorder property
            Orderslist.ThisOrder = AnOrder;
            //aDD the new lsit
            Orderslist.Add();

            

            //navigate to the view page
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            lblerror.Text = Error;
        }
    }
}