namespace PrawieTwitter.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PrawieTwitter.Library.Entities;
    using PrawieTwitter.Library.Controllers;
    using MongoDB.Bson;

    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void AddTest()
        {
            User u = new User() { 
                FirstName="test",
                LastName="test", 
                Age= 12, 
                Email="abc@abc.pl", 
                Password="qwerty"
            };
            UserController.Add(u);
        }

        [TestMethod]
        public void FindTest()
        {
            ObjectId id = new ObjectId();
            string email = "abc1";
            UserController.Add(new User() { Id = id, Email = email, FirstName = "test" });
            User user = UserController.FindByEmail(email);
            Assert.AreEqual(user.FirstName, "test");
        }

        [TestMethod]
        public void RemoveTest()
        {
            User nuser = new User() { Email = "abc1" };
            UserController.Add(nuser);
            Console.Write(nuser.Id.ToString());
            UserController.Remove(nuser.Id);
            
            User user = UserController.FindById(nuser.Id);
            Assert.AreEqual(user,null);
        }

        [TestMethod]
        public void UpdateTest() {
            User user = new User();
            UserController.Add(user);
            user.Email = "abcd";
            user.FirstName = "zmieniony test";
            UserController.Update(user);
            Assert.AreEqual(user.FirstName, UserController.FindByEmail(user.Email).FirstName);

        }

    }
}
