using System;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtUsername.Text == "admin" && txtPassword.Text == "password")
        {
            // store the username in the session
            Session["Username"] = txtUsername.Text;

            // redirect to the team main menu
            Response.Redirect("TeamMainMenu.aspx");
        }
        else
        {
            lblError.Text = "Invalid username or password.";
        }
    }
}