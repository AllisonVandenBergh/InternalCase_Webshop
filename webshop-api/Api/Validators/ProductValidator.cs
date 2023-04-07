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
                .NotEmpty();

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
    }
}

