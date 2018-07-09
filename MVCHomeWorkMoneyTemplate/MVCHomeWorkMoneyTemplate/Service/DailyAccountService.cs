using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCHomeWorkMoneyTemplate.EnumType;
using MVCHomeWorkMoneyTemplate.ViewModels;

namespace MVCHomeWorkMoneyTemplate.Service
{
    public class DailyAccountService : IDailyAccountService
    {
        public List<DailyAccountViewModel> GetData()
        {
            List<DailyAccountViewModel> DailyAccountViewModels = new List<DailyAccountViewModel>();
            Random DataRandom = new Random();
            for (int i = 0; i < 50; i++)
            {
                DailyAccountViewModel DailyAccountViewModel = new DailyAccountViewModel();
                int Type = DataRandom.Next(0, 2);
                int AccountMoney = DataRandom.Next(0, 10000000);
                int AccountDate = DataRandom.Next(0, 100);
                DailyAccountViewModel.Money = AccountMoney;
                DailyAccountViewModel.CategoryID = Type;
                DailyAccountViewModel.CategoryName = GetTypeName((CategoryEnum)Type);
                DailyAccountViewModel.Date = DateTime.Now.AddDays(AccountDate);
                DailyAccountViewModels.Add(DailyAccountViewModel);
            }
            return DailyAccountViewModels;
        }
        private string GetTypeName(CategoryEnum _categoryEnum)
        {
            string TypeName = string.Empty;
            switch (_categoryEnum)
            {
                case CategoryEnum.Income:
                    TypeName = "收入";
                    break;
                case CategoryEnum.Outlay:
                    TypeName = "支出";
                    break;
            }
            return TypeName;
        }

    }
}