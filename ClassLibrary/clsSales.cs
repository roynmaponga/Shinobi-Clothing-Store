using System;

namespace ClassLibrary
{
    public class clsSales
    {
        // private data members
        private Int32 mSaleID;
        private Int32 mOrderID;
        private DateTime mSaleDate;
        private decimal mTotalAmount;
        private string mPaymentMethod;
        private string mSaleStatus;
        private bool mIsRefunded;

        // public property for SaleID
        public Int32 SaleID
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

        // public property for OrderID
        public Int32 OrderID
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

        // public property for SaleDate
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

        // public property for TotalAmount
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

        // public property for PaymentMethod
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

        // public property for SaleStatus
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

        // public property for IsRefunded
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

        // Find method
        public bool Find(Int32 SaleID)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@SaleID", SaleID);

            DB.Execute("sproc_tblSales_FilterBySaleID");

            if (DB.Count == 1)
            {
                mSaleID = Convert.ToInt32(DB.DataTable.Rows[0]["SaleID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mSaleDate = Convert.ToDateTime(DB.DataTable.Rows[0]["SaleDate"]);
                mTotalAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalAmount"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentMethod"]);
                mSaleStatus = Convert.ToString(DB.DataTable.Rows[0]["SaleStatus"]);
                mIsRefunded = Convert.ToBoolean(DB.DataTable.Rows[0]["IsRefunded"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        // Valid method with 4 arguments
        // This is needed because your tstSales.cs file is using 4 arguments
        public string Valid(string SaleDate, string TotalAmount, string PaymentMethod, string SaleStatus)
        {
            string Error = "";

            DateTime SaleDateTemp;
            decimal TotalAmountTemp;

            // SaleDate validation
            if (SaleDate.Length == 0)
            {
                Error = Error + "The sale date may not be blank. ";
            }
            else
            {
                try
                {
                    SaleDateTemp = Convert.ToDateTime(SaleDate);

                    if (SaleDateTemp < DateTime.Now.Date.AddYears(-100))
                    {
                        Error = Error + "The sale date is too far in the past. ";
                    }

                    if (SaleDateTemp > DateTime.Now.Date.AddYears(100))
                    {
                        Error = Error + "The sale date is too far in the future. ";
                    }
                }
                catch
                {
                    Error = Error + "The sale date is not a valid date. ";
                }
            }

            // TotalAmount validation
            if (TotalAmount.Length == 0)
            {
                Error = Error + "The total amount may not be blank. ";
            }
            else
            {
                try
                {
                    TotalAmountTemp = Convert.ToDecimal(TotalAmount);

                    if (TotalAmountTemp < 0)
                    {
                        Error = Error + "The total amount cannot be negative. ";
                    }

                    if (TotalAmountTemp > 999999.99m)
                    {
                        Error = Error + "The total amount is too high. ";
                    }
                }
                catch
                {
                    Error = Error + "The total amount must be a valid number. ";
                }
            }

            // PaymentMethod validation
            if (PaymentMethod.Length == 0)
            {
                Error = Error + "The payment method may not be blank. ";
            }

            if (PaymentMethod.Length > 50)
            {
                Error = Error + "The payment method must be less than 50 characters. ";
            }

            // SaleStatus validation
            if (SaleStatus.Length == 0)
            {
                Error = Error + "The sale status may not be blank. ";
            }

            if (SaleStatus.Length > 50)
            {
                Error = Error + "The sale status must be less than 50 characters. ";
            }

            return Error;
        }

        // Valid method with 5 arguments
        public string Valid(string OrderID, string SaleDate, string TotalAmount, string PaymentMethod, string SaleStatus)
        {
            string Error = "";

            Int32 OrderIDTemp;

            // OrderID validation
            if (OrderID.Length == 0)
            {
                Error = Error + "The Order ID may not be blank. ";
            }
            else
            {
                try
                {
                    OrderIDTemp = Convert.ToInt32(OrderID);

                    if (OrderIDTemp < 1)
                    {
                        Error = Error + "The Order ID must be greater than zero. ";
                    }
                }
                catch
                {
                    Error = Error + "The Order ID must be a number. ";
                }
            }

            Error = Error + Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);

            return Error;
        }

        // Valid method with 6 arguments
        public string Valid(string OrderID, string SaleDate, string TotalAmount, string PaymentMethod, string SaleStatus, string IsRefunded)
        {
            string Error = "";

            Error = Error + Valid(OrderID, SaleDate, TotalAmount, PaymentMethod, SaleStatus);

            // IsRefunded validation
            if (IsRefunded.Length == 0)
            {
                Error = Error + "The refund status may not be blank. ";
            }
            else
            {
                try
                {
                    Convert.ToBoolean(IsRefunded);
                }
                catch
                {
                    Error = Error + "The refund status must be true or false. ";
                }
            }

            return Error;
        }

        // Valid method with 7 arguments
        public string Valid(string SaleID, string OrderID, string SaleDate, string TotalAmount, string PaymentMethod, string SaleStatus, string IsRefunded)
        {
            string Error = "";

            Int32 SaleIDTemp;

            // SaleID validation
            if (SaleID.Length == 0)
            {
                Error = Error + "The Sale ID may not be blank. ";
            }
            else
            {
                try
                {
                    SaleIDTemp = Convert.ToInt32(SaleID);

                    if (SaleIDTemp < 0)
                    {
                        Error = Error + "The Sale ID cannot be negative. ";
                    }
                }
                catch
                {
                    Error = Error + "The Sale ID must be a number. ";
                }
            }

            Error = Error + Valid(OrderID, SaleDate, TotalAmount, PaymentMethod, SaleStatus, IsRefunded);

            return Error;
        }
    }
}