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
    public class CategoriesControllerUnitTest
    {
        [TestMethod]
        public void Index()
        {
            CategoriesController controller = new CategoriesController();
            ViewResult Result = controller.Index() as ViewResult;
            Assert.IsNotNull(Result);
        }
        [TestMethod]
        public void CategoriesDetails()
        {
            CategoriesController controller = new CategoriesController();
            ViewResult Result = controller.Details(2) as ViewResult;
            Assert.IsNotNull(Result);
        }
        [TestMethod]
        public void Create()
        {
            CategoriesController controller = new CategoriesController();
            ViewResult Result = controller.Create() as ViewResult;
            Assert.IsNotNull(Result);
        }

        //[TestMethod]
        //public void Create()
        //{
        //    CategoriesController controller = new CategoriesController();
        //    ViewResult Result = controller.Create() as ViewResult;
        //    Assert.IsNotNull(Result);
        //}


        [TestMethod]
        public void CategoriesEdit()
        {
            CategoriesController controller = new CategoriesController();
            ViewResult Result = controller.Edit(2) as ViewResult;
            Assert.IsNotNull(Result);
        }
        //[TestMethod]
        //public void Edit()
        //{
        //    CategoriesController controller = new CategoriesController();
        //    ViewResult Result = controller.Edit(1) as ViewResult;
        //    Assert.IsNotNull(Result);
        //}

        [TestMethod]
        public void CategoriesDelete()
        {
            CategoriesController controller = new CategoriesController();
            ViewResult Result = controller.Delete(2) as ViewResult;
            Assert.IsNotNull(Result);
        }

    }
}
