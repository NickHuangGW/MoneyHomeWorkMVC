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

        public void EditData(DailyAccountViewModel dailyAccountViewModel)
        {
                AccountBook accountBook = _accountBookRepository.Query(x => x.Id == dailyAccountViewModel.Id).FirstOrDefault();
                accountBook.Amounttt = dailyAccountViewModel.Money;
                accountBook.Dateee = dailyAccountViewModel.Date;
                accountBook.Remarkkk = dailyAccountViewModel.Description;
                accountBook.Categoryyy = dailyAccountViewModel.CategoryID;
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
                    Description = dt.Remarkkk,
                    Id = dt.Id
                };
                yield return dailyAccountViewModel;
            }
        }

        public DailyAccountViewModel GetSingleDataById(Guid id)
        {
            AccountBook accountBook = _accountBookRepository.Query(x => x.Id == id).FirstOrDefault();
            return new DailyAccountViewModel
            {
                CategoryID = accountBook.Categoryyy,
                Date = accountBook.Dateee,
                Money = accountBook.Amounttt,
                Description = accountBook.Remarkkk,
                Id = accountBook.Id
            };
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