using MVCHomeWorkMoneyTemplate.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHomeWorkMoneyTemplate.Factory
{
    public class ServiceFactory
    {
        public IDailyAccountService GetDailyAccountService()
        {
            return new DailyAccountService();
        }
        public ICategoryService GetCategoryService()
        {
            return new CategoryService();
        }
    }
}