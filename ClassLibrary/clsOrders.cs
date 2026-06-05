using System;
using System.Runtime.Serialization;

namespace ClassLibrary
{
    public class clsOrders
    {
        // Private data members
        private Int32 mOrderID;
        private Int32 mUserID;
        private DateTime mOrderDate;
        private string mOrderStatus;
        private string mDeliveryAddress;
        private decimal mTotalAmount;
        private bool mIsPaid;
        private string mDeliveryStatus;

        // OrderID Property
        public Int32 OrderID
        {
            get { return mOrderID; }
            set { mOrderID = value; }
        }

        // UserID Property
        public Int32 UserID
        {
            get { return mUserID; }
            set { mUserID = value; }
        }

        // OrderDate Property
        public DateTime OrderDate
        {
            get { return mOrderDate; }
            set { mOrderDate = value; }
        }

        // OrderStatus Property
        public string OrderStatus
        {
            get { return mOrderStatus; }
            set { mOrderStatus = value; }
        }

        // DeliveryAddress Property
        public string DeliveryAddress
        {
            get { return mDeliveryAddress; }
            set { mDeliveryAddress = value; }
        }

        // TotalAmount Property
        public decimal TotalAmount
        {
            get { return mTotalAmount; }
            set { mTotalAmount = value; }
        }

        // IsPaid Property
        public bool IsPaid
        {
            get { return mIsPaid; }
            set { mIsPaid = value; }
        }

        // DeliveryStatus Property
        public string DeliveryStatus
        {
            get { return mDeliveryStatus; }
            set { mDeliveryStatus = value; }
        }

        public bool Active { get; set; }

        // The Find Method
        public bool Find(int OrderID)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the order id to search for
            DB.AddParameter("@OrderID", OrderID);
            // execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderID");

            // if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                mDeliveryAddress = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAddress"]);
                mTotalAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalAmount"]);
                mIsPaid = Convert.ToBoolean(DB.DataTable.Rows[0]["IsPaid"]);

                // return that everything worked OK
                return true;
            }
            // if no record was found
            else
            {
                // return false indicating there is a problem
                return false;
            }
        }

        // function for the public validation method
        public string Valid(string userID, string orderDate, string orderStatus, string deliveryAddress, string totalAmount, string deliveryStatus)
        {
            // create a string variable to store the error
            String Error = "";
            // create a temporary variable to store date values
            DateTime DateTemp;
            // create an instance of DateTime to compare with DateTemp
            DateTime DateComp = DateTime.Now.Date;

            // ---- UserID Validation ----
            if (userID.Length == 0)
            {
                Error = Error + "The user ID may not be blank: ";
            }
            if (userID.Length > 6)
            {
                Error = Error + "The user ID must be less than 6 characters: ";
            }

            // ---- OrderDate Validation ----
            try
            {
                // copy the orderDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateComp) // compare orderDate with Date
                {
                    // record the error
                    Error = Error + "The date cannot be in the past: ";
                }
                // check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    // record the error
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                // record the error
                Error = Error + "The date was not a valid date: ";
            }

            // ---- OrderStatus Validation ----
            if (orderStatus.Length == 0)
            {
                Error = Error + "The order status may not be blank: ";
            }
            if (orderStatus.Length > 20)
            {
                Error = Error + "The order status must be less than 20 characters: ";
            }

            // ---- DeliveryAddress Validation ----
            if (deliveryAddress.Length == 0)
            {
                // record the error
                Error = Error + "The delivery address may not be blank: ";
            }
            if (deliveryAddress.Length > 50)
            {
                // record the error
                Error = Error + "The delivery address must be less than 50 characters: ";
            }

            // ---- TotalAmount Validation ----
            if (totalAmount.Length == 0)
            {
                Error = Error + "The total amount may not be blank: ";
            }
            if (totalAmount.Length > 10)
            {
                Error = Error + "The total amount must be less than 10 characters: ";
            }

            // ---- DeliveryStatus Validation ----
            if (deliveryStatus.Length == 0)
            {
                // record the error
                Error = Error + "The delivery status may not be blank: ";
            }
            if (deliveryStatus.Length > 20)
            {
                // record the error
                Error = Error + "The delivery status must be less than 20 characters: ";
            }

            // return any error messages
            return Error;
        }

        public string Valid(string orderID, string userID, string totalAmount, string orderDate, string deliveryStatus)
        {
            // create a string variable to store error messages
            string Error = "";

            // 1. Check if the orderID is blank
            if (string.IsNullOrEmpty(orderID))
            {
                Error = Error + "The Order ID cannot be blank. ";
            }

            // 2. Check if the userID is blank
            if (string.IsNullOrEmpty(userID))
            {
                Error = Error + "The User ID cannot be blank. ";
            }

            // 3. Logic for Order Date 
            try
            {
                
                DateTime TempDate;
                
                if (string.IsNullOrEmpty(orderDate))
                {
                    Error = Error + "The Order Date cannot be blank. ";
                }
                else if (!DateTime.TryParse(orderDate, out TempDate))
                {
                    Error = Error + "The date must be a valid calendar date format (e.g. dd/mm/yyyy). ";
                }
            }
            catch (Exception)
            {
                Error = Error + "Critical error validating date data. ";
            }

            //-----------logic for total amount value------------
            try
            {
                // temp variable to hold the decimal conversion check
                Decimal TempAmount;
                if (string.IsNullOrEmpty(totalAmount))
                {
                    Error = Error + "The Total Amount cannot be blank. ";
                }
                // check if it converts to a decimal cleanly and isn't a negative value
                else if (!Decimal.TryParse(totalAmount, out TempAmount))
                {
                    Error = Error + "The Total Amount must be a valid currency number. ";
                }
                else if (TempAmount < 0)
                {
                    Error = Error + "The Total Amount cannot be negative. ";
                }
            }
            catch (Exception)
            {
                Error = Error + "Critical error validating total amount. ";
            }

            //
            return Error;
        }

    }
}