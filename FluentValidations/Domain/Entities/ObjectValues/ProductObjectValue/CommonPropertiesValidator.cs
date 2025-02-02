﻿using Domain.Entities.ObjectValues.ProductObjectValue;
using FluentValidation;

namespace FluentValidations.Domain.Entities.ObjectValues.ProductObjectValue;

public class CommonPropertiesValidator : AbstractValidator<CommonPropertiesObjectValue>
{
    public CommonPropertiesValidator()
    {
        RuleFor(x => x.Gender)
            .NotEmpty().WithMessage("Gender cannot be empty.")
            .MaximumLength(10).WithMessage("Gender must have a maximum length of 10 characters.");

        RuleFor(x => x.Color)
            .NotEmpty().WithMessage("Color cannot be empty.")
            .MaximumLength(20).WithMessage("Color must have a maximum length of 20 characters.");

        RuleFor(x => x.Age)
            .NotEmpty().WithMessage("Age cannot be empty.")
            .MaximumLength(10).WithMessage("Age must have a maximum length of 10 characters.");

        RuleFor(x => x.RecommendedUser)
            .NotEmpty().WithMessage("Recommended uses cannot be empty.")
            .MaximumLength(15).WithMessage("Recommended uses must have a maximum length of 15 characters.");

        RuleFor(x => x.Size)
            .NotEmpty().WithMessage("Size cannot be empty.")
            .MaximumLength(10).WithMessage("Size must have a maximum length of 10 characters.");
    }
}