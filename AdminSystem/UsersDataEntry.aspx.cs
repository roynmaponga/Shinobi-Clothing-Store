using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 UserID;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("UsersLogin.aspx");
        }
        if (!IsPostBack)
        {
            if (Session["UserID"] != null)
            {
                UserID = Convert.ToInt32(Session["UserID"]);

                DisplayUsers();
            }
        }
    }

    protected void imgLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void DisplayUsers()
    {
        ClsUsers AUser = new ClsUsers();

        Boolean Found = false;

        Found = AUser.Find(Convert.ToInt32(Session["UserID"]));

        if (Found == true)
        {
            txtUserID.Text = AUser.UserID.ToString();

            txtFirstName.Text = AUser.FirstName;

            txtLastName.Text = AUser.LastName;

            txtEmail.Text = AUser.Email;

            txtPasswordHash.Text = AUser.PasswordHash;

            txtCreatedAt.Text = AUser.CreatedAt.ToShortDateString();

            chkIsActive.Checked = AUser.IsActive;
        }
    }


    protected void BtnOK_Click(object sender, EventArgs e)
    {
        //create instance
        ClsUsers AUser = new ClsUsers();

        //capture values
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string Email = txtEmail.Text;
        string PasswordHash = txtPasswordHash.Text;
        string CreatedAt = txtCreatedAt.Text;

        //store error
        string Error = "";

        //validate
        Error = AUser.Valid(FirstName,
                            LastName,
                            Email,
                            PasswordHash,
                            CreatedAt);

        //if valid
        if (Error == "")
        {
            //assign properties
            AUser.FirstName = FirstName;
            AUser.LastName = LastName;
            AUser.Email = Email;
            AUser.PasswordHash = PasswordHash;
            AUser.CreatedAt = Convert.ToDateTime(CreatedAt);
            AUser.IsActive = chkIsActive.Checked;



            try
            {
                ClsUsersCollection UserList = new ClsUsersCollection();

                if (Session["UserID"] == null)
                {
                    UserList.ThisUser = AUser;

                    UserList.Add();
                }
                else
                {
                    AUser.UserID = Convert.ToInt32(Session["UserID"]);

                    UserList.ThisUser = AUser;

                    UserList.Update();

                    Session["UserID"] = null;
                }

                Response.Redirect("UsersList.aspx");
            }
            catch
            {
                lblError.Text = "Email already exists. Please use a unique email address.";
            }
        }
        else
        {
            //display errors
            lblError.Text = Error;
        }
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("UsersList.aspx");
    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        ClsUsers AUser = new ClsUsers();

        Int32 UserID;

        Boolean Found = false;

        if (txtUserID.Text == "")
        {
            lblError.Text = "Please enter details";

            return;
        }

        UserID = Convert.ToInt32(txtUserID.Text);

        Found = AUser.Find(UserID);

        if (Found == true)
        {
            txtFirstName.Text = AUser.FirstName;

            txtLastName.Text = AUser.LastName;

            txtEmail.Text = AUser.Email;

            txtPasswordHash.Text = AUser.PasswordHash;

            txtCreatedAt.Text =
                AUser.CreatedAt.ToShortDateString();

            chkIsActive.Checked = AUser.IsActive;

            lblError.Text = "";
        }
        else
        {
            lblError.Text = "User not found";
        }
    }

}