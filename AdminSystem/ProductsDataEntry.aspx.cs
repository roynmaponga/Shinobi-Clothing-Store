using ClassLibrary;
using System;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void lblok_Click(object sender, EventArgs e)
    {
        Clsproduct Aproduct = new Clsproduct();
        Aproduct.Colour = txtcolor.Text;
        Session["Aproduct"] = Aproduct;
        Response.Redirect("ProductsViewer.aspx");
    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
}