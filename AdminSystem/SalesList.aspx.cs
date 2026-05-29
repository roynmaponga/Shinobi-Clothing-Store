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
        lstSalesList.DataTextField = "SaleStatus";

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

    protected void btnApply_Click(object sender, EventArgs e)
    {
        // create an instance of the Sales collection
        clsSalesCollection Sales = new clsSalesCollection();

        // apply the filter using sale status
        Sales.ReportBySaleStatus(txtSaleStatus.Text);

        // display the filtered list
        lstSalesList.DataSource = Sales.SalesList;
        lstSalesList.DataValueField = "SaleID";
        lstSalesList.DataTextField = "SaleStatus";
        lstSalesList.DataBind();

        // clear error message
        lblError.Text = "";
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // clear the filter box
        txtSaleStatus.Text = "";

        // display all sales again
        DisplaySales();

        // clear error message
        lblError.Text = "";
    }
}