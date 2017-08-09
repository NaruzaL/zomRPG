using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Wastelander.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace Wastelander.Controllers
{
    public class PlayerController : Controller
    {
        private readonly WastelanderContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public PlayerController(UserManager<ApplicationUser> userManager, WastelanderContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            return View(_db.Players.Where(x => x.User.Id == currentUser.Id));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Player player)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            player.User = currentUser;
            player.Expierience = 0;
            player.LocationId = 2;
            _db.Players.Add(player);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var thisPlayer = _db.Players.Include(player => player.Items).Include(player => player.currentLocation).FirstOrDefault(Players => Players.PlayerId == id);
            return View(thisPlayer);
        }
        public IActionResult Edit(int id)
        {
            var thisPlayer = _db.Players.FirstOrDefault(Players => Players.PlayerId == id);
            return View(thisPlayer);
        }

        [HttpPost]
        public IActionResult Edit(Player Player)
        {
            _db.Entry(Player).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var thisPlayer = _db.Players.FirstOrDefault(Players => Players.PlayerId == id);
            return View(thisPlayer);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisPlayer = _db.Players.FirstOrDefault(Players => Players.PlayerId == id);
            _db.Players.Remove(thisPlayer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
