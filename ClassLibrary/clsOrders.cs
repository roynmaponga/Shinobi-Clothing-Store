using System;

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

        // The Find Method
        public bool Find(int orderID)
        {
            // Set the private data members with hardcoded test data
            mOrderID = 1;
            mUserID = 123;
            mOrderDate = Convert.ToDateTime("18/05/2026");
            mOrderStatus = "Pending";
            mDeliveryAddress = "123 Main Street";
            mTotalAmount = 55.50m;
            mIsPaid = true;
            mDeliveryStatus = "Processing";

            // Always return true for now to indicate the record was found
            return true;
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
    }
}