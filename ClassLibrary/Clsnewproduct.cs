using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class Clsnewproduct
    {
        private string mproductname;

        public string ProductName
        {
            get { return mproductname; }
            set { mproductname = value; }
        }

        private int mcategory;
        public int category
        {
            get { return mcategory; }
            set { mcategory = value; }
        }
        private decimal mprice;
        public decimal Price
        {
            get { return mprice; }
            set { mprice = value; }

        }
        private string mcolor;
        public string Color
        {
            get { return mcolor; }
            set { mcolor = value; }
        }
        private string msize;
        public string Size
        {
            get { return msize; }
            set { msize = value; }
        }
        private int mstockquantity;
        public int StockQuantity
        {
            get { return mstockquantity; }
            set { mstockquantity = value; }
        }
        private DateTime mdateaddede;
        public DateTime DateAdded
        {
            get { return mdateaddede; }
            set { mdateaddede = value; }
        }

        private bool mactive;
        public bool Active
        {
            get { return mactive; }
            set { mactive = value; }
        }
        



        public Clsnewproduct()
        {}




        public bool active { get; set; }
        public DateTime dateAdded { get; set; }
        public string Productname { get; set; }
        public string Category { get; set; }
        public decimal price { get; set; }
        public int stockQuantity { get; set; }
        public string color { get; set; }
        public string size { get; set; }
        public object Privet { get; set; }

        public bool Find(int productname)
        {
            mproductname = "Test Product";
            mcategory = 1;
            mprice = 9.99m;
            mcolor = "Red";
            mstockquantity= 111;
            mdateaddede = DateTime.Now.Date;
            mactive = true;
            return true;
        }

        public string Valid(string category, string v1, string v2, string v3, string v4, string v5, string v6)
        {
            throw new NotImplementedException();
        }

        public string Valid(string color, string v1, string v2, string v3, string v4, string v5)
        {
            throw new NotImplementedException();
        }
    }
}
