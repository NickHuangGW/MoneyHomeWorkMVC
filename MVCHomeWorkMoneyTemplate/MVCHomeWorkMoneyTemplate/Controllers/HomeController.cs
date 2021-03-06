﻿using MVCHomeWorkMoneyTemplate.EnumType;
using MVCHomeWorkMoneyTemplate.Factory;
using MVCHomeWorkMoneyTemplate.Repository;
using MVCHomeWorkMoneyTemplate.Service;
using MVCHomeWorkMoneyTemplate.ViewModels;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHomeWorkMoneyTemplate.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private IDailyAccountService _dailyAccountService;
        public HomeController()
        {
            _unitOfWork = new UnitOfWork();
            _dailyAccountService = new DailyAccountByEfService(_unitOfWork);

        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DailyAccountViewModel dailyAccountViewModel)
        {
            if (ModelState.IsValid)
            {
                bool isSucess = _dailyAccountService.InsData(dailyAccountViewModel);
                _unitOfWork.CommitTrans();
                return RedirectToAction("Index");
            }
            return View("Index", dailyAccountViewModel);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Edit(Guid id)
        {
            return View(_dailyAccountService.GetSingleDataById(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditData(DailyAccountViewModel dailyAccountViewModel)
        {
            if (ModelState.IsValid)
            {
                _dailyAccountService.EditData(dailyAccountViewModel);
                _unitOfWork.CommitTrans();
                return RedirectToAction("Index");
            }
            return View("Edit", dailyAccountViewModel);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GetCategoryDDL(int categoryID = 0)
        {
            return PartialView("CategoryDDL", new CategoryType { CategoryID = (CategoryEnum)categoryID });
        }
        public ActionResult List(int Page = 1)
        {
            IEnumerable<DailyAccountViewModel> dailyAccountViewModels = _dailyAccountService.GetData();

            return PartialView(dailyAccountViewModels.ToPagedList(Page, 10));
        }
    }
}