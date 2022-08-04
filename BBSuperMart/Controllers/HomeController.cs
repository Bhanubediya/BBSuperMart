using BBMartUtility;
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

        

        // GET - details
        public IActionResult details(int ProductId)
        {
            //for shopping cart
            List<ShoppingCart> shoppingCartList = new List<ShoppingCart>();
            if (HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart) != null
                && HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart).Count() > 0)
            {
                shoppingCartList = HttpContext.Session.Get<List<ShoppingCart>>(WC.SessionCart);
            }
            List<WishListCart> WishListCartList = new List<WishListCart>();
            if (HttpContext.Session.Get<IEnumerable<WishListCart>>(WC.SessionWishlistCart) != null
                && HttpContext.Session.Get<IEnumerable<WishListCart>>(WC.SessionWishlistCart).Count() > 0)
            {
                WishListCartList = HttpContext.Session.Get<List<WishListCart>>(WC.SessionWishlistCart);
            }
            DetailsVM detailsVM = new DetailsVM()
            {
                Products = _hdb.Products.Include(u => u.Category).Where(u => u.ProductId == ProductId).FirstOrDefault(),
                ExistsInCart = false,
                ExistsInWishlist=false

            };


            foreach (var item in WishListCartList)
            {
                if (item.ProductId == ProductId)
                {
                    detailsVM.ExistsInWishlist = true;
                }
            }


            foreach (var item in shoppingCartList)
            {
                if (item.ProductId == ProductId)
                {
                    detailsVM.ExistsInCart = true;

                }
            }
        
            return View(detailsVM);
        }

        [HttpPost, ActionName("Details")]
        public IActionResult detailsPost(int Id)
        {
            List<ShoppingCart> shoppingCartList = new List<ShoppingCart>();
            if (HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart) != null
                && HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart).Count() > 0)
            {
                shoppingCartList = HttpContext.Session.Get<List<ShoppingCart>>(WC.SessionCart);
            }
          
            List<WishListCart> WishListCartList = new List<WishListCart>();
            if (HttpContext.Session.Get<IEnumerable<WishListCart>>(WC.SessionWishlistCart) != null
                && HttpContext.Session.Get<IEnumerable<WishListCart>>(WC.SessionWishlistCart).Count() > 0)
            {
                WishListCartList = HttpContext.Session.Get<List<WishListCart>>(WC.SessionWishlistCart);
            }

            shoppingCartList.Add(new ShoppingCart { ProductId = Id });
            HttpContext.Session.Set(WC.SessionCart, shoppingCartList);
            //Change
            var itemToRemove = WishListCartList.SingleOrDefault(r => r.ProductId == Id);
            if (itemToRemove != null)
            {
                WishListCartList.Remove(itemToRemove);
            }
            HttpContext.Session.Set(WC.SessionWishlistCart, WishListCartList);
            return RedirectToAction("Index","Home");
        }

        public IActionResult removeFromCart(int Id)
        {
            List<ShoppingCart> shoppingCartList = new List<ShoppingCart>();
            if (HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart) != null
                && HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart).Count() > 0)
            {
                shoppingCartList = HttpContext.Session.Get<List<ShoppingCart>>(WC.SessionCart);
            }
            var itemToRemove = shoppingCartList.SingleOrDefault(r => r.ProductId == Id);
            if (itemToRemove != null)
            {
                shoppingCartList.Remove(itemToRemove);
            }
            HttpContext.Session.Set(WC.SessionCart, shoppingCartList);
            return RedirectToAction(nameof(Index));
        }

       

        //POST - Wishlist

        [HttpPost, ActionName("DetailsWishList")]
        public IActionResult detailsWishPost(int ProductId)
        {
            List<WishListCart> WishListCartList = new List<WishListCart>();
            if (HttpContext.Session.Get<IEnumerable<WishListCart>>(WC.SessionWishlistCart) != null
                && HttpContext.Session.Get<IEnumerable<WishListCart>>(WC.SessionWishlistCart).Count() > 0)
            {
                WishListCartList = HttpContext.Session.Get<List<WishListCart>>(WC.SessionWishlistCart);
            }
            WishListCartList.Add(new WishListCart { ProductId = ProductId });
            HttpContext.Session.Set(WC.SessionWishlistCart, WishListCartList);
           
            return RedirectToAction(nameof(Index));
        }

//Delete- WishList
        public IActionResult removeWishlist(int Id)
        {
            List<WishListCart> WishListCartList = new List<WishListCart>();
            if (HttpContext.Session.Get<IEnumerable<WishListCart>>(WC.SessionWishlistCart) != null
                && HttpContext.Session.Get<IEnumerable<WishListCart>>(WC.SessionWishlistCart).Count() > 0)
            {
                WishListCartList = HttpContext.Session.Get<List<WishListCart>>(WC.SessionWishlistCart);
            }
            var itemToRemove = WishListCartList.FirstOrDefault(r => r.ProductId == Id);
            if (itemToRemove != null)
            {
                WishListCartList.Remove(itemToRemove);
            }
            HttpContext.Session.Set(WC.SessionWishlistCart, WishListCartList);
            return RedirectToAction(nameof(Index));
        }


        //decrease button

       

    }
}
