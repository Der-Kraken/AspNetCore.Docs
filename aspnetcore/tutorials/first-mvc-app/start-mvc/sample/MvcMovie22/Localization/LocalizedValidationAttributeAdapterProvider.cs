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

            IAttributeAdapter adapter;

            var typeofAttribute = attribute.GetType();

            if (typeofAttribute == typeof(RequiredAttribute))
            {
                adapter = new LocalizedRequiredAttributeAdapter((RequiredAttribute)attribute, stringLocalizer);
            }
            else if (typeofAttribute == typeof(StringLengthAttribute))
            {
                adapter = new LocalizedStringLengthAttributeAdapter((StringLengthAttribute)attribute, stringLocalizer);
            }
            else 
            {
                adapter = null;
            }

            return adapter;
        }
    }
}
