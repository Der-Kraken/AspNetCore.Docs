using Microsoft.AspNetCore.Mvc.DataAnnotations.Internal;
using Microsoft.Extensions.Localization;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Localization
{
    internal class LocalizedStringLengthAttributeAdapter : StringLengthAttributeAdapter
    {
        public LocalizedStringLengthAttributeAdapter(StringLengthAttribute attribute, IStringLocalizer stringLocalizer) : base(attribute, stringLocalizer)
        {
            attribute.ErrorMessage = nameof(StringLengthAttribute);
        }
    }
}