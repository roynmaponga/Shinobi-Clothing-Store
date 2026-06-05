using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["UserID"] == null)
        {
            Response.Redirect("UsersLogin.aspx");
        }

        if (!IsPostBack)
        {
            DisplayUsers();

            if (Session["DeleteMessage"] != null)
            {
                lblMessage.Text =
                    Session["DeleteMessage"].ToString();

                Session["DeleteMessage"] = null;
            }
        }
    }

    void DisplayUsers()
    {
        ClsUsersCollection Users = new ClsUsersCollection();

        lstUsers.DataSource = Users.UserList;

        lstUsers.DataValueField = "UserID";

        lstUsers.DataTextField = "Email";

        lstUsers.DataBind();
    }
    protected void BtnAdd_Click(object sender, EventArgs e)
    {
         Response.Redirect("UsersDataEntry.aspx");
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        Int32 UserID;

        if (lstUsers.SelectedIndex != -1)
        {
            UserID = Convert.ToInt32(lstUsers.SelectedValue);

            Session["UserID"] = UserID;

            Response.Redirect("UsersDataEntry.aspx");
        }
        else
        {
            Response.Write("Please select a user to edit.");
        }
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        Int32 UserID;

        if (lstUsers.SelectedIndex != -1)
        {
            UserID = Convert.ToInt32(lstUsers.SelectedValue);

            Session["UserID"] = UserID;

            Response.Redirect("UsersConfirmDelete.aspx");
        }
        else
        {
            Response.Write("Please select a user to delete.");
        }
    }

    protected void BtnApplyFilter_Click(object sender, EventArgs e)
    {
        ClsUsersCollection Users = new ClsUsersCollection();

        Users.ReportByEmail(txtFilterEmail.Text);

        lstUsers.DataSource = Users.UserList;

        lstUsers.DataValueField = "UserID";

        lstUsers.DataTextField = "Email";

        lstUsers.DataBind();
    }

    protected void BtnClearFilter_Click(object sender, EventArgs e)
    {
        txtFilterEmail.Text = "";

        DisplayUsers();
    }

        protected void lnkLogo_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

         protected void imgLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
