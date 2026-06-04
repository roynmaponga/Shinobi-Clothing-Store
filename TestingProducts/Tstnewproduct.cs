using ClassLibrary;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace Testing2
{
    [TestClass]
    public class Tstnewproduct
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
            clsproductCollection Anewproduct = new clsproductCollection();
            Assert.IsNotNull(Anewproduct);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
            Boolean TestData = true;
            Anewproduct.Active = TestData;

            Assert.AreEqual(TestData, Anewproduct.Active);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
            DateTime TestData = DateTime.Now.Date;
            Anewproduct.DateAdded = TestData;

            Assert.AreEqual(TestData, Anewproduct.DateAdded);
        }

        [TestMethod]
        public void ProductnamePropertyOK()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
            string TestData = "Test Product";
            Anewproduct.Productname = TestData;

            Assert.AreEqual(TestData, Anewproduct.Productname);
        }

        [TestMethod]
        public void CategoryPropertyOK()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
            string TestData = "Test Category";
            Anewproduct.Category = TestData;

            Assert.AreEqual(TestData, Anewproduct.Category);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
            decimal TestData = 9.99m;
            Anewproduct.Price = TestData;

            Assert.AreEqual(TestData, Anewproduct.Price);
        }

        [TestMethod]
        public void StockQuantityPropertyOK()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
            int TestData = 100;
            Anewproduct.StockQuantity = TestData;

            Assert.AreEqual(TestData, Anewproduct.StockQuantity);
        }

        [TestMethod]
        public void ColorPropertyOK()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
            string TestData = "Red";
            Anewproduct.Color = TestData;

            Assert.AreEqual(TestData, Anewproduct.Color);
        }

        [TestMethod]
        public void SizePropertyOK()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
            string TestData = "Medium";
            Anewproduct.Size = TestData;

            Assert.AreEqual(TestData, Anewproduct.Size);
        }
        [TestMethod]
        public void colorMinLessOne()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
            Error = "";
            string color = "a";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);

        }
        [TestMethod]
        public void colorMin()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
            Error = "";
            string color = "a";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void colorMinPlusOne()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
            Error = "";
            string color = "aa";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void colorMaxLessOne()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
            Error = "";
            string color = "aaaaa";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void colorMax()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
            Error = "";
            string color = "aaaaaa";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void colormid()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
            Error = "";
            string color = "aaa";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void colorMaxPlusOne()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
            Error = "";
            string color = "aaaaa";
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void colorExtremeMax()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
            Error = "";
            string color = "";
            color = color.PadRight(500, 'a');
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);

        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
            Error = "";
            DateTime TestData;
            TestData = DateTime.Now.Date;
            TestData = TestData.AddYears(-100);
            string dateAdded = TestData.ToString();
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsproductCollection Anewproduct = new clsproductCollection();
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
            clsproductCollection Anewproduct = new clsproductCollection();
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
            clsproductCollection Anewproduct = new clsproductCollection();
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
            clsproductCollection Anewproduct = new clsproductCollection();
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
            clsproductCollection Anewproduct = new clsproductCollection();
            Error = "";
            DateTime TestData;
            TestData = DateTime.Now.Date;
            TestData = TestData.AddYears(100);
            string dateAdded = TestData.ToString();
            Error = Anewproduct.Valid(color, size, stockQuantity, price, productname, dateAdded, (string)active);
            Assert.AreEqual("", Error);
        }
    }
    }
