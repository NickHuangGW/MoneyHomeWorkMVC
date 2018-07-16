using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHomeWorkMoneyTemplate.Helper
{
    public static class CategoryTypeHelper
    {
        public static HtmlString DisplayCategoryType(this HtmlHelper htmlHelper, int? CategoryType, string CategoryName)
        {
            var className = string.Empty;
            if (CategoryType != null && CategoryType == 0)
            {
                className = "primary";
            }
            else
            {
                className = "danger";
            }
            return new HtmlString($"<span class='text-{className}'>{CategoryName}</span>");
        }

    }
}