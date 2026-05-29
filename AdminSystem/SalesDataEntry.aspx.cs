using System;
using ClassLibrary;

public partial class SalesConfirmDelete : System.Web.UI.Page
{
    Int32 SaleID;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["SaleID"] != null)
        {
            SaleID = Convert.ToInt32(Session["SaleID"]);
        }
        else
        {
            Response.Redirect("SalesList.aspx");
        }
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsSalesCollection SalesList = new clsSalesCollection();

        SalesList.ThisSale.Find(SaleID);

        SalesList.Delete();

        Response.Redirect("SalesList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("SalesList.aspx");
    }
}