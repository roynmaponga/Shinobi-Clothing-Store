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
        Response.Write(
            "<h2>User Details</h2>" +
            "<br />First Name: " + Session["FirstName"] +
            "<br />Last Name: " + Session["LastName"] +
            "<br />Email: " + Session["Email"] +
            "<br />Password: " + Session["PasswordHash"] +
            "<br />Created At: " + Session["CreatedAt"] +
            "<br />Is Active: " + Session["IsActive"]
        );
    }

    protected void BtnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("UsersDataEntry.aspx");
    }
}