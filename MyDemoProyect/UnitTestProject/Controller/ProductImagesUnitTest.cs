using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;
using MyProductsAdminsite;
using MyProductsAdminsite.Controllers;
using MyProductsAdminsite.Models;

namespace UnitTestProject.Controller
{
    [TestClass]
    class ProductImagesUnitTest
    {
        [TestMethod]
        public void Index()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult Result = controller.Index() as ViewResult;
            Assert.IsNotNull(Result);
        }

        [TestMethod]
        public void Details()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult Result = controller.Details(1) as ViewResult;
            Assert.IsNotNull(Result);


        }
        [TestMethod]
        public void Create()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult Result = controller.Create() as ViewResult;
            Assert.IsNotNull(Result);


        }
        [TestMethod]
        public void Edit()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult Result = controller.Edit(1) as ViewResult;
            Assert.IsNotNull(Result);


        }

        [TestMethod]
        public void Delete()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult Result = controller.Delete(1) as ViewResult;
            Assert.IsNotNull(Result);


        }

    }
}

    

