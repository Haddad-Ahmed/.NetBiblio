using GB.Domain;
using GB.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GB.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            ServiceAdherent AS = new ServiceAdherent();
            Adherent user = AS.Login(username, password);

            if (user != null)
            {
                Session["currentUser"] = user.Id;
                Session["UserName"] = username;
                Console.WriteLine(user);
                return RedirectToAction("Index", "Livre");
            }
            return View();
            /*if (username == "Haddad" && password == "1999")
            {
                Session["currentUser"] = this.Id;
                Session["UserName"] = username;
                return RedirectToAction("Create", "Livre");
            }
            else
                return View();
        }*/
        }
    }
}