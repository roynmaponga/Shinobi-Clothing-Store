using System;
using ClassLibrary;

public partial class SalesList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplaySales();
        }
    }

    void DisplaySales()
    {
        // create an instance of the Sales collection
        clsSalesCollection Sales = new clsSalesCollection();

        // set the data source to the list of sales in the collection
        lstSalesList.DataSource = Sales.SalesList;

        // set the name of the primary key
        lstSalesList.DataValueField = "SaleID";

        // set the data field to display
        lstSalesList.DataTextField = "SaleID";

        // bind the data to the list
        lstSalesList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["SaleID"] = -1;

        // redirect to the data entry page
        Response.Redirect("SalesDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 SaleID;

        if (lstSalesList.SelectedIndex != -1)
        {
            SaleID = Convert.ToInt32(lstSalesList.SelectedValue);

            Session["SaleID"] = SaleID;

            Response.Redirect("SalesDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a sale to edit.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 SaleID;

        if (lstSalesList.SelectedIndex != -1)
        {
            SaleID = Convert.ToInt32(lstSalesList.SelectedValue);

            Session["SaleID"] = SaleID;

            Response.Redirect("SalesConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a sale to delete.";
        }
    }
}