using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        ClsUserLogin AUser = new ClsUserLogin();

        Boolean Found = false;

        if (txtEmail.Text == "" || txtPassword.Text == "")
        {
            lblError.Text = "Enter email and password";

            return;
        }

        Found = AUser.FindUser(
                    txtEmail.Text,
                    txtPassword.Text);

        if (Found == true)
        {
            Session["UserID"] = AUser.UserID;

            Session["Email"] = AUser.UserName;

            Session["Department"] = AUser.Department;

            Response.Redirect("TeamMainMenu.aspx");
        }
        else
        {
            lblError.Text = "Login details incorrect";
        }


    }
    protected void imgLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

}