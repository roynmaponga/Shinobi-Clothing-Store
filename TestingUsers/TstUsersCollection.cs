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
    public class TstUsersCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsUsersCollection AllUsers =
                    new ClsUsersCollection();

            Assert.IsNotNull(AllUsers);
        }

        [TestMethod]
        public void UserListOK()
        {
            ClsUsersCollection AllUsers =
                    new ClsUsersCollection();

            List<ClsUsers> TestList =
                    new List<ClsUsers>();

            ClsUsers TestItem =
                    new ClsUsers();

            TestItem.UserID = 1;
            TestItem.FirstName = "Roy";

            TestList.Add(TestItem);

            AllUsers.UserList = TestList;

            Assert.AreEqual(AllUsers.UserList, TestList);
        }

        [TestMethod]
        public void ThisUserPropertyOK()
        {
            ClsUsersCollection AllUsers =
                    new ClsUsersCollection();

            ClsUsers TestUser =
                    new ClsUsers();

            TestUser.UserID = 1;

            AllUsers.ThisUser = TestUser;

            Assert.AreEqual(AllUsers.ThisUser, TestUser);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            ClsUsersCollection AllUsers =
                    new ClsUsersCollection();

            List<ClsUsers> TestList =
                    new List<ClsUsers>();

            ClsUsers TestItem =
                    new ClsUsers();

            TestList.Add(TestItem);

            AllUsers.UserList = TestList;

            Assert.AreEqual(AllUsers.Count, TestList.Count);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            ClsUsersCollection AllUsers =
                    new ClsUsersCollection();

            Int32 SomeCount = AllUsers.UserList.Count;

            Assert.AreEqual(SomeCount, AllUsers.Count);

            Assert.AreEqual(SomeCount, AllUsers.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            ClsUsersCollection AllUsers =
                new ClsUsersCollection();

            ClsUsers TestItem =
                new ClsUsers();

            Int32 PrimaryKey = 0;

            TestItem.FirstName = "Roy";
            TestItem.LastName = "Maps";
            TestItem.Email = "roy" + DateTime.Now.Ticks + "@test.com";
            TestItem.PasswordHash = "Password!";
            TestItem.CreatedAt = DateTime.Now.Date;
            TestItem.IsActive = true;

            AllUsers.ThisUser = TestItem;

            PrimaryKey = AllUsers.Add();

            Assert.AreNotEqual(5,PrimaryKey);
        }
    }
}
