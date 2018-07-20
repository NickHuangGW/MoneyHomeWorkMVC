using MVCHomeWorkMoneyTemplate.EnumType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHomeWorkMoneyTemplate.Service
{
    public class CategoryService : ICategoryService
    {
        public List<SelectListItem> GetCategorySelectListItem()
        {
            var categoryItems = new List<SelectListItem>()
            {
                new SelectListItem(){ Text="請選擇",Value=""},
                new SelectListItem(){ Text="收入",Value=((int)CategoryEnum.Income).ToString()},
                new SelectListItem(){ Text="支出",Value=((int)CategoryEnum.Outlay).ToString()}
            };
            return categoryItems;
        }
    }
}