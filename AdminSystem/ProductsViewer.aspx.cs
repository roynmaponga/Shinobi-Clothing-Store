using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary; 

public partial class _1Viewer : System.Web.UI.Page
{
    public clsproduct Aproduct { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        clsproduct clsproduct = new clsproduct(); 
        
        Aproduct=(clsproduct)Session["Aproduct"];
        Response.Write(Aproduct.color);
        Response.Write(Aproduct.size);
        Response.Write(Aproduct.price);
        Response.Write(Aproduct.StockQuantity);
        Response.Write(Aproduct.Productname);
    }
}