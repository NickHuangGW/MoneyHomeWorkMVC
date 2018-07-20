using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCHomeWorkMoneyTemplate.EnumType;
using MVCHomeWorkMoneyTemplate.Helper;
using MVCHomeWorkMoneyTemplate.Models;
using MVCHomeWorkMoneyTemplate.Repository;
using MVCHomeWorkMoneyTemplate.ViewModels;

namespace MVCHomeWorkMoneyTemplate.Service
{
    public class DailyAccountByEfService : IDailyAccountService
    {
        private readonly IGenericRepostiory<AccountBook> _accountBookRepository;
        public DailyAccountByEfService(IUnitOfWork unitOfWork)
        {
            _accountBookRepository = new GenericRepostiory<AccountBook>(unitOfWork);
        }
        public IEnumerable<DailyAccountViewModel> GetData()
        {
            foreach (var dt in _accountBookRepository.GetAll())
            {
                var dailyAccountViewModel = new DailyAccountViewModel
                {
                    Money = dt.Amounttt,
                    CategoryID = dt.Categoryyy,
                    CategoryName = ((CategoryEnum)dt.Categoryyy).GetTypeName(),
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
                _accountBookRepository.Create(accountBook);
            }
            catch
            {
                isSucess = false;
            }
            return isSucess;
        }

        
    }
}