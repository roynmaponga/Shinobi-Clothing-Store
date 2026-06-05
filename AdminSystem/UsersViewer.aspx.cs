using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void BtnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("UsersDataEntry.aspx");
    }
    protected void imgLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}