namespace PrawieTwitter.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PrawieTwitter.Library.Entities;
    using MongoDB.Bson;
    using PrawieTwitter.Library.Controllers;
    using System.Collections.Generic;

    [TestClass]
    public class StatusTest
    {
        [TestMethod]
        public void AddStatusTest()
        {
            Status s = new Status()
            {
                Date = DateTime.Now,
                Text = "testasdasd.asdasd.adsd",
                UserId = new ObjectId("5396ef7916ab5d10d49ebd30")
            };

            StatusController.Add(s);
            Assert.AreEqual(s.Text, StatusController.FindById(s.Id).Text);
        }

        [TestMethod]
        public void FindStatusByUser()
        {
            List<Status> status = StatusController.FindByUser(new ObjectId("5396ef7916ab5d10d49ebd30"));
            Assert.AreEqual(status[0].UserId, status[1].UserId);
        }
    }
}
