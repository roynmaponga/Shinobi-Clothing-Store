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

            Int32 TestData = 3;

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

            string TestData = "roymaponga@email.com";

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

        [TestMethod]
        public void FindMethodOK()
        {
            ClsUsers AUser = new ClsUsers();

            Boolean Found = false;

            Int32 UserID = 3;

            Found = AUser.Find(UserID);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserIDFound()
        {
            ClsUsers AUser = new ClsUsers();

            Boolean Found = false;

            Boolean OK = true;

            Int32 UserID = 3;

            Found = AUser.Find(UserID);

            if (AUser.UserID != 3)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            ClsUsers AUser = new ClsUsers();

            Boolean Found = false;

            Boolean OK = true;

            Int32 UserID = 3;

            Found = AUser.Find(UserID);

            if (AUser.FirstName != "Roy")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            Error = AUser.Valid("Roy",
                                "Maponga",
                                "roymaponga@email.com",
                                "Password123",
                                DateTime.Now.Date.ToString());

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string FirstName = "";

            Error = AUser.Valid(FirstName,
                                "Maponga",
                                "roymaponga@email.com",
                                "Password123",
                                DateTime.Now.Date.ToString());

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void FirstNameMin()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string FirstName = "R";

            Error = AUser.Valid(FirstName,
                                "Maponga",
                                "roymaponga@email.com",
                                "Password123",
                                DateTime.Now.Date.ToString());

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void FirstNameMax()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string FirstName = "";

            FirstName = FirstName.PadRight(50, 'R');

            Error = AUser.Valid(FirstName,
                                "Maponga",
                                "roymaponga@email.com",
                                "Password123",
                                DateTime.Now.Date.ToString());

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string FirstName = "";

            FirstName = FirstName.PadRight(51, 'R');

            Error = AUser.Valid(FirstName,
                                "Maponga",
                                "roymaponga@email.com",
                                "Password123",
                                DateTime.Now.Date.ToString());

            Assert.AreNotEqual("", Error);
        }

        //GOOD TEST DATA
        string FirstName = "Roy";
        string LastName = "Maponga";
        string Email = "roymaponga@email.com";
        string PasswordHash = "Password123";
        string CreatedAt = DateTime.Now.Date.ToString();


        //====================================================
        // LAST NAME TESTS
        //====================================================

        [TestMethod]
        public void LastNameMinLessOne()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string LastName = "";

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void LastNameMin()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string LastName = "A";

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void LastNameMid()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string LastName = "Maponga";

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void LastNameMax()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string LastName = "";

            LastName = LastName.PadRight(50, 'A');

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string LastName = "";

            LastName = LastName.PadRight(51, 'A');

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreNotEqual("", Error);
        }


        //====================================================
        // EMAIL TESTS
        //====================================================

        [TestMethod]
        public void EmailMinLessOne()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string Email = "";

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void EmailMin()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string Email = "a";

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void EmailMid()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string Email = "roy@email.com";

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void EmailMax()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string Email = "";

            Email = Email.PadRight(100, 'A');

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string Email = "";

            Email = Email.PadRight(101, 'A');

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreNotEqual("", Error);
        }


        //====================================================
        // PASSWORD TESTS
        //====================================================

        [TestMethod]
        public void PasswordMinLessOne()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string PasswordHash = "";

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void PasswordMin()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string PasswordHash = "A";

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PasswordMid()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string PasswordHash = "Password123";

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PasswordMax()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string PasswordHash = "";

            PasswordHash = PasswordHash.PadRight(255, 'A');

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string PasswordHash = "";

            PasswordHash = PasswordHash.PadRight(256, 'A');

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreNotEqual("", Error);
        }


        //====================================================
        // DATE TESTS
        //====================================================

        [TestMethod]
        public void CreatedAtExtremeMin()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100);

            string CreatedAt = TestDate.ToString();

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void CreatedAtMinLessOne()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(-1);

            string CreatedAt = TestDate.ToString();

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void CreatedAtMin()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            string CreatedAt = TestDate.ToString();

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CreatedAtMinPlusOne()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(1);

            string CreatedAt = TestDate.ToString();

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CreatedAtExtremeMax()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(100);

            string CreatedAt = TestDate.ToString();

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void CreatedAtInvalidData()
        {
            ClsUsers AUser = new ClsUsers();

            String Error = "";

            string CreatedAt = "this is not a date!";

            Error = AUser.Valid(FirstName, LastName, Email, PasswordHash, CreatedAt);

            Assert.AreNotEqual("", Error);
        }
    }
}