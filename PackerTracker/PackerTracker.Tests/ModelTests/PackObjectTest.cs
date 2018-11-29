using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PackerTracker.Models;

namespace PackerTracker.Tests
{
    [TestClass]
    public class PackObjectTests : IDisposable
    {
        public void Dispose()
        {
            PackObject.ClearAll();
        }

        [TestMethod]
        public void GetId_MakeSureIdIsAssignedProperly_int()
        {
            //Arrange
            string testString = "boots";
            int testPrice = 40;
            int testWeight = 60;
            bool purchase = true;

            //Act
            PackObject testPackerTracker = new PackObject(testString, testPrice, testWeight, purchase);
            int result = testPackerTracker.GetId();


            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectItem_PackObject()
        {
            string testString1 = "boots";
            int testPrice1 = 40;
            int testWeight1 = 60;
            bool purchase1 = true;

            string testString2 = "boots";
            int testPrice2 = 40;
            int testWeight2 = 60;
            bool purchase2 = true;

            PackObject testPackerTracker = new PackObject(testString1, testPrice1, testWeight1, purchase1);
            PackObject testPackerTracker1 = new PackObject(testString2, testPrice2, testWeight2, purchase2);
            PackObject result = PackObject.Find(2);

            Assert.AreEqual(testPackerTracker1, result);
        }
    }
}
