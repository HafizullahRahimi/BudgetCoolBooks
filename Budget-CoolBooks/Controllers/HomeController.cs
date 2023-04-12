using Budget_CoolBooks.Models;
using Budget_CoolBooks.Services.Books;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Budget_CoolBooks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Bookcard()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> ViewBooks()
        //{
        //    var result = await _bookServices.GetAllBooksSorted();
        //    if (result == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewBag.bookListSorted = result;
        //    return View(ViewBag.bookListSorted);
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}