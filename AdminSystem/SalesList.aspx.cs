using System;
using ClassLibrary;

public partial class SalesList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplaySales();

            if (Session["Username"] != null)
            {
                lblLoggedIn.Text = "Logged in as: " + Session["Username"].ToString();
            }
            else
            {
                lblLoggedIn.Text = "Logged in as: Guest";
            }
        }
    }

    void DisplaySales()
    {
        clsSalesCollection Sales = new clsSalesCollection();

        lstSalesList.DataSource = Sales.SalesList;
        lstSalesList.DataValueField = "SaleID";
        lstSalesList.DataTextField = "SaleStatus";
        lstSalesList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SaleID"] = -1;
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
        clsSalesCollection Sales = new clsSalesCollection();

        Sales.ReportBySaleStatus(txtSaleStatus.Text);

        lstSalesList.DataSource = Sales.SalesList;
        lstSalesList.DataValueField = "SaleID";
        lstSalesList.DataTextField = "SaleStatus";
        lstSalesList.DataBind();

        lblError.Text = "";
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtSaleStatus.Text = "";
        DisplaySales();
        lblError.Text = "";
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}