using ClassLibrary;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace Testing2
{
    [TestClass]
    public class Tstproduct
    {
        public string Error { get; private set; }
        public string size { get; private set; }
        public string stockQuantity { get; private set; }
        public string price { get; private set; }
        public string productname { get; private set; }
        public string dateAdded { get; private set; }
        public object active { get; private set; }
        public string color { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsproduct Anewproduct = new clsproduct();
            Assert.IsNotNull(Anewproduct);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsproduct Anewproduct = new clsproduct();
            Boolean TestData = true;
            Anewproduct.Active = TestData;

            Assert.AreEqual(TestData, Anewproduct.Active);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsproduct Anewproduct = new clsproduct();
            DateTime TestData = DateTime.Now.Date;
            Anewproduct.DateAdded = TestData;

            Assert.AreEqual(TestData, Anewproduct.DateAdded);
        }

        [TestMethod]
        public void ProductnamePropertyOK()
        {
            clsproduct Anewproduct = new clsproduct();
            string TestData = "Test Product";
            Anewproduct.Productname = TestData;

            Assert.AreEqual(TestData, Anewproduct.Productname);
        }

        [TestMethod]
        public void CategoryPropertyOK()
        {
            clsproduct Anewproduct = new clsproduct();
            string TestData = "Test Category";
            Anewproduct.Category = TestData;

            Assert.AreEqual(TestData, Anewproduct.Category);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsproduct Anewproduct = new clsproduct();
            decimal TestData = 9.99m;
            Anewproduct.Price = TestData;

            Assert.AreEqual(TestData, Anewproduct.Price);
        }

        [TestMethod]
        public void StockQuantityPropertyOK()
        {
            clsproduct Anewproduct = new clsproduct();
            int TestData = 100;
            Anewproduct.StockQuantity = TestData;

            Assert.AreEqual(TestData, Anewproduct.StockQuantity);
        }

        [TestMethod]
        public void ColorPropertyOK()
        {
            clsproduct Anewproduct = new clsproduct();
            string TestData = "Red";
            Anewproduct.Color = TestData;

            Assert.AreEqual(TestData, Anewproduct.Color);
        }

        [TestMethod]
        public void SizePropertyOK()
        {
            clsproduct Anewproduct = new clsproduct();
            string TestData = "Medium";
            Anewproduct.Size = TestData;

            Assert.AreEqual(TestData, Anewproduct.Size);
        }
        [TestMethod]
        public void colorMinLessOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string color = "a";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);

        }
        [TestMethod]
        public void colorMin()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string color = "a";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void colorMinPlusOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string color = "aa";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void colorMaxLessOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string color = "aaaaa";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void colorMax()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string color = "aaaaaa";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void colormid()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string color = "aaa";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void colorMaxPlusOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string color = "aaaaa";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void colorExtremeMax()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string color = "";
            color = color.PadRight(500, 'a');
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);

        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            DateTime TestData;
            TestData = DateTime.Now.Date;
            TestData = TestData.AddYears(-100);
            string dateAdded = TestData.ToString();
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }



        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            DateTime TestData;
            TestData = DateTime.Now.Date;
            TestData = TestData.AddDays(-1);
            string dateAdded = TestData.ToString();
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void DateAddedMin()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            DateTime TestData;
            TestData = DateTime.Now.Date;
            string dateAdded = TestData.ToString();
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            DateTime TestData;
            TestData = DateTime.Now.Date;
            TestData = TestData.AddDays(1);
            string dateAdded = TestData.ToString();
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void DateAddedMax()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            DateTime TestData;
            TestData = DateTime.Now.Date;
            TestData = TestData.AddYears(100);
            string dateAdded = TestData.ToString();
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void productnameMinLessOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string productname = "";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void productnameMin()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string productname = "a";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);

        }
        [TestMethod]
        public void productnameMinPlusOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string productname = "aa";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void productnameMaxLessOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string productname = "";
            productname = productname.PadRight(49, 'a');
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void productnameMax()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string productname = "";
            productname = productname.PadRight(50, 'a');
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void productnameMid()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string productname = "";
            productname = productname.PadRight(25, 'a');
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void productnameMaxPlusOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string productname = "";
            productname = productname.PadRight(51, 'a');
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void stockQuantityMinLessOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string stockQuantity = "-1";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void stockQuantityMin()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string stockQuantity = "0";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void stockQuantityMinPlusOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string stockQuantity = "1";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void stockQuantityMax()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string stockQuantity = "1000";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void stockQuantityMaxPlusOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string stockQuantity = "1001";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void stockQuantityMid()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string stockQuantity = "500";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void priceMinLessOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string price = "-0.01";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void priceMin()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string price = "0.00";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void priceMinPlusOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string price = "0.01";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void priceMax()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string price = "10000.00";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void priceMaxPlusOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string price = "10000.01";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);

        }
        [TestMethod]
        public void priceMid()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string price = "5000.00";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void sizeMinLessOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string size = "";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void sizeMin()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string size = "a";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void sizeMinPlusOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string size = "aa";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);

        }
        [TestMethod]
        public void sizeMaxLessOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string size = "";
            size = size.PadRight(49, 'a');
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void sizeMaxGreaterOne() {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string size = "";
            size = size.PadRight(50, 'a');
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void sizeMid()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string size = "";
            size = size.PadRight(25, 'a');
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void sizeMaxPlusOne()
        {
            clsproduct Anewproduct = new clsproduct();
            Error = "";
            string size = "";
            size = size.PadRight(51, 'a');
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
    }
    }