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
     public class HomeControllerUnitTest
    {
        [TestMethod]
        public void Index()
        {
            HomeController controller = new HomeController();
            ViewResult Result = controller.Index() as ViewResult;
            Assert.IsNotNull(Result);
        }
        [TestMethod]
        public void About()
        {
            HomeController controller = new HomeController();
            ViewResult Result = controller.About() as ViewResult;
            Assert.IsNotNull(Result);
        }
        [TestMethod]
        public void Contact()
        {
            HomeController controller = new HomeController();
            ViewResult Result = controller.Contact() as ViewResult;
            Assert.IsNotNull(Result);
        }


    }
}
