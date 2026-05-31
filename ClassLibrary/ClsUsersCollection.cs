using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClsUsersCollection
    {
        //private data member for the list
        List<ClsUsers> mUserList = new List<ClsUsers>();

        //private member for single object
        ClsUsers mThisUser = new ClsUsers();



        //constructor
        public ClsUsersCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            Int32 RecordCount;
            Int32 Index = 0;

            DB.Execute("sproc_tblUsers_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                ClsUsers AUser = new ClsUsers();

                AUser.UserID = Convert.ToInt32(DB.DataTable.Rows[Index]["UserID"]);
                AUser.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AUser.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AUser.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AUser.PasswordHash = Convert.ToString(DB.DataTable.Rows[Index]["PasswordHash"]);
                AUser.CreatedAt = Convert.ToDateTime(DB.DataTable.Rows[Index]["CreatedAt"]);
                AUser.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);

                mUserList.Add(AUser);

                Index++;
            }
        }

        public List<ClsUsers> UserList
        {
            get
            {
                return mUserList;
            }
            set
            {
                mUserList = value;
            }
        }

        public Int32 Count
        {
            get
            {
                return mUserList.Count;
            }
            set
            {
                // leave empty
            }
        }

        public ClsUsers ThisUser
        {
            get
            {
                return mThisUser;
            }
            set
            {
                mThisUser = value;
            }
        }
        public int Add()
        {
            //adds record to database
            clsDataConnection DB = new clsDataConnection();

            //set parameters
            DB.AddParameter("@FirstName", mThisUser.FirstName);
            DB.AddParameter("@LastName", mThisUser.LastName);
            DB.AddParameter("@Email", mThisUser.Email);
            DB.AddParameter("@PasswordHash", mThisUser.PasswordHash);
            DB.AddParameter("@CreatedAt", mThisUser.CreatedAt);
            DB.AddParameter("@IsActive", mThisUser.IsActive);

            //execute query
            return DB.Execute("sproc_tblUsers_Insert");
        }

        public void ReportByEmail(string Email)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Email", Email);

            DB.Execute("sproc_tblUsers_FilterByEmail");

            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 RecordCount;
            Int32 Index;

            RecordCount = DB.Count;

            Index = 0;

            mUserList = new List<ClsUsers>();

            while (Index < RecordCount)
            {
                ClsUsers AUser = new ClsUsers();

                AUser.UserID = Convert.ToInt32(DB.DataTable.Rows[Index]["UserID"]);
                AUser.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AUser.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AUser.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AUser.PasswordHash = Convert.ToString(DB.DataTable.Rows[Index]["PasswordHash"]);
                AUser.CreatedAt = Convert.ToDateTime(DB.DataTable.Rows[Index]["CreatedAt"]);
                AUser.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);

                mUserList.Add(AUser);

                Index++;
            }
        }
            public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@UserID", mThisUser.UserID);
            DB.AddParameter("@FirstName", mThisUser.FirstName);
            DB.AddParameter("@LastName", mThisUser.LastName);
            DB.AddParameter("@Email", mThisUser.Email);
            DB.AddParameter("@PasswordHash", mThisUser.PasswordHash);
            DB.AddParameter("@CreatedAt", mThisUser.CreatedAt);
            DB.AddParameter("@IsActive", mThisUser.IsActive);

            DB.Execute("sproc_tblUsers_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@UserID", mThisUser.UserID);

            DB.Execute("sproc_tblUsers_Delete");
        }
    }

 }

