﻿/*using Microsoft.AspNetCore.Mvc;
using QaasimBooks.DataAccess.Repository.IRepository;
using QaasimBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QaasimBookStore.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly (IUnitOfWork unitOfWork)
        {
                _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

    #region API CALLS
    [HttpGet]
    public IActionsResult GetAll()
    {
        var allObj = _unitOfWork.Category.GetAll();
        return Json(new { data = allObj });
    }
}
#endregion
}
*/