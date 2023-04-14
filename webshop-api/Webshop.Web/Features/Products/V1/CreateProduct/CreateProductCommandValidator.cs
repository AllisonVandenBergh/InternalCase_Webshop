using FluentValidation;
using Webshop.Core.Features.Products.Domain.Request;

namespace Webshop.Web.Features.Products.V1.CreateProduct;

public class CreateProductCommandValidator: AbstractValidator<CreateProductRequest>
{
    public CreateProductCommandValidator()
    {
        RuleFor(product => product.Sku)
            .NotNull()
            .NotEmpty()
            .MinimumLength(8);

        RuleFor(product => product.Name)
            .NotEmpty()
            //.NotNull()
            .MinimumLength(1);

        RuleFor(product => product.Description)
            .MinimumLength(1)
            .When(product => !string.IsNullOrEmpty(product.Description));

        RuleFor(product => product.Image)
            .MinimumLength(1)
            .When(product => !string.IsNullOrEmpty(product.Image));

        RuleFor(product => product.BasePrice)
            .NotEmpty()
            .NotNull()
            .GreaterThan(0);

        RuleFor(product => product.SellPrice)
            .NotEmpty()
            .NotNull()
            .GreaterThan(0);
    }
}