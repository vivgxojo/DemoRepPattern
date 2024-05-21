using DemoRepPattern.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoRepPattern.Controllers
{
    public class HomeController : Controller
    {
        IRepJoueurs repJoueurs;

        public HomeController(IRepJoueurs repJoueurs)
        {
            this.repJoueurs = repJoueurs;
        }

        public IActionResult Index()
        {
            return View(repJoueurs.LesJoueurs());
        }

        public IActionResult Detail(string id)
        {
            return View(repJoueurs.GetJoueur(id));
        }
        /// <summary>
        /// Afficher le formulaire d'ajout
        /// </summary>
        /// <returns>le formulaire d'ajout</returns>
        [HttpGet]
        public IActionResult Create()
        {
            return View("Ajouter");
        }

        /// <summary>
        /// Ajouter un joueuer à la liste
        /// </summary>
        /// <param name="joueur">le joueuer à ajouter qui vient du formulaire</param>
        /// <returns>retourne à l'index</returns>
        [HttpPost]
        public IActionResult Ajouter(Joueur joueur)
        {
            repJoueurs.AjouterJoueur(joueur);
            return RedirectToAction("Index");
        }

        public IActionResult Supprimer(string id)
        {
            repJoueurs.SupprimerJoueur(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Modifier(string id)
        {
            Joueur joueur = repJoueurs.GetJoueur(id);
            return View(joueur);
        }

        [HttpPost]
        public IActionResult Modifier(string oldid, Joueur joueur)
        {
            repJoueurs.ModifierJoueur(oldid, joueur);
            return RedirectToAction("Index");
        }
    }
}