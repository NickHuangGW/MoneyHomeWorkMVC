﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCHomeWorkMoneyTemplate.EnumType;
using MVCHomeWorkMoneyTemplate.ViewModels;

namespace MVCHomeWorkMoneyTemplate.Service
{
    public class DailyAccountService : IDailyAccountService
    {
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
                    CategoryName = GetTypeName((CategoryEnum) type),
                    Date         = DateTime.Now.AddDays(accountDate)
                };
                yield return  dailyAccountViewModel;
            }
        }

        public bool InsData(DailyAccountViewModel dailyAccountViewModel)
        {
            throw new NotImplementedException();
        }

        private string GetTypeName(CategoryEnum categoryEnum)
        {
            string typeName = string.Empty;
            switch (categoryEnum)
            {
                case CategoryEnum.Income:
                    typeName = "收入";
                    break;
                case CategoryEnum.Outlay:
                    typeName = "支出";
                    break;
            }
            return typeName;
        }

    }
}