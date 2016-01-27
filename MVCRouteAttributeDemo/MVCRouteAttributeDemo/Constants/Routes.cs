using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRouteAttributeDemo.Constants
{
    
    //Define all of our route names here

    public class Routes
    {
        public const string Home = "Home";
        public const string About = "About";

        public class ContactRoutes
        {
            public const string Contact = "Contact";
            public const string ContactSent = "ContactSent";
        }
    }
}