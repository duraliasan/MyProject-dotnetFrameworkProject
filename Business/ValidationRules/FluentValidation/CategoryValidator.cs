using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Product>
    {
        public CategoryValidator()
        {
        }
    }
}
