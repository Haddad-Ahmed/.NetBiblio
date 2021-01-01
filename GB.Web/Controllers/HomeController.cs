using GB.Service;
using GB.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GB.Web.Controllers
{
    public class HomeController : Controller
    {
        ServiceEmprunt ES = new ServiceEmprunt();
        ServiceAdherent AS = new ServiceAdherent();
        ServiceDocument DS = new ServiceDocument();
        ServiceLivre LS = new ServiceLivre();
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}