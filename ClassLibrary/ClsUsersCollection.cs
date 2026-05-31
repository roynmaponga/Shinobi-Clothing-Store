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

        //private member for single object
        private Int32 mCount;

        //constructor
        public ClsUsersCollection()
        {
            //test object
            ClsUsers TestItem = new ClsUsers();

            TestItem.UserID = 1;
            TestItem.FirstName = "Roy";
            TestItem.LastName = "Maponga";
            TestItem.Email = "roy@test.com";
            TestItem.PasswordHash = "Password123";
            TestItem.CreatedAt = DateTime.Now.Date;
            TestItem.IsActive = true;

            //add test item
            mUserList.Add(TestItem);
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
    }
}
