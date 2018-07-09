using MVCHomeWorkMoneyTemplate.EnumType;
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
        public ActionResult GetAccountTypeDDL()
        {
            List<SelectListItem> AccountTypeItems = GetAccountTypeItems();
            return PartialView("AccountTypeDDL", AccountTypeItems);

        }
        private List<SelectListItem> GetAccountTypeItems()
        {
            List<SelectListItem> AccountTypeItems = new List<SelectListItem>()
            {
                new SelectListItem(){ Text="請選擇",Value=""},
                new SelectListItem(){ Text="收入",Value=((int)AccountTypeEnum.Income).ToString()},
                new SelectListItem(){ Text="支出",Value=((int)AccountTypeEnum.Outlay).ToString()}
            };
            return AccountTypeItems;
        }
    }
}