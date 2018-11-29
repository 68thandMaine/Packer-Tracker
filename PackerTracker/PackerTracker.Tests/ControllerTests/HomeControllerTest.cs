using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using PackerTracker.Controllers;
using System.Collections.Generic;


namespace PackerTracker.Tests
{
    [TestClass]
    public class HomeControllerTest : IDisposable
    {
    public void Dispose()
    {
        PackObject.ClearAll();
    }
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            ItemsController controller = new ItemsController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Index_HasCorrectModelType_ItemList()
        {
            //Arrange
            HomeController controller = new HomeController();
            ViewResult indexView = new HomeController().Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            //Console.WriteLine(Assert.IsInstanceOfType(result, typeof(void)));
            Assert.IsInstanceOfType(result, typeof(string));
        }

    }
}
