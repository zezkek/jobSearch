using jobSearch.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace jobSearch.Controllers
{
    public class VacancyController : Controller
    {

        private AppDbContext _appDbContext;
        public VacancyController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult VacancyList()
        {
            return View(_appDbContext.Vacancy.ToList());
        }
    }
}
