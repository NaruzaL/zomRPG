using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Wastelander.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Wastelander.Controllers
{
    public class GameController : Controller
    {
        private readonly WastelanderContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public GameController(UserManager<ApplicationUser> userManager, WastelanderContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            return View(_db.Players.Where(x => x.User.Id == currentUser.Id));
        }
        public async Task<IActionResult> Game()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);

            return View();

        }
        public IActionResult JSTest()
        {
            return View();
        }


    }
}
