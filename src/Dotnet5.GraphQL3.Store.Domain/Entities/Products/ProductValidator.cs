﻿using FluentValidation;

namespace Dotnet5.GraphQL3.Store.Domain.Entities.Products
{
    public abstract class ProductValidator<TProduct> : AbstractValidator<TProduct>
        where TProduct : Product
    {
        protected ProductValidator()
        {
            RuleFor(x => x.Description)
                .NotNull()
                .NotEmpty()
                .WithMessage(Resource.Product_Description_Null_Empty);

            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage(Resource.Product_Name_Null_Empty);

            RuleFor(x => x.Option)
                .NotNull()
                .WithMessage(Resource.Product_Option_Null);

            RuleFor(x => x.Price)
                .LessThanOrEqualTo(decimal.Zero)
                .WithMessage(Resource.Product_Price_Invalid);
        }
    }
}