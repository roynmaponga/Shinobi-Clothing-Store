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

        /****************** FIND METHOD ******************/

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

        /****************** VALID METHOD ******************/

        public string Valid(string saleDate, string totalAmount, string paymentMethod, string saleStatus)
        {
            String Error = "";
            DateTime DateTemp;
            Decimal AmountTemp;

            // Sale Date validation
            try
            {
                DateTemp = Convert.ToDateTime(saleDate);

                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The sale date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The sale date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The sale date was not a valid date : ";
            }

            // Total Amount validation
            try
            {
                AmountTemp = Convert.ToDecimal(totalAmount);

                if (AmountTemp <= 0)
                {
                    Error = Error + "The total amount must be greater than 0 : ";
                }
            }
            catch
            {
                Error = Error + "The total amount was not a valid number : ";
            }

            // Payment Method validation
            if (paymentMethod.Length == 0)
            {
                Error = Error + "The payment method may not be blank : ";
            }

            if (paymentMethod.Length > 50)
            {
                Error = Error + "The payment method must be less than 50 characters : ";
            }

            // Sale Status validation
            if (saleStatus.Length == 0)
            {
                Error = Error + "The sale status may not be blank : ";
            }

            if (saleStatus.Length > 50)
            {
                Error = Error + "The sale status must be less than 50 characters : ";
            }

            return Error;
        }
    }
}