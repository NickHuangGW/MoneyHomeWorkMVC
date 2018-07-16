using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCHomeWorkMoneyTemplate.EnumType
{
    public enum CategoryEnum
    {
        [Display(Name ="收入")]
        Income,
        [Display(Name ="支出")]
        Outlay
    }
    public class CategoryType
    {
        public CategoryEnum Category { get; set; }
    }
}