using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClsUserLogin
    {
        private Int32 mUserID;
        private string mUserName;
        private string mPassword;
        private string mDepartment;

        public Int32 UserID
        {
            get { return mUserID; }
            set { mUserID = value; }
        }

        public string UserName
        {
            get { return mUserName; }
            set { mUserName = value; }
        }

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        public string Department
        {
            get { return mDepartment; }
            set { mDepartment = value; }
        }

        public bool FindUser(string UserName, string Password)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@UserName", UserName);

            DB.AddParameter("@Password", Password);

            DB.Execute("sproc_tblUsers_FindUserNamePW");

            if (DB.Count == 1)
            {
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);

                mUserName = Convert.ToString(DB.DataTable.Rows[0]["Email"]);

                mPassword = Convert.ToString(DB.DataTable.Rows[0]["PasswordHash"]);

                mDepartment = "Users";

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
