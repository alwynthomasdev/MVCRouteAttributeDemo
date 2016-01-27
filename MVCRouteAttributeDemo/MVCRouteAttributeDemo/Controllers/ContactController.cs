using MVCRouteAttributeDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRouteAttributeDemo.Controllers
{
    [RoutePrefix("contact")]
    public class ContactController : Controller
    {
        [Route("", Name = Constants.Routes.ContactRoutes.Contact)]
        public ActionResult Contact()
        {
            return View();
        }

        [Route("")]//this route dose not need a name, http POST methods to route name 'Contact' will find this action method
        [HttpPost]
        public ActionResult Contact(ContactViewModel Model)
        {
            if (ModelState.IsValid)
            {
                //do something with contact...

                return RedirectToRoute(Constants.Routes.ContactRoutes.ContactSent);
            }
            return View(Model);
        }

        [Route("sent", Name = Constants.Routes.ContactRoutes.ContactSent)]
        public ActionResult Sent()
        {
            return View();
        }

    }
}