using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.Localization;
using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Localization
{
    public class LocalizedValidationAttributeAdapterProvider : IValidationAttributeAdapterProvider
    {
        public virtual IAttributeAdapter GetAttributeAdapter(ValidationAttribute attribute, IStringLocalizer stringLocalizer)
        {
            if (attribute == null) throw new ArgumentNullException(nameof(attribute));

            // If no domain specific error message is placed then reference a global one.
            if (string.IsNullOrEmpty(attribute.ErrorMessage)
                && string.IsNullOrEmpty(attribute.ErrorMessageResourceName)
                && attribute.ErrorMessageResourceType == null)
            {
                attribute.ErrorMessage = attribute.GetType().Name;
            }

            return new ValidationAttributeAdapterProvider()
                .GetAttributeAdapter(attribute, stringLocalizer);
        }
    }
}
