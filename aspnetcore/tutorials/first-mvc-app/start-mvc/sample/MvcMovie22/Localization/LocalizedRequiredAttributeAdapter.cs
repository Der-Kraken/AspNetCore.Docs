using Microsoft.AspNetCore.Mvc.DataAnnotations.Internal;
using Microsoft.Extensions.Localization;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Localization
{
    internal class LocalizedRequiredAttributeAdapter : RequiredAttributeAdapter
    {
        public LocalizedRequiredAttributeAdapter(RequiredAttribute attribute, IStringLocalizer stringLocalizer) : base(attribute, stringLocalizer)
        {
            attribute.ErrorMessage = nameof(RequiredAttribute);
        }
    }
}