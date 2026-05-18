using ClassLibrary;
using Microsoft.Testing.Platform.Extensions.Messages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing2
{
    [TestClass]
    public class Tstnewproduct
    {
        public string Error { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            Clsnewproduct Anewproduct = new Clsnewproduct();
            Assert.IsNotNull(Anewproduct);
        }
        [TestMethod]
        public void ActivePropertyOK()

        {
            Clsnewproduct Anewproduct = new Clsnewproduct();
            Boolean TestData = true;
            Anewproduct.Active = TestData;
            Assert.AreEqual(Anewproduct.Active, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            Clsnewproduct Anewproduct = new Clsnewproduct();
            DateTime TestData = DateTime.Now.Date;
            Anewproduct.DateAdded = TestData;
            Assert.AreEqual(Anewproduct.DateAdded, TestData);

        }
        [TestMethod]
        public void ProductnamePropertyOK()
        {
            Clsnewproduct Anewproduct = new Clsnewproduct();
            string TestData = "Test Product";
            Anewproduct.Productname = TestData;
            Assert.AreEqual(Anewproduct.Productname, TestData);
        }
        [TestMethod]
        public void CategoryPropertyOK()
        {
            Clsnewproduct Anewproduct = new Clsnewproduct();
            string TestData = "Test Category";
            Anewproduct.Category = TestData;
            Assert.AreEqual(Anewproduct.Category, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            Clsnewproduct Anewproduct = new Clsnewproduct();
            decimal TestData = 9.99m;
            Anewproduct.Price = TestData;
            Assert.AreEqual(Anewproduct.Price, TestData);
        }
        [TestMethod]
        public void StockQuantityPropertyOK()
        {
            Clsnewproduct Anewproduct = new Clsnewproduct();
            int TestData = 100;
            Anewproduct.StockQuantity = TestData;
            Assert.AreEqual(Anewproduct.StockQuantity, TestData);
        }
        [TestMethod]

        public void ColorPropertyOK()
        {
            Clsnewproduct Anewproduct = new Clsnewproduct();
            string TestData = "Red";
            Anewproduct.Color = TestData;
            Assert.AreEqual(Anewproduct.Color, TestData);
        }
        [TestMethod]

        public void SizePropertyOK()
        {
            Clsnewproduct Anewproduct = new Clsnewproduct();
            string TestData = "Medium";
            Anewproduct.Size = TestData;
            Assert.AreEqual(Anewproduct.Size, TestData);
        }
        [TestMethod]
        public void HouseNoMin()
        {
            Clsnewproduct Anewproduct = new Clsnewproduct();
            string error = "";
            string color = "a";
            error = Anewproduct.Valid("category", color, "Medium", "9.99", "100", DateTime.Now.Date.ToString());
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void HouseNOMinPlusOne()
        {
            Clsnewproduct Anewproduct = new Clsnewproduct();
            string error = "";
            string color = "aa";
            error = Anewproduct.Valid(color, "category", "Medium", "9.99", "100", DateTime.Now.Date.ToString());

            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void HouseNoMaxLessOne()
        {
            Clsnewproduct Anewproduct = new Clsnewproduct();
            string error = "";
            string color = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            error = Anewproduct.Valid(color, "category", "Medium", "9.99", "100", DateTime.Now.Date.ToString());
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void HouseNoMid()
        {
            Clsnewproduct Anewproduct = new Clsnewproduct();
            string error = "";
            string color = "aaaaaaaaaaaaaaaaaaaaaa";
            error = Anewproduct.Valid(color, "category", "Medium", "9.99", "100", DateTime.Now.Date.ToString());
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void HouseNoPlusOne()
        {
            Clsnewproduct Anewproduct = new Clsnewproduct();
            string error = "";
            string color = "aaaaaaaaaaaaaaaaaaaaaaaaaa";
            error = Anewproduct.Valid(color, "category", "Medium", "9.99", "100", DateTime.Now.Date.ToString());
            Assert.AreNotEqual(error, "");
        }
        public string Valid(string color, string category, string size, string price, string stockquantity, string dateadded)
        {
            // Suppress IDE0060 for unused parameters, as the method signature may be required for tests or API compatibility.
#pragma warning disable IDE0060 // Remove unused parameter
            string error = "";

            if (color.Length < 1)
            {
                error += "The color may not be blank : ";
            }
            if (color.Length > 25)
            {
                error += "The color must be less than 25 characters : ";
            }

            return error;
#pragma warning restore IDE0060 // Remove unused parameter
        }
    }
