using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestingUsers
{
    [TestClass]
    public class TstUsers
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsUsers AUser = new ClsUsers();

            Assert.IsNotNull(AUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            ClsUsers AUser = new ClsUsers();

            Int32 TestData = 1;

            AUser.UserID = TestData;

            Assert.AreEqual(AUser.UserID, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            ClsUsers AUser = new ClsUsers();

            string TestData = "Roy";

            AUser.FirstName = TestData;

            Assert.AreEqual(AUser.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            ClsUsers AUser = new ClsUsers();

            string TestData = "Maponga";

            AUser.LastName = TestData;

            Assert.AreEqual(AUser.LastName, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            ClsUsers AUser = new ClsUsers();

            string TestData = "roy@test.com";

            AUser.Email = TestData;

            Assert.AreEqual(AUser.Email, TestData);
        }

        [TestMethod]
        public void PasswordHashPropertyOK()
        {
            ClsUsers AUser = new ClsUsers();

            string TestData = "Password123";

            AUser.PasswordHash = TestData;

            Assert.AreEqual(AUser.PasswordHash, TestData);
        }

        [TestMethod]
        public void CreatedAtPropertyOK()
        {
            ClsUsers AUser = new ClsUsers();

            DateTime TestData = DateTime.Now.Date;

            AUser.CreatedAt = TestData;

            Assert.AreEqual(AUser.CreatedAt, TestData);
        }

        [TestMethod]
        public void IsActivePropertyOK()
        {
            ClsUsers AUser = new ClsUsers();

            Boolean TestData = true;

            AUser.IsActive = TestData;

            Assert.AreEqual(AUser.IsActive, TestData);
        }

    }
}