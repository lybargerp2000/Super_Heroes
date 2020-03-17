using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroes.Data;
using SuperHeroes.Models;

namespace SuperHeroes.Controllers
{
    public class SuperHeroesController : Controller
    {
        private readonly ApplicationDbContext db;
        public SuperHeroesController(ApplicationDbContext context)
        {
            db = context;
        }
        // GET: SuperHeroes
        public ActionResult Index()

        {
            var superheroes = db.SuperHeroes;
            return View(superheroes);
        }

        // GET: SuperHeroes/Details/5
        public ActionResult Details(int id)
        {
            var superhero = db.SuperHeroes.Where(s => s.Id == id).SingleOrDefault();
            return View(superhero);

        }

        // GET: SuperHeroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperHeroes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                db.SuperHeroes.Add(superHero);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuperHeroes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var superHero = db.SuperHeroes.Where(s => s.Id == id).SingleOrDefault();

                //db.SuperHeroes.Update(superHero);
                db.SaveChanges();
                // TODO: Add update logic here


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroes/Delete/5
        public ActionResult Delete(int id)
        {

            return View();
        }

        // POST: SuperHeroes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            View(collection);
            try
            {
                var superHero = db.SuperHeroes.Where(s => s.Id == id);
                db.SuperHeroes.RemoveRange(superHero);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}