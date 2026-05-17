using System;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _2_SalesDataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // find controls from the ASPX page manually
        TextBox txtSaleID = (TextBox)FindControl("txtSaleID");
        TextBox txtOrderID = (TextBox)FindControl("txtOrderID");
        TextBox txtSaleDate = (TextBox)FindControl("txtSaleDate");
        TextBox txtTotalAmount = (TextBox)FindControl("txtTotalAmount");
        TextBox txtPaymentMethod = (TextBox)FindControl("txtPaymentMethod");
        TextBox txtSaleStatus = (TextBox)FindControl("txtSaleStatus");
        CheckBox chkIsRefunded = (CheckBox)FindControl("chkIsRefunded");
        Label lblError = (Label)FindControl("lblError");

        // create a new instance of clsSales
        clsSales ASale = new clsSales();

        // capture user input as strings first
        string SaleDate = txtSaleDate.Text;
        string TotalAmount = txtTotalAmount.Text;
        string PaymentMethod = txtPaymentMethod.Text;
        string SaleStatus = txtSaleStatus.Text;

        // validate the data
        string Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);

        if (Error == "")
        {
            ASale.SaleID = Convert.ToInt32(txtSaleID.Text);
            ASale.OrderID = Convert.ToInt32(txtOrderID.Text);
            ASale.SaleDate = Convert.ToDateTime(SaleDate);
            ASale.TotalAmount = Convert.ToDecimal(TotalAmount);
            ASale.PaymentMethod = PaymentMethod;
            ASale.SaleStatus = SaleStatus;
            ASale.IsRefunded = chkIsRefunded.Checked;

            Session["ASale"] = ASale;

            Response.Redirect("SalesViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SalesList.aspx");
    }
}