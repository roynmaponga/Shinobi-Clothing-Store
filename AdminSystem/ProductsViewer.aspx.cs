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
    public Clsproduct Aproduct { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        Clsproduct clsproduct = new Clsproduct(); 
        
        Aproduct=(Clsproduct)Session["Aproduct"];
        Response.Write(Aproduct.Colour);
    }
}