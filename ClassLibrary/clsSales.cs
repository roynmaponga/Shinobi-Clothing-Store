using System;

namespace ClassLibrary
{
    public class clsSales
    {
        private Int32 mSaleID;
        public int SaleID
        {
            get
            {
                return mSaleID;
            }
            set
            {
                mSaleID = value;
            }
        }

        private Int32 mOrderID;
        public int OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }

        private DateTime mSaleDate;
        public DateTime SaleDate
        {
            get
            {
                return mSaleDate;
            }
            set
            {
                mSaleDate = value;
            }
        }

        private decimal mTotalAmount;
        public decimal TotalAmount
        {
            get
            {
                return mTotalAmount;
            }
            set
            {
                mTotalAmount = value;
            }
        }

        private string mPaymentMethod;
        public string PaymentMethod
        {
            get
            {
                return mPaymentMethod;
            }
            set
            {
                mPaymentMethod = value;
            }
        }

        private string mSaleStatus;
        public string SaleStatus
        {
            get
            {
                return mSaleStatus;
            }
            set
            {
                mSaleStatus = value;
            }
        }

        private Boolean mIsRefunded;
        public bool IsRefunded
        {
            get
            {
                return mIsRefunded;
            }
            set
            {
                mIsRefunded = value;
            }
        }

        public bool Find(int SaleID)
        {
            mSaleID = 1;
            mOrderID = 1;
            mSaleDate = Convert.ToDateTime("10/05/2026");
            mTotalAmount = 21.00m;
            mPaymentMethod = "Card";
            mSaleStatus = "Completed";
            mIsRefunded = false;

            return true;
        }
    }
}