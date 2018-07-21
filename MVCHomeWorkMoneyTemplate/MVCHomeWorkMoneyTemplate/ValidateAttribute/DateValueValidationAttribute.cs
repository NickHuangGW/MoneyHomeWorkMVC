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
            if (value == null)
            {
                return false;
            }

            if (DateTime.TryParse(value.ToString(), out DateTime thisDate))
            {
                if (thisDate <= DateTime.Now)
                {
                    return true;
                }

            }
            return false;
        }
    }
}