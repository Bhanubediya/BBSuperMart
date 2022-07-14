using BBSuperMart.Data;
using BBSuperMart.Models;
using BBSuperMart.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BBSuperMart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BBSuperMarketDbContext _hdb;
        public HomeController(ILogger<HomeController> logger, BBSuperMarketDbContext hdb)
        {
            _logger = logger;
            _hdb = hdb;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Products = _hdb.Products.Include(u => u.Category),
                Categories = _hdb.Category
            };
            return View(homeVM);
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

        public IActionResult details(int ProductId)
        {
            DetailsVM detailsVM= new DetailsVM()
            {
                Products = _hdb.Products.Include(u => u.Category).Where(u => u.ProductId == ProductId).FirstOrDefault(),
                ExistsInCart = false
            }; 
            return View(detailsVM);
        }
    }
}
