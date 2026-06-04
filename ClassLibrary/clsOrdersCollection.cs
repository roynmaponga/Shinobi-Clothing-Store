using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        //private data 
        List<clsOrders> mOrders = new List<clsOrders>();

        //
        clsOrders mThisOrder = new clsOrders();


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

                // Read in the fields for the current record safely checking for DBNull

                // OrderID (Primary Key - usually never null, but kept safe)
                AnOrder.OrderID = Convert.IsDBNull(DB.DataTable.Rows[Index]["OrderID"])
                    ? 0
                    : Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);

                // UserID (Allows Nulls in your database)
                AnOrder.UserID = Convert.IsDBNull(DB.DataTable.Rows[Index]["UserID"])
                    ? 0
                    : Convert.ToInt32(DB.DataTable.Rows[Index]["UserID"]);

                // OrderDate (Allows Nulls)
                AnOrder.OrderDate = Convert.IsDBNull(DB.DataTable.Rows[Index]["OrderDate"])
                    ? DateTime.Now
                    : Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);

                // OrderStatus (Allows Nulls)
                AnOrder.OrderStatus = Convert.IsDBNull(DB.DataTable.Rows[Index]["OrderStatus"])
                    ? ""
                    : Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);

                // DeliveryAddress (Allows Nulls)
                AnOrder.DeliveryAddress = Convert.IsDBNull(DB.DataTable.Rows[Index]["DeliveryAddress"])
                    ? ""
                    : Convert.ToString(DB.DataTable.Rows[Index]["DeliveryAddress"]);

                // TotalAmount (Allows Nulls)
                AnOrder.TotalAmount = Convert.IsDBNull(DB.DataTable.Rows[Index]["TotalAmount"])
                    ? 0.00m
                    : Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);

                // IsPaid (Allows Nulls)
                AnOrder.IsPaid = Convert.IsDBNull(DB.DataTable.Rows[Index]["IsPaid"])
                    ? false
                    : Convert.ToBoolean(DB.DataTable.Rows[Index]["IsPaid"]);

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
        public clsOrders ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            
            // adds a record to the database based on the values of mThisOrder
            // connect to the database
            clsDataConnection DB = new clsDataConnection();

            // set the parameters for the stored procedure
            
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@DeliveryAddress", mThisOrder.DeliveryAddress);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("@IsPaid", mThisOrder.IsPaid);

           

            // execute the query returning the primary key value
            return DB.Execute("sproc_tblOrders_Insert");
        }

        public void Update()
        {
            // update an existing record based on the values of thisOrder
            // connect to the database
            clsDataConnection DB = new clsDataConnection();

            // set the parameters for the new stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@UserID", mThisOrder.UserID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@DeliveryAddress", mThisOrder.DeliveryAddress);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("@IsPaid", mThisOrder.IsPaid);

            // execute the stored procedure
            DB.Execute("sproc_tblOrders_Update");
        }

        public void Delete()
        {

            // connect to the database
            clsDataConnection DB = new clsDataConnection();

            // CRITICAL: It MUST be the private backing field 'mThisOrder'
            DB.AddParameter("@OrderID", mThisOrder.OrderID);

            // execute the stored procedure
            DB.Execute("sproc_tblOrders_Delete");
        }

        public void ReportByOrderStatus(string v)
        {
            
        }
    }
    
}