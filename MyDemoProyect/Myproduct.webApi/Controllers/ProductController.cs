using System;
using Myproduct.webApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Http.Cors;


namespace Myproduct.webApi.Controllers
{
    public class ProductController : Controller
    {

        private MyCompanyEntities db = new MyCompanyEntities();
        // GET: Product
        [EnableCors(origins: "http://localhost:58418", headers: " * ", methods: " * ")]
        public IEnumerable<Product> Get()
        {

            var product = db.Products.AsEnumerable();
            return product.ToList();
        }
    }
}
