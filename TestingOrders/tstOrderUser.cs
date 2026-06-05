using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrderUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create
            clsOrderUser AnOrderUser = new clsOrderUser();
            // Test to see that it exists
            Assert.IsNotNull(AnOrderUser);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {

            // Create an instance of the class we want to create
            clsOrderUser AnOrderUser = new clsOrderUser();
            // Create some test data to assign to the property
            Int32 TestData = 1;
            // Assign the data to the property
            AnOrderUser.UserID = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrderUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrderUser AnOrderUser = new clsOrderUser();
            // Create some test data to assign to the property
            string TestData = "John Doe";
            // Assign the data to the property
            AnOrderUser.UserName = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrderUser.UserName, TestData);

        }

        [TestMethod]
        public void passwordPropertyOK()

        {

            // Create an instance of the class we want to create
            clsOrderUser AnOrderUser = new clsOrderUser();
            // Create some test data to assign to the property
            string TestData = "Password123";
            // Assign the data to the property
            AnOrderUser.Password = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrderUser.Password, TestData);

        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrderUser AnOrderUser = new clsOrderUser();
            // Create some test data to assign to the property
            string TestData = "Sales";
            // Assign the data to the property
            AnOrderUser.Department = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrderUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            // Create an instance of the class we want to create
            clsOrderUser AnOrderUser = new clsOrderUser();
            // Boolean variable to store the result of the validation
            Boolean Found = false;
            // Create some test data to use with the method
            String UserName = "John Doe";
            string Password = "Password123";
            // Invoke the method
            Found = AnOrderUser.FindUser(UserName, Password);
            // Test to see that the result is true
            Assert.IsTrue(Found);


        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsAUser();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string UserName = "Dawn";
            string Password = "password123";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //check the user id property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }

    }
