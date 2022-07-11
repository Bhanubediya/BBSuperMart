using BBSuperMart.Data;
using BBSuperMart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBSuperMart.Controllers
{
    public class ProductsController : Controller
    {
        private readonly BBSuperMarketDbContext _pdB;

        public ProductsController(BBSuperMarketDbContext pB)
        {
            _pdB = pB;
        }

        public IActionResult Index()
        {
            IEnumerable<Products> ObjList = _pdB.Products;
            foreach (var obj in ObjList)
            {
                obj.Category = _pdB.Category.FirstOrDefault(u => u.CatId == obj.CatId);
            }
            return View(ObjList);
        }
        //GET - Create
        public IActionResult Create(int?productId)
        {
            IEnumerable<SelectListItem> CategoryDropDown = _pdB.Category.Select(i => new SelectListItem
            {
                Text = i.CatName,
                Value = i.CatId.ToString()
            });
            ViewBag.CategoryDropDown = CategoryDropDown;
            return View();
        }
        //POST - Create
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Products obj)
        {
            
            if (ModelState.IsValid)
            {
                _pdB.Products.Add(obj);
                _pdB.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET - Edit
        public IActionResult Edit(int?ProductId)
        {
            IEnumerable<SelectListItem> CategoryDropDown = _pdB.Category.Select(i => new SelectListItem
            {
                Text = i.CatName,
                Value = i.CatId.ToString()
            }) ;
            ViewBag.CategoryDropDown = CategoryDropDown;
            if (ProductId == null || ProductId == 0)
            {
                return NotFound();
            }
            var obj = _pdB.Products.Find(ProductId);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //POST - EDIT
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(Products obj)
        {
            if (ModelState.IsValid)
            {
                _pdB.Products.Update(obj);
                _pdB.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        //GET - Delete
        public IActionResult Delete(int? ProductId)
        {
            if (ProductId == null || ProductId == 0)
            {
                return NotFound();
            }
            var obj = _pdB.Products.Find(ProductId);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //POST - Delete
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteProd(int?productId)
        {
            if(productId==null|| productId == 0)
            {
                return NotFound();
            }
            var obj = _pdB.Products.Find(productId);
            if (obj!=null)
            {
                _pdB.Products.Remove(obj);
                _pdB.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
