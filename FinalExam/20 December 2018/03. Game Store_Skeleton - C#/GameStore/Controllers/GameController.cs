using System;
using System.Collections.Generic;
using System.Linq;
using GameStore.Date;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new GameStoreDbContext())
            {
                var games = db.Games.ToList();
                return this.View(games);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                db.Games.Add(game);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                Game game = db.Games.Find(id);
                return View(game);
            }
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                db.Games.Update(game);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                Game game = db.Games.Find(id);
                return View(game);
            }
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                db.Games.Remove(game);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}