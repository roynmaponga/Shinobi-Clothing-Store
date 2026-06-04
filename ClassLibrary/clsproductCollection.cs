using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class clsproductCollection
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




        public clsproductCollection()
        { }




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
            mproductname = "ptoduct";
            mcategory = category;
            mprice = price;
            mcolor = "color";
            mstockquantity = stockQuantity;
            mdateaddede = dateAdded;
            mactive = true;
            return true;
        }

        public string Valid(string color, string price, string productname, string size, string stockQuantity, string dateAdded, string active)
        {
            return "";
        }
        public string Valid(string color, string price, string productname, string size, string stockQuantity, string dateAdded)
        {
            string Error = "";
            DateTime DateTemp;
            if (color.Length == 0)
            {
                Error = Error + "The color may not be blank : ";
            }
            if (color.Length > 5)
            {
                Error = Error + "The color must be less than 5 characters : ";
            }
            DateTemp = Convert.ToDateTime(dateAdded);
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past : ";
            }
            if (DateTemp > DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the future : ";
            }
            return Error;
        }
    }
}



