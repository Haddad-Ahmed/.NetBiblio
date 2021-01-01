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
            if (username == "Haddad" && password == "1999")
            {
                Session["UserName"] = username;
                return RedirectToAction("Index", "Home");
            }
            else
                return View();
        }
    }
}