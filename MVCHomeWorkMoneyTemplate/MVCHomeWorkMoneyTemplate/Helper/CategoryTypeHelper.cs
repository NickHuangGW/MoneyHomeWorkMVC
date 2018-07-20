using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using MVCHomeWorkMoneyTemplate.EnumType;

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

        public static string GetTypeName(this CategoryEnum categoryEnum)
        {
            var typeName = string.Empty;
            switch (categoryEnum)
            {
                case CategoryEnum.Income:
                    typeName = "收入";
                    break;
                case CategoryEnum.Outlay:
                    typeName = "支出";
                    break;
            }
            return typeName;
        }
    }
}