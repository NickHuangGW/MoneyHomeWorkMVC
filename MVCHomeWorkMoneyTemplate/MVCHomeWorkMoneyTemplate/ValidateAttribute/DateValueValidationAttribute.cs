using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHomeWorkMoneyTemplate.ValidateAttribute
{
    public sealed class DateValueValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is DateTime)
            {
                return DateTime.Now.CompareTo(Convert.ToDateTime(value)) >= 0;
            }
            return false;
        }
    }
}