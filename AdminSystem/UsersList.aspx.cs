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
        if (!IsPostBack)
        {
            DisplayUsers();
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



}
