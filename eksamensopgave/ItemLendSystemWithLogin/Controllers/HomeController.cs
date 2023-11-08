using ItemLendSystemWithLogin.Areas.Identity.Data;
using ItemLendSystemWithLogin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;
using System.Diagnostics;

namespace ItemLendSystemWithLogin.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ItemLendSystemWithLoginUser> _userManager;
        private readonly ItemLendSystemwithLogin_systemDB _context;
        //public HomeController(ILogger<HomeController> logger, UserManager<ItemLendSystemWithLoginUser> userManager)
        //{
        //    _logger = logger;
        //    _userManager = userManager;
        //}

        //public IActionResult Index()

        //{
        //    ViewData["UserName"] = _userManager.GetUserName(this.User);
        //    return View();
        //}

        public HomeController(ItemLendSystemwithLogin_systemDB context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var itemLendSystemDB = _context.Items.Include(i => i.Owner);

            return View(await itemLendSystemDB.ToListAsync());

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}