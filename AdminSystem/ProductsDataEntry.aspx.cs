using ClassLibrary;
using System;

public partial class _1_DataEntry : System.Web.UI.Page
{
  
    Int32 ProductId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductId = Convert.ToInt32(Session["ProductID"]);

        if (IsPostBack == false)
        {
            if (ProductId != -1)
            {
                DisplayProduct();
            }
        }
    }
    void DisplayProduct()
    {
        ClsproductCollection ProductList = new ClsproductCollection();
        ProductList.Thisproduct.Find(ProductId);
        txtproductname.Text = ProductList.Thisproduct.Productname;
        txtmoney.Text = ProductList.Thisproduct.price.ToString();
        txtstockquantity.Text = ProductList.Thisproduct.StockQuantity.ToString();
        txtsize.Text = ProductList.Thisproduct.size;
        txtcolor.Text = ProductList.Thisproduct.color;
        chkActive.Checked = ProductList.Thisproduct.Active;
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void lblok_Click(object sender, EventArgs e)
    {
        clsproduct Aproduct = new clsproduct();

        string productname = txtproductname.Text;
        string price = txtmoney.Text;
        string stockquantity = txtstockquantity.Text;
        string size = txtsize.Text;
        string colour = txtcolor.Text;
        string Active = chkActive.Checked.ToString();

        string error = "";

        if (error == "")
        {
            Aproduct.Productname = productname;
            Aproduct.price = Convert.ToDecimal(price);
            Aproduct.StockQuantity = Convert.ToInt32(stockquantity);
            Aproduct.size = size;
            Aproduct.color = colour;

            ClsproductCollection ProductList = new ClsproductCollection();
            if (ProductId == -1)
            {
                ProductList.Thisproduct = Aproduct;
                ProductList.Add();
            }
            else
            {
               Aproduct.ProductID = ProductId;
                ProductList.Thisproduct = Aproduct;
                ProductList.Update();
            }

            Response.Redirect("ProductsList.aspx");
        }
        else
        {
            lblError.Text = error;
        }
         
    


}
    
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void txtcolor_TextChanged(object sender, EventArgs e)
    {

    }
    
        }
    
