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
            ICategoryService CategoryService = new ServiceFactory().GetCategoryService();
            List<SelectListItem> CategorySelectListItems = CategoryService.GetCategorySelectListItem();
            return PartialView("CategoryDDL", CategorySelectListItems);

        }
        public ActionResult List()
        {
            IDailyAccountService DailyAccountService = new ServiceFactory().GetDailyAccountService();
            List<DailyAccountViewModel> DailyAccountViewModels = DailyAccountService.GetData();
            return PartialView(DailyAccountViewModels);
        }
    }
}