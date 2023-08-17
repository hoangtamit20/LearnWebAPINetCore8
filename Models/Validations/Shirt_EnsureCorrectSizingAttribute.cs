using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPINet8.Models.Validations
{
    public class Shirt_EnsureCorrectSizingAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var shirt = validationContext.ObjectInstance as Shirt;
            if (shirt != null)
            {
                if (shirt.Gender != null)
                {
                    if (shirt.Gender.Equals("men", StringComparison.OrdinalIgnoreCase) && shirt.Size < 8)
                    {
                        return new ValidationResult("For men's shirts, the size has to be greater or equal to 8.");
                    }
                    else if (shirt.Gender.Equals("women", StringComparison.OrdinalIgnoreCase) && shirt.Size < 6)
                    {
                        return new ValidationResult("For women's shirts, the soze has to be greater or equal to 6.");
                    }
                }
                else
                {
                    return new ValidationResult("gender is null");
                }
            }
            return ValidationResult.Success;
        }

    }
}