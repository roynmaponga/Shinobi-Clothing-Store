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

            //store in session
            Session["FirstName"] = AUser.FirstName;
            Session["LastName"] = AUser.LastName;
            Session["Email"] = AUser.Email;
            Session["PasswordHash"] = AUser.PasswordHash;
            Session["CreatedAt"] = AUser.CreatedAt;
            Session["IsActive"] = AUser.IsActive;

            //redirect
            Response.Redirect("UsersViewer.aspx");
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

        UserID = Convert.ToInt32(txtUserID.Text);

        Found = AUser.Find(UserID);

        if (Found == true)
        {
            txtFirstName.Text = AUser.FirstName;

            txtLastName.Text = AUser.LastName;

            txtEmail.Text = AUser.Email;

            txtPasswordHash.Text = AUser.PasswordHash;

            txtCreatedAt.Text = AUser.CreatedAt.ToShortDateString();

            chkIsActive.Checked = AUser.IsActive;

            lblError.Text = "";
        }
        else
        {
            lblError.Text = "User not found";
        }
    }

}