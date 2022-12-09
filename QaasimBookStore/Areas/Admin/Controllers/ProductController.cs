﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using QaasimBooks.Models.ViewModels;
using QaasimBooks.Models;
using QaasimBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QaasimBooks.DataAccess.Repository.IRepository;

namespace QaasimBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            ProductVM productVM = new ProductVM()
            {
                Product = new Product(),
                CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.id.ToString()
                }),
                CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.id.ToString()
                }),
            };
            if(id == null)
            {
                return View(productVM);
            }

            productVM.Product = _unitOfWork.Product.Get(id.GetValueOrDefault());
            if(productVM.Product == null)
            {
                return NotFound();
            }
            return View(productVM);
        }

        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Product product)
        {
            if (ModelState.IsValid)
            {
                if(product.id == 0)
                {
                    _unitOfWork.Product.Add(product);
                }
                else
                {
                    _unitOfWork.Product.Update(product);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }*/

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert (Product product)
        {
            if (ModelState.IsValid)
            {
                if(product.id == 0){
                    _unitOfWork.Product.Add(product);
                    _unitOfWork.Save();
                }
                else
                {
                    _unitOfWork.Product.Update(product);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        #region API CALLS   
        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Product.GetAll(includeProperties:"Category,CoverType");
            return Json(new { data = allObj });
        }

        [HttpDelete]
        public  IActionResult Delete(int id)
        {
            var objFormDb = _unitOfWork.Product.Get(id);
            if(objFormDb == null)
            {
                return Json(new { success = false, message = "Error while deleteing" });
            }
            _unitOfWork.Product.Remove(objFormDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}
