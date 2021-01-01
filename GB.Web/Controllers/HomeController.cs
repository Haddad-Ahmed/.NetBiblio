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

        //[Route("/Home/{username}/{password}")]
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Index(string username, string password)
        {

            Adherent user = AS.Login(username, password);
  
                if (user != null)
                {
                    Session["currentUser"] = user.Id;
                    Console.WriteLine(user);
                    return RedirectToAction("List");
            }
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


        public ActionResult List()
        {
            Adherent user = new Adherent();
            user = AS.GetById((int)Session["currentUser"]);
            ViewData["user"] = user.Nom + " " + user.Prenom;
            IEnumerable<Livre> livres = LS.GetLivres(user.Bibliotheque);
            return View("list",livres);
        }

        [HttpPost]
        public ActionResult Search(string searchString)
        {
            Adherent user = new Adherent();
            user = AS.GetById((int)Session["currentUser"]);
            ViewData["user"] = user.Nom + " " + user.Prenom;
            IEnumerable<Livre> livres = LS.GetLivres(user.Bibliotheque);
            if (!String.IsNullOrEmpty(searchString))
            {
                livres = livres.Where(l => l.Titre.Contains(searchString)).ToList();
            }

            return View("list", livres);

        }

        public ActionResult Emprunt(int id)
        {
            Adherent user = new Adherent();
            user = AS.GetById((int)Session["currentUser"]);
            Document dc = new Document();
            dc = DS.GetById(id);

           ES.Emprunter(dc , user);
            return RedirectToAction("list");
        }
    }
}