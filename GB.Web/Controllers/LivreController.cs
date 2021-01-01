using GB.Domain;
using GB.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GB.Web.Controllers
{
    public class LivreController : Controller
    {
        ServiceEmprunt ES = new ServiceEmprunt();
        ServiceAdherent AS = new ServiceAdherent();
        ServiceDocument DS = new ServiceDocument();
        ServiceLivre LS = new ServiceLivre();
        // GET: Livre
        
        public ActionResult Index()
        {
            Adherent user = new Adherent();
            user = AS.GetById((int)Session["currentUser"]);
            ViewData["user"] = user.Nom + " " + user.Prenom;
            IEnumerable<Livre> livres = LS.GetLivres(user.Bibliotheque);
            return View("Index", livres);
        }

        [HttpPost]
        public ActionResult Index(string searchString)
        {
            List<Livre> livres = Session["livres"] as List<Livre>;
            if (!String.IsNullOrEmpty(searchString))
            {
                livres = livres.Where(l => l.Titre.Contains(searchString)).ToList();
            }
            return View(livres);
        }


        // GET: Livre/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Livre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Livre/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Livre l)
        {
            List<Livre> livres = Session["livres"] as List<Livre>;
            if (livres == null)
            {
                livres = new List<Livre>();
            }
            livres.Add(l);

            Session["livres"] = livres;
            return RedirectToAction("Index");
        }

        // GET: Livre/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Livre/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Livre/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Livre/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Emprunt(int id)
        {
            Adherent user = new Adherent();
            user = AS.GetById((int)Session["currentUser"]);
            Document dc = new Document();
            dc = DS.GetById(id);
            ES.Emprunter(dc, user);
            return RedirectToAction("Index");
        }
    }
}
