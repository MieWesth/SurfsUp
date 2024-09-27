using System.ComponentModel.DataAnnotations;

namespace SurfsUp.Models.Validations
{
    public class Wetsuit_EnsureCorrectSizingAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            var wetsuit = validationContext.ObjectInstance as Wetsuit;

            if (wetsuit != null && !string.IsNullOrWhiteSpace(wetsuit.Gender))
            {
                if (wetsuit.Gender.Equals("men", StringComparison.OrdinalIgnoreCase) && wetsuit.Size < 8)
                {
                    return new ValidationResult("For men's wetsuits, the size has to be greater or equal to 8.");
                }
                else if (wetsuit.Gender.Equals("women", StringComparison.OrdinalIgnoreCase) && wetsuit.Size < 6)
                {
                    return new ValidationResult("For women's wetsuits, the size has to be greater or equal to 6.");
                }
            }

            return ValidationResult.Success;
        }

    }
}
