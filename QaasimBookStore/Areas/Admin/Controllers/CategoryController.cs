using Microsoft.AspNetCore.Mvc;
using QaasimBookStore.DataAccess.Data;
using QaasimBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QaasimBooks.DataAccess.Repository.IRepository;

namespace QaasimBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

            public CategoryController(IUnitOfWork unitOfWork)
        {
                _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

    
        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
    }

}

