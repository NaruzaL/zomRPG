using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wastelander.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace Wastelander.Controllers
{
    public class ZombieController : Controller
    {
        private WastelanderContext db = new WastelanderContext();
        [Authorize]
        public IActionResult Index()
        {
            return View(db.Zombies.ToList());
        }
        public IActionResult Details(int id)
        {
            var thisZombie = db.Zombies.FirstOrDefault(zombie => zombie.ZombieId == id);
            return View(thisZombie);
        }
        public IActionResult Create()
        {
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Zombie zombie)
        {
            db.Zombies.Add(zombie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var thisZombie = db.Zombies.FirstOrDefault(zombie => zombie.ZombieId == id);
            return View(thisZombie);
        }

        [HttpPost]
        public IActionResult Edit(Zombie zombie)
        {
            db.Entry(zombie).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var thisZombie = db.Zombies.FirstOrDefault(zombie => zombie.ZombieId == id);
            return View(thisZombie);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisZombie = db.Zombies.FirstOrDefault(zombie => zombie.ZombieId == id);
            db.Zombies.Remove(thisZombie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
