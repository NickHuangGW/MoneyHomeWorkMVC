using MVCHomeWorkMoneyTemplate.EnumType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCHomeWorkMoneyTemplate.ViewModels
{
    public class DailyAccountViewModel
    {
        [Display(Name ="類別ID")]
        public int? CategoryID { get; set; }
        [Display(Name = "類別名稱")]
        public string CategoryName { get; set; }
        [Display(Name = "日期")]
        public DateTime? Date { get; set; }
        [Display(Name = "金額")]
        public int Money { get; set; }
        [Display(Name = "備註")]
        public string Description { get; set; }
    }
}