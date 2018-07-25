using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCHomeWorkMoneyTemplate.EnumType;
using MVCHomeWorkMoneyTemplate.Helper;
using MVCHomeWorkMoneyTemplate.ViewModels;

namespace MVCHomeWorkMoneyTemplate.Service
{
    public class DailyAccountService : IDailyAccountService
    {
        public void EditData(DailyAccountViewModel dailyAccountViewModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DailyAccountViewModel> GetData()
        {
            var dataRandom = new Random();
            for (var i = 0; i < 50; i++)
            {
                var type = dataRandom.Next(0, 2);
                var accountMoney = dataRandom.Next(0, 10000000);
                var accountDate = dataRandom.Next(0, 100);
                var dailyAccountViewModel = new DailyAccountViewModel
                {
                    Money        = accountMoney,
                    CategoryID   = type,
                    CategoryName = ((CategoryEnum) type).GetTypeName(),
                    Date         = DateTime.Now.AddDays(accountDate)
                };
                yield return  dailyAccountViewModel;
            }
        }

        public DailyAccountViewModel GetSingleDataById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool InsData(DailyAccountViewModel dailyAccountViewModel)
        {
            throw new NotImplementedException();
        }
    }
}