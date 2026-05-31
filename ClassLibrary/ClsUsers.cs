using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClsUsers
    {
        private Int32 mUserID;

        public int UserID
        {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
            }
        }


        private string mFirstName;

        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }


        private string mLastName;

        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }

        private string mEmail;

        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        private string mPasswordHash;

        public string PasswordHash
        {
            get
            {
                return mPasswordHash;
            }
            set
            {
                mPasswordHash = value;
            }
        }


        private DateTime mCreatedAt;

        public DateTime CreatedAt
        {
            get
            {
                return mCreatedAt;
            }
            set
            {
                mCreatedAt = value;
            }
        }

        private Boolean mIsActive;

        public bool IsActive
        {
            get
            {
                return mIsActive;
            }
            set
            {
                mIsActive = value;
            }
        }

        public bool Find(int UserID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the user id to search for
            DB.AddParameter("@UserID", UserID);

            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FilterByUserID");

            //if one record is found
            if (DB.Count == 1)
            {
                //copy data from database to private variables
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPasswordHash = Convert.ToString(DB.DataTable.Rows[0]["PasswordHash"]);
                mCreatedAt = Convert.ToDateTime(DB.DataTable.Rows[0]["CreatedAt"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);

                //return true
                return true;
            }
            else
            {
                //return false
                return false;
            }
        }

        public string Valid(string firstName,
                    string lastName,
                    string email,
                    string passwordHash,
                    string createdAt)
        {
            //string variable to store the error message
            String Error = "";

            //temporary variable for date validation
            DateTime DateTemp;

            //FIRST NAME
            if (firstName.Length == 0)
            {
                Error = Error + "The first name may not be blank : ";
            }

            if (firstName.Length > 50)
            {
                Error = Error + "The first name must be less than 50 characters : ";
            }

            //LAST NAME
            if (lastName.Length == 0)
            {
                Error = Error + "The last name may not be blank : ";
            }

            if (lastName.Length > 50)
            {
                Error = Error + "The last name must be less than 50 characters : ";
            }

            //EMAIL
            if (email.Length == 0)
            {
                Error = Error + "The email may not be blank : ";
            }

            if (email.Length > 100)
            {
                Error = Error + "The email must be less than 100 characters : ";
            }

            //PASSWORD
            if (passwordHash.Length == 0)
            {
                Error = Error + "The password may not be blank : ";
            }

            if (passwordHash.Length > 255)
            {
                Error = Error + "The password must be less than 255 characters : ";
            }

            //DATE VALIDATION
            try
            {
                DateTemp = Convert.ToDateTime(createdAt);

                if (DateTemp.Date < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp.Date > DateTime.Now.Date.AddDays(1))
                {
                    Error = Error + "The date cannot be more than one day in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            //return any error messages
            return Error;
        }
    }
}