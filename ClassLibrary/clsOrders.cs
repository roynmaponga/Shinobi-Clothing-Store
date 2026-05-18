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
    }
}