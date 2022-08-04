using BBMartUtility;
using BBSuperMart.Data;
using BBSuperMart.Models;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BBSuperMart.Controllers
{
    public class cartController : Controller
    {
        private readonly BBSuperMarketDbContext _cDb;
        public cartController(BBSuperMarketDbContext cDb)
        {
            _cDb = cDb;
        }


        public IActionResult Index()
        {
            List<ShoppingCart> shoppingCartList = new List<ShoppingCart>();
            if (HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart) != null
                && HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart).Count() > 0)
            {
                shoppingCartList = HttpContext.Session.Get<List<ShoppingCart>>(WC.SessionCart);
            }

            List<int> prodInCart = shoppingCartList.Select(i => i.ProductId).ToList();
            Debug.WriteLine("Index");

            IEnumerable<Products> prodList = _cDb.Products.Where(u => prodInCart.Contains(u.ProductId));
            
            return View(prodList);
        }

        public IActionResult removeCart(int ProductId)
        {
            List<ShoppingCart> shoppingCartList = new List<ShoppingCart>();
            if (HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart) != null
                && HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart).Count() > 0)
            {
                shoppingCartList = HttpContext.Session.Get<List<ShoppingCart>>(WC.SessionCart);
            }
            shoppingCartList.Remove(shoppingCartList.FirstOrDefault(u=>u.ProductId== ProductId));
            List<int> prodInCart = shoppingCartList.Select(i => i.ProductId).ToList();
            HttpContext.Session.Set(WC.SessionCart, shoppingCartList);

            return RedirectToAction(nameof(Index));
        }


        public IActionResult decrease(int ProductId, int quantity)
        {
            if (quantity == 1)
            {
                List<ShoppingCart> shoppingCartList = new List<ShoppingCart>();
                if (HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart) != null
                    && HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart).Count() > 0)
                {
                    shoppingCartList = HttpContext.Session.Get<List<ShoppingCart>>(WC.SessionCart);
                }
                shoppingCartList.Remove(shoppingCartList.FirstOrDefault(u => u.ProductId == ProductId));
                List<int> prodInCart = shoppingCartList.Select(i => i.ProductId).ToList();
                HttpContext.Session.Set(WC.SessionCart, shoppingCartList);
            }
            return RedirectToAction(nameof(Index));
        }


        public IActionResult increase(int ProductId, int quantity)
        {
            if (quantity <=5)
            {
                List<ShoppingCart> shoppingCartList = new List<ShoppingCart>();
                if (HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart) != null
                    && HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WC.SessionCart).Count() > 0)
                {
                    shoppingCartList = HttpContext.Session.Get<List<ShoppingCart>>(WC.SessionCart);
                }
                shoppingCartList.FirstOrDefault(item => item.ProductId == ProductId).quantity++;

                List<int> prodInCart = shoppingCartList.Select(i => i.ProductId).ToList();
                HttpContext.Session.Set(WC.SessionCart, shoppingCartList);
            }
            return RedirectToAction(nameof(Index));
        }


        //wishlisht cart
        public IActionResult wishListIndex()
        {
            List<WishListCart> WishListCartList = new List<WishListCart>();
            if (HttpContext.Session.Get<IEnumerable<WishListCart>>(WC.SessionWishlistCart) != null
                && HttpContext.Session.Get<IEnumerable<WishListCart>>(WC.SessionWishlistCart).Count() > 0)
            {
                WishListCartList = HttpContext.Session.Get<List<WishListCart>>(WC.SessionWishlistCart);
            }
            List<int> prodInCart = WishListCartList.Select(i => i.ProductId).ToList();
            IEnumerable<Products> prodList = _cDb.Products.Where(u => prodInCart.Contains(u.ProductId));

            return View(prodList);
        }

        public IActionResult removeWishlistCart(int ProductId)
        {
            List<WishListCart> WishListCartList = new List<WishListCart>();
            if (HttpContext.Session.Get<IEnumerable<WishListCart>>(WC.SessionWishlistCart) != null
                && HttpContext.Session.Get<IEnumerable<WishListCart>>(WC.SessionWishlistCart).Count() > 0)
            {
                WishListCartList = HttpContext.Session.Get<List<WishListCart>>(WC.SessionWishlistCart);
            }
            WishListCartList.Remove(WishListCartList.FirstOrDefault(u => u.ProductId == ProductId));
            List<int> prodInCart = WishListCartList.Select(i => i.ProductId).ToList();
            HttpContext.Session.Set(WC.SessionWishlistCart, WishListCartList);
            return RedirectToAction(nameof(wishListIndex));
        }
    }
}
