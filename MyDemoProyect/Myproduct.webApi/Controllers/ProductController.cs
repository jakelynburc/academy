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
    //Puerto 51184 es de WebAPI
    //Puerto 54105 es de WebApp
    [EnableCors(origins: "http://localhost:54105", headers: " * ", methods: " * ")]
    public class ProductController : ApiController
    {
  
        private MyCompanyEntities db = new MyCompanyEntities();
        // GET: Product
        
        public IEnumerable<Product> Get()
        {

            var product = db.Products.AsEnumerable();
            return product.ToList();
        }
        #region other methods
        // GET: api/Product/5
        public string Get(int id)
        {
            var product = db.Products.Where(x => x.Id == id).FirstOrDefault();
            return product.ToString();
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
    #endregion
}

