using Budget_CoolBooks.Models;
using Budget_CoolBooks.Services.Reviews;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mono.TextTemplating;
using System.Data;

namespace Budget_CoolBooks.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ReviewServices _reviewServices;

        public AdminController(ReviewServices reviewServices)
        {
            _reviewServices = reviewServices;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        // Reviews-section
        [HttpGet]
        public IActionResult AdminReviews()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ReviewsByName(string name)
        {
            var result = await _reviewServices.GetReviewByUsername(name);
            if (result == null)
            {
                return NotFound();
            }

            ViewBag.ListOfReviews = result;
            return View("AdminReviews");
        }

    }
}
