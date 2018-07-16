using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCHomeWorkMoneyTemplate.EnumType;
using MVCHomeWorkMoneyTemplate.Models;
using MVCHomeWorkMoneyTemplate.ViewModels;

namespace MVCHomeWorkMoneyTemplate.Service
{
    public class DailyAccountByEfService : IDailyAccountService
    {
        private readonly DataBase _db;
        public DailyAccountByEfService()
        {
            _db = new DataBase();
        }
        public IEnumerable<DailyAccountViewModel> GetData()
        {
            foreach (var dt in _db.AccountBook)
            {
                var dailyAccountViewModel = new DailyAccountViewModel
                {
                    Money = dt.Amounttt,
                    CategoryID = dt.Categoryyy,
                    CategoryName = GetTypeName((CategoryEnum)dt.Categoryyy),
                    Date = dt.Dateee
                };
                yield return dailyAccountViewModel;
            }
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