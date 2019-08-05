using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.Localization;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MvcMovie.Localization
{
    public class LocalizedValidationAttributeAdapterProvider : IValidationAttributeAdapterProvider
    {
        public virtual IAttributeAdapter GetAttributeAdapter(ValidationAttribute attribute, IStringLocalizer stringLocalizer)
        {
            if (attribute == null) throw new ArgumentNullException(nameof(attribute));

            attribute.ErrorMessage = attribute.GetType().Name;

            return new ValidationAttributeAdapterProvider()
                .GetAttributeAdapter(attribute, stringLocalizer);
        }
    }
}
