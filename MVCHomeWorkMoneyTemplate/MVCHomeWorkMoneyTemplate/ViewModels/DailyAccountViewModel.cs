using MVCHomeWorkMoneyTemplate.EnumType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHomeWorkMoneyTemplate.ViewModels
{
    public class DailyAccountViewModel
    {
        public int AccountType { get; set; }

        public DateTime AccountingDate { get; set; }

        public int AccountingAmount { get; set; }
    }
}