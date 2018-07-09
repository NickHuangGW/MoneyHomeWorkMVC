using MVCHomeWorkMoneyTemplate.EnumType;
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
        public ActionResult GetAccountTypeDDL()
        {
            List<SelectListItem> AccountTypeItems = GetAccountTypeItems();
            return PartialView("AccountTypeDDL", AccountTypeItems);

        }
        public ActionResult List()
        {
            List<DailyAccountViewModel> DailyAccountViewModels = GetData();

            return PartialView(DailyAccountViewModels);
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
        private List<DailyAccountViewModel> GetData()
        {
            List<DailyAccountViewModel> DailyAccountViewModels = new List<DailyAccountViewModel>();
            Random TypeRandom = new Random();
            for (int i = 0; i < 50; i++)
            {
                DailyAccountViewModel DailyAccountViewModel = new DailyAccountViewModel();
                int Type = TypeRandom.Next(0, 1);
                int AccountMoney = TypeRandom.Next(0, 10000000);
                int AccountDate = TypeRandom.Next(0, 100);
                DailyAccountViewModel.AccountingAmount = AccountMoney;
                DailyAccountViewModel.AccountType = Type;
                DailyAccountViewModel.AccountingDate = DateTime.Now.AddDays(AccountDate);
                DailyAccountViewModels.Add(DailyAccountViewModel);
            }
            //List<DailyAccountViewModel> DailyAccountViewModels = new List<DailyAccountViewModel>()
            //{
            //    new DailyAccountViewModel(){ AccountType=0,AccountTypeName="支出",AccountingDate=DateTime.Now,AccountingAmount=1000000,Description="AA"},
            //     new DailyAccountViewModel(){ AccountType=0,AccountTypeName="支出",AccountingDate=null,AccountingAmount=100000,Description="AA"}

            //};
            return DailyAccountViewModels;
        }
    }
}