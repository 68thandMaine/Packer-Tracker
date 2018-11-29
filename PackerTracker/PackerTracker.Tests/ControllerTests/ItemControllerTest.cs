using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using PackerTracker.Controllers;
using System.Collections.Generic;


namespace PackerTracker.Tests

{
    [TestClass]
    public class ItemControllerTest : IDisposable
    {
        public void Dispose()
        {
            PackObject.ClearAll();
        }

        //Test methods for index


        [TestMethod]
        public void Index_ReturnsCorrectAction_True()
        {
            //Arrange
            ItemsController controller = new ItemsController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Index_HasCorrectModelType_PackObjectList()
        {
            //Arrange 
            ItemsController controller = new ItemsController();
            ViewResult indexView = new ItemsController().Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<PackObject>));
        }

        [TestMethod]
        public void Create_RedirectsToCorrectActionResult_Index()
        {
            //Arrange
            ItemsController controller = new ItemsController();
            RedirectToActionResult actionResult = controller.Create("string", 1, 2, false) as RedirectToActionResult;

            //Act
            string result = actionResult.ActionName;
            //Assert
            Assert.AreEqual(result, "Index");
        }


        // Test methods for new

        [TestMethod]
        public void New_ReturnsCorrectAction_True()
        {
            //Arrange
            ItemsController controller = new ItemsController();

            //Act

            ActionResult newView = controller.New();

            //Assert

            Assert.IsInstanceOfType(newView, typeof(ViewResult));
        }

        [TestMethod]
        public void New_HasCorrectModelType_PackObjectList()
        {
            //Arrange 
            ItemsController controller = new ItemsController();
            ViewResult newView = new ItemsController().New() as ViewResult;

            //Act
            var result = newView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<PackObject>));
        }

        [TestMethod]
        public void Create_RedirectsToCorrectActionResult_New()
        {
            //Arrange
            ItemsController controller = new ItemsController();
            RedirectToActionResult actionResult = controller.Create("string", 1, 2, false) as RedirectToActionResult;

            //Act
            string result = actionResult.ActionName;
            //Assert
            Assert.AreEqual(result, "Index");
        }

        //Test methods for show


        [TestMethod]
        public void Show_ReturnsCorrectAction_True()
        {
            //Arrange
            ItemsController controller = new ItemsController();
            controller.Create("string", 1, 2, false);

            //Act

            ActionResult showView = controller.Show(1);

            //Assert

            Assert.IsInstanceOfType(showView, typeof(ViewResult));
        }

        [TestMethod]
        public void Show_HasCorrectModelType_PackObjectList()
        {
            //Arrange 
            ItemsController controller = new ItemsController();
            controller.Create("string", 1, 2, false);
            ViewResult newShow = new ItemsController().Show(1) as ViewResult;

            //Act
            var result = newShow.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<PackObject>));
        }

        [TestMethod]
        public void Create_RedirectsToCorrectActionResult_Show()
        {
            //Arrange
            ItemsController controller = new ItemsController();
            RedirectToActionResult actionResult = controller.Create("string", 1, 2, false) as RedirectToActionResult;

            //Act
            string result = actionResult.ActionName;
            //Assert
            Assert.AreEqual(result, "Index");
        }
    }
}
