using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 productId;
    protected void Page_Load(object sender, EventArgs e)
    {
        productId = Convert.ToInt32(Session["productId"]);
    }

    protected void btnyes_Click(object sender, EventArgs e)
    {
        ClsproductCollection ProductList = new ClsproductCollection();

        Int32 ProductId;

        ProductId = Convert.ToInt32(Session["ProductId"]);

        ProductList.Thisproduct.Find(ProductId);

        ProductList.Delete();

        Response.Redirect("ProductsList.aspx");
    }

    protected void btnno_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProducrList.aspx");
    }
}