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
    public class ProductUnitTest
    {
        [TestMethod]
        public void Index()
        {
            ProductsController controller = new ProductsController();
            ViewResult Result = controller.Index() as ViewResult;
            Assert.IsNotNull(Result);
        }

        [TestMethod]
        public void Details()
        {
            ProductsController controller = new ProductsController();
            ViewResult Result = controller.Details(1) as ViewResult;
            Assert.IsNotNull(Result);


        }
        [TestMethod]
        public void Create()
        {
            ProductsController controller = new ProductsController();
            ViewResult Result = controller.Create() as ViewResult;
            Assert.IsNotNull(Result);


        }
        [TestMethod]
        public void Edit()
        {
            ProductsController controller = new ProductsController();
            ViewResult Result = controller.Edit(1) as ViewResult;
            Assert.IsNotNull(Result);


        }

        [TestMethod]
        public void Delete()
        {
            ProductsController controller = new ProductsController();
            ViewResult Result = controller.Delete(1) as ViewResult;
            Assert.IsNotNull(Result);


        }
        
    }
}
