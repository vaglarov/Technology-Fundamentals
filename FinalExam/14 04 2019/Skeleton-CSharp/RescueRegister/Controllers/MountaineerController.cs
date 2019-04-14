using RescueRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using RescueRegister.Data;

namespace RescueRegister.Controllers
{
    public class MountaineerController : Controller
    {
        private readonly MountainDb context;

        public MountaineerController(MountainDb context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            using (var db = new MountainDb())
            {
                var mountaineer = db.Mountaineers.ToList();
                return this.View(mountaineer);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Mountaineer mountaineer)
        {
            using (var db = new MountainDb())
            {
                db.Mountaineers.Add(mountaineer);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new MountainDb())
            {
                Mountaineer book = db.Mountaineers.Find(id);
                return View(book);
            }
        }

        [HttpPost]
        public IActionResult Edit(Mountaineer mountaineer)
        {
            using (var db = new MountainDb())
            {
                db.Mountaineers.Update(mountaineer);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new MountainDb())
            {
                Mountaineer book = db.Mountaineers.Find(id);
                return View(book);
            }
        }

        [HttpPost]
        public IActionResult Delete(Mountaineer mountaineer)
        {
            using (var db = new MountainDb())
            {
                db.Mountaineers.Remove(mountaineer);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}