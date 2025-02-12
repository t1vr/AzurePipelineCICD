﻿using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArc.SharedKernel.ValidationBase;

public class ApplicationBaseValidationModelProvider<TApplicationModel>:AbstractValidator<TApplicationModel>;