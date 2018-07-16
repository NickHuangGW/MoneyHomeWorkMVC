using MVCHomeWorkMoneyTemplate.EnumType;
using MVCHomeWorkMoneyTemplate.Factory;
using MVCHomeWorkMoneyTemplate.Service;
using MVCHomeWorkMoneyTemplate.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHomeWorkMoneyTemplate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GetCategoryDDL()
        {
            return PartialView("CategoryDDL");
        }
        public ActionResult List()
        {
            IDailyAccountService dailyAccountService = new ServiceFactory().GetDailyAccountService();
            IEnumerable<DailyAccountViewModel> dailyAccountViewModels = dailyAccountService.GetData();
            return PartialView(dailyAccountViewModels);
        }
    }
}