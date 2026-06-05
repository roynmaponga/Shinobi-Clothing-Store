using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLibrary
{
    [TestClass]
    public class ClsproductCollection
    {
        private List<clsproduct> mProductList = new List<clsproduct>();
        clsproduct mThisproduct = new clsproduct();
        public List<clsproduct> ProductList
        {
            get { return mProductList; }
            set { mProductList = value; }
        }
        public int Count
        {
            get { return mProductList.Count; }
            set
            { // we shall worry about this later
            }
        }
        public clsproduct Thisproduct
        {
            get { return mThisproduct; }
            set { mThisproduct = value; }
        }
        public ClsproductCollection()
        {
            // here we will add some hard coded data to make sure the list is not empty when we instantiate it
            clsproduct TestItem = new clsproduct();
            TestItem.Active = true;
            TestItem.Productname = "Test Product";
            TestItem.price = 9.99m;
            TestItem.StockQuantity = 100;
            TestItem.size = "Medium";
            TestItem.color = "Red";
            mProductList.Add(TestItem);
            TestItem = new clsproduct();
            TestItem.Active = true;
            TestItem.Productname = "Another Product";
            TestItem.Price = 19.99m;
            TestItem.StockQuantity = 50;
            TestItem.size = "Large";
            TestItem.color = "Blue";
            mProductList.Add(TestItem);
        }

        public ClsproductCollection(string productname)
        {
            Int32 Index = 0;

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblproducts_selectAll");

            Int32 RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsproduct Aproduct = new clsproduct();

                Aproduct.Productname = DB.DataTable.Rows[Index]["productname"].ToString();
                Aproduct.price = Convert.ToDecimal(DB.DataTable.Rows[Index]["price"]);
                Aproduct.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["stockQuantity"]);
                Aproduct.size = DB.DataTable.Rows[Index]["size"].ToString();
                Aproduct.color = DB.DataTable.Rows[Index]["colour"].ToString().Trim();

                ProductList.Add(Aproduct);

                Index++;
            }
        }



        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

       

            DB.AddParameter("@productname", Thisproduct.Productname);
            DB.AddParameter("@price", Thisproduct.price);
            DB.AddParameter("@size", Thisproduct.size);
            DB.AddParameter("@colour", Thisproduct.color);
            DB.AddParameter("@stockQuantity", Thisproduct.StockQuantity);
            DB.AddParameter("@category", Thisproduct.category);

            return Convert.ToInt32(DB.Execute("sproc_tblProducts_Insert"));
        }
        

        
        
            public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@id", Thisproduct.id);
            DB.AddParameter("@productname", Thisproduct.Productname);
            DB.AddParameter("@price", Thisproduct.price);
            DB.AddParameter("@size", Thisproduct.size);
            DB.AddParameter("@colour", Thisproduct.color);
            DB.AddParameter("@stockQuantity", Thisproduct.StockQuantity);
            DB.AddParameter("@category", Thisproduct.category);

            DB.Execute("sproc_tblproducts_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@id", Thisproduct.id);
            DB.Execute("sproc_tblproducts_Delete");
        }

        public void ReportByPostCode(string v)
        {
            
        }
    }
    }
    



