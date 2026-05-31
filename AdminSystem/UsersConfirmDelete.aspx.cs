using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 UserID;

    protected void Page_Load(object sender, EventArgs e)
    {
        UserID = Convert.ToInt32(Session["UserID"]);
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        ClsUsersCollection UserBook = new ClsUsersCollection();

        UserBook.ThisUser.Find(UserID);

        UserBook.Delete();

        Response.Redirect("UsersList.aspx");
    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("UsersList.aspx");
    }
}