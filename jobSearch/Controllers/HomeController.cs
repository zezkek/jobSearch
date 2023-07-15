using jobSearch.Data;
using jobSearch.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace jobSearch.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _appDbContext;
        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View(_appDbContext.Vacancy.ToList());
        }
    }
}