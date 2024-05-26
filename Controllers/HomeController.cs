using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp_MealKostV2.Data;
using WebApp_MealKostV2.Models;

namespace WebApp_MealKostV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly MealkostDBContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MealkostDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Menus", "Home");

            return View();
        }

        public JsonResult getMenus()
        {
            List<tbl_menu> sarapan = _context.tbl_menu.Where(m=>m.jenis.Equals("Sarapan")).ToList();
            List<tbl_menu> makan_siang = _context.tbl_menu.Where(m => m.jenis.Equals("Makan Siang")).ToList();
            List<tbl_menu> makan_malam = _context.tbl_menu.Where(m => m.jenis.Equals("Makan Malam")).ToList();
            List<tbl_menu> snack = _context.tbl_menu.Where(m => m.jenis.Equals("Snack")).ToList();
            var menus = new
            {
                sarapan = sarapan,
                makan_siang = makan_siang,
                makan_malam = makan_malam,
                snack = snack
            };
            return Json(menus);
        }

        public JsonResult getPaketMenu()
        {
            List<tbl_paket_menu> paket5 = _context.vw_paket_menu.Where(p => p.total_porsi == 5).ToList();
            List<tbl_paket_menu> paket4 = _context.vw_paket_menu.Where(p => p.total_porsi == 4).ToList();
            List<tbl_paket_menu> paket3 = _context.vw_paket_menu.Where(p => p.total_porsi == 3).ToList();
            var pakets = new
            {
                paket5 = paket5,
                paket4 = paket4,
                paket3 = paket3
            };
            return Json(pakets);
        }

        [Authorize]
        public IActionResult Menus()
        {
            return View();
        }

        [Authorize]
        public IActionResult Detail(string pid)
        {
            tbl_menu? menu = _context.tbl_menu.Where(m => m.judul.Contains(pid)).FirstOrDefault();

            if (menu == null) return RedirectToAction("Menus", "Home");

            ViewBag.Menu = menu;
            return View();
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