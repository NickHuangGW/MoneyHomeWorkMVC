using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVCHomeWorkMoneyTemplate.Service
{
    public interface ICategoryService
    {
        List<SelectListItem> GetCategorySelectListItem();
    }
}
