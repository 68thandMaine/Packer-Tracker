using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PackerTracker.Models;

namespace PackerTracker.Tests
{
    [TestClass]
    public class PackerTrackerTests
    {
        [TestMethod]
        public void PackerTracker_CanInstantiateANewPackerTracker_obj()
        {
            //Arrange
            string testString = "boots";
            int testPrice = 40;
            int testWeight = 60;
            bool purchase = true;

            //Act
            PackObject testPackerTracker = new PackObject(testString, testPrice, testWeight, purchase);

            //Assert
            Assert.AreEqual(testPackerTracker, typeof(object));

        }
    }
}
