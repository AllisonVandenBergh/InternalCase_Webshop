using FluentValidation;
using Webshop.Contracts.Features.Products;
using Webshop.Contracts.Features.Products.Request;

namespace Webshop.Web.Features.Products.V1.CreateProduct;

public class CreateProductCommandValidator : AbstractValidator<CreateProductRequest>
{
    public CreateProductCommandValidator()
    {
        RuleFor(p => p.Sku).Must(p => StockKeepingUnit.TryParse(p.Value, out _))
            .WithMessage("Invalid Sku format.");

        RuleFor(product => product.Name)
            .MinimumLength(1)
            .NotEmpty();

        RuleFor(product => product.Description)
            .MinimumLength(1)
            .When(product => !string.IsNullOrEmpty(product.Description));

        RuleFor(product => product.Image)
            .MinimumLength(1)
            .When(product => !string.IsNullOrEmpty(product.Image));

        RuleFor(product => product.BasePrice)
            .NotEmpty()
            .GreaterThan(0);

        RuleFor(product => product.SellPrice)
            .NotEmpty()
            .GreaterThan(0);
    }
}