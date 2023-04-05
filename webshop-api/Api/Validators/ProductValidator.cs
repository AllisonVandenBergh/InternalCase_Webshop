using System;
using Domain.Entities;
using FluentValidation;

namespace Api.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(product => product.Sku)
                .NotNull()
                .NotEmpty()
                .Must(ValidateGuid)
                .WithMessage("Sku is not a valid Guid");

            RuleFor(product => product.Name)
                .NotEmpty();

            RuleFor(product => product.Description)
                .NotEmpty();

            RuleFor(product => product.BasePrice)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(product => product.SellPrice)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(product => product.InStock)
                .NotEmpty();
        }

        private bool ValidateGuid(Guid guid)
        {
            try
            {
                if (Guid.TryParse(guid.ToString(), out Guid validatedGuid))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }


}

