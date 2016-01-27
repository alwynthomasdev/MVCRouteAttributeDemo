using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRouteAttributeDemo.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        [Route("", Name = Constants.Routes.Home)]
        public ActionResult Index()
        {
            return View();
        }

        [Route("about", Name = Constants.Routes.About)]
        public ActionResult About()
        {
            return View();
        }
    }
}