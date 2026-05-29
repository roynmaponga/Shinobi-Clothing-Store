using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSalesCollection
    {
        private List<clsSales> mSalesList = new List<clsSales>();
        private clsSales mThisSale = new clsSales();

        public clsSalesCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblSales_SelectAll");

            PopulateArray(DB);
        }

        public List<clsSales> SalesList
        {
            get
            {
                return mSalesList;
            }
            set
            {
                mSalesList = value;
            }
        }

        public int Count
        {
            get
            {
                return mSalesList.Count;
            }
            set
            {
                // Count is based on SalesList.Count
            }
        }

        public clsSales ThisSale
        {
            get
            {
                return mThisSale;
            }
            set
            {
                mThisSale = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderID", mThisSale.OrderID);
            DB.AddParameter("@SaleDate", mThisSale.SaleDate);
            DB.AddParameter("@TotalAmount", mThisSale.TotalAmount);
            DB.AddParameter("@PaymentMethod", mThisSale.PaymentMethod);
            DB.AddParameter("@SaleStatus", mThisSale.SaleStatus);
            DB.AddParameter("@IsRefunded", mThisSale.IsRefunded);

            return DB.Execute("sproc_tblSales_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@SaleID", mThisSale.SaleID);
            DB.AddParameter("@OrderID", mThisSale.OrderID);
            DB.AddParameter("@SaleDate", mThisSale.SaleDate);
            DB.AddParameter("@TotalAmount", mThisSale.TotalAmount);
            DB.AddParameter("@PaymentMethod", mThisSale.PaymentMethod);
            DB.AddParameter("@SaleStatus", mThisSale.SaleStatus);
            DB.AddParameter("@IsRefunded", mThisSale.IsRefunded);

            DB.Execute("sproc_tblSales_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@SaleID", mThisSale.SaleID);

            DB.Execute("sproc_tblSales_Delete");
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            RecordCount = DB.Count;

            mSalesList = new List<clsSales>();

            while (Index < RecordCount)
            {
                clsSales ASale = new clsSales();

                ASale.SaleID = Convert.ToInt32(DB.DataTable.Rows[Index]["SaleID"]);
                ASale.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                ASale.SaleDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["SaleDate"]);
                ASale.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                ASale.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentMethod"]);
                ASale.SaleStatus = Convert.ToString(DB.DataTable.Rows[Index]["SaleStatus"]);
                ASale.IsRefunded = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsRefunded"]);

                mSalesList.Add(ASale);

                Index++;
            }
        }
    }
}