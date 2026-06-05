using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingUsers
{
    [TestClass]
    public class TstUserLogin
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsUserLogin AUser = new ClsUserLogin();

            Assert.IsNotNull(AUser);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            ClsUserLogin AUser = new ClsUserLogin();

            string TestData = "Roy";

            AUser.UserName = TestData;

            Assert.AreEqual(TestData, AUser.UserName);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            ClsUserLogin AUser = new ClsUserLogin();

            string TestData = "password123";

            AUser.Password = TestData;

            Assert.AreEqual(TestData, AUser.Password);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            ClsUserLogin AUser = new ClsUserLogin();

            string TestData = "Users";

            AUser.Department = TestData;

            Assert.AreEqual(TestData, AUser.Department);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            ClsUserLogin AUser = new ClsUserLogin();

            Boolean Found = false;

            string email = "roy@test.com";

            string Password = "Password123";

            Found = AUser.FindUser(email, Password);

            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserIDFound()
        {
            ClsUserLogin AUser = new ClsUserLogin();

            Boolean Found;

            Found = AUser.FindUser("roy@test.com", "Password123");

            Assert.IsTrue(Found);

            Assert.AreEqual(7, AUser.UserID);
        }
    }

}
