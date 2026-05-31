using System;
using ClassLibrary;

public partial class SalesConfirmDelete : System.Web.UI.Page
{
    Int32 SaleID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // get the SaleID from the session object
        SaleID = Convert.ToInt32(Session["SaleID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // create a new instance of the sales collection
        clsSalesCollection AllSales = new clsSalesCollection();

        // find the record to delete
        AllSales.ThisSale.Find(SaleID);

        // delete the record
        AllSales.Delete();

        // redirect back to the sales list
        Response.Redirect("SalesList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        // redirect back to the sales list without deleting
        Response.Redirect("SalesList.aspx");
    }
}