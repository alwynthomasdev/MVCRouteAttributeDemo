using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRouteAttributeDemo.Controllers
{
    [RoutePrefix("products")]
    public class ProductController : Controller
    {
        [Route("{category?}", Name = Constants.Routes.ProductRoutes.Products)]
        public ActionResult Products(string category)
        {
            ViewBag.Category = category;
            return View();
        }

        [Route("product/{id}",Name =Constants.Routes.ProductRoutes.Product)]
        public ActionResult Product(int id)
        {
            return View();
        }
    }
}