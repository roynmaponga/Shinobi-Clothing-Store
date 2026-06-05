using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayProducts();
        }
    }

    void DisplayProducts()
    {
        ClsproductCollection Allproducts = new ClsproductCollection();

        lstproductList.DataSource = Allproducts.ProductList;
        lstproductList.DataValueField = "Productname";
        lstproductList.DataTextField = "Productname";
        lstproductList.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductID"] = -1;
        Response.Redirect("ProductsDataEntry.aspx");
    }

    protected void btmEdit_Click(object sender, EventArgs e)
    {
        Int32 ProductID;
        if (lstproductList.SelectedIndex != -1)
        {
            ProductID = Convert.ToInt32(lstproductList.SelectedValue);
            Session["ProductID"] = ProductID;
            Response.Redirect("ProductsDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ProductId;

        if (lstproductList.SelectedIndex != -1)
        {
            ProductId = Convert.ToInt32(lstproductList.SelectedValue);

            Session["ProductId"] = ProductId;

            Response.Redirect("ProductsConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a product to delete";
        }
    }
}