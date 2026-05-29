using System;
using ClassLibrary;

public partial class _1_Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplaySale();
        }
    }

    void DisplaySale()
    {
        if (Session["SaleID"] != null)
        {
            Int32 SaleID = Convert.ToInt32(Session["SaleID"]);

            clsSales ASale = new clsSales();

            Boolean Found = ASale.Find(SaleID);

            if (Found == true)
            {
                lblSaleID.Text = ASale.SaleID.ToString();
                lblOrderID.Text = ASale.OrderID.ToString();
                lblSaleDate.Text = ASale.SaleDate.ToShortDateString();
                lblTotalAmount.Text = ASale.TotalAmount.ToString("0.00");
                lblPaymentMethod.Text = ASale.PaymentMethod;
                lblSaleStatus.Text = ASale.SaleStatus;
                lblIsRefunded.Text = ASale.IsRefunded.ToString();
            }
            else
            {
                lblError.Text = "Sale record not found.";
            }
        }
        else
        {
            lblError.Text = "No Sale ID was selected.";
        }
    }

    protected void btnBackToList_Click(object sender, EventArgs e)
    {
        Response.Redirect("SalesList.aspx");
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}