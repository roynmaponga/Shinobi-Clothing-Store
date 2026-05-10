using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Web.UI;

using System.Web.UI.WebControls;

using ClassLibrary;



public partial class _1_DataEntry : System.Web.UI.Page

{

    protected void Page_Load(object sender, EventArgs e)

    {



    }



    protected void btnOK_Click(object sender, EventArgs e)

    {

        clsSales ASale = new clsSales();



        ASale.SaleID = Convert.ToInt32(txtSaleID.Text);

        ASale.OrderID = Convert.ToInt32(txtOrderID.Text);

        ASale.SaleDate = Convert.ToDateTime(txtSaleDate.Text);

        ASale.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);

        ASale.PaymentMethod = txtPaymentMethod.Text;

        ASale.SaleStatus = txtSaleStatus.Text;

        ASale.IsRefunded = chkIsRefunded.Checked;



        Session["ASale"] = ASale;



        Response.Redirect("SalesViewer.aspx");

    }



    protected void btnCancel_Click(object sender, EventArgs e)

    {

        Response.Redirect("SalesList.aspx");

    }

}