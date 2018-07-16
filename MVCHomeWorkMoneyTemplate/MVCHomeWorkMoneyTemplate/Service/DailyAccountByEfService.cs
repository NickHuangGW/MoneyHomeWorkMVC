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
                    Date = dt.Dateee,
                    Description= dt.Remarkkk
                };
                yield return dailyAccountViewModel;
            }
        }

        public bool InsData(DailyAccountViewModel dailyAccountViewModel)
        {
            bool isSucess = true;
            try
            {
                var accountBook = new AccountBook
                {
                    Id = Guid.NewGuid(),
                    Amounttt = dailyAccountViewModel.Money,
                    Categoryyy = Convert.ToInt32(dailyAccountViewModel.CategoryID),
                    Dateee = Convert.ToDateTime(dailyAccountViewModel.Date),
                    Remarkkk = dailyAccountViewModel.Description
                };
                _db.AccountBook.Add(accountBook);
                _db.SaveChanges();
            }
            catch
            {
                isSucess = false;
            }
            return isSucess;
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