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
        [Required]
        [Display(Name ="類別")]
        public int? CategoryID { get; set; }
        [Required]
        [Display(Name = "類別名稱")]
        public string CategoryName { get; set; }
        [Required]
        [Display(Name = "日期")]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
        [Required]
        [Display(Name = "金額")]
        [DataType(DataType.Currency)]
        public int Money { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "備註")]
        public string Description { get; set; }
    }
}