using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

//Make sure that the system is aware of all the folders and classes necessary
using Database1.Models;
using Database1.DAL;
//Allows database connection
using System.Data.Entity;



//Tells our website where to start - first file executed
//Used to make sure that web app is ready to start
namespace Database1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<BasketballContext>(null);
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
