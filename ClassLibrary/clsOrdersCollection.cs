using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        // Constructor for the class
        public clsOrdersCollection()
        {
            // Variable for the index
            Int32 Index = 0;
            // Variable to store the record count
            Int32 RecordCount = 0;
            // Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure we just created
            DB.Execute("sproc_tblOrders_SelectAll");
            // Get the count of records
            RecordCount = DB.Count;

            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank order object
                clsOrders AnOrder = new clsOrders();

                // Read in the fields for the current record matching your table columns
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.UserID = Convert.ToInt32(DB.DataTable.Rows[Index]["UserID"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                AnOrder.DeliveryAddress = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryAddress"]);
                AnOrder.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                AnOrder.IsPaid = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsPaid"]);

                // Add the record to the private data member List
                mOrdersList.Add(AnOrder);
                // Point to the next record
                Index++;
            }
        }

        // private data member for the List
        private List<clsOrders> mOrdersList = new List<clsOrders>();

        // public property for the Orders List
        public List<clsOrders> OrdersList
        {
            get
            {
                return mOrdersList;
            }
            set
            {
                mOrdersList = value;
            }
        }

        // public property for Count
        public int Count
        {
            get
            {
                return mOrdersList.Count;
            }
            set
            {
                // Leave blank
            }
        }

        // public property for ThisOrder
        public clsOrders ThisOrder { get; set; }
    }
}