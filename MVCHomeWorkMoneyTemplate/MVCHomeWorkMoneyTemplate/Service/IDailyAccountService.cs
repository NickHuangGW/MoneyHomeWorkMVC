using MVCHomeWorkMoneyTemplate.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHomeWorkMoneyTemplate.Service
{
    public interface IDailyAccountService
    {
        IEnumerable<DailyAccountViewModel> GetData();

        bool InsData(DailyAccountViewModel dailyAccountViewModel);

        DailyAccountViewModel GetSingleDataById(Guid id);
    }
}
