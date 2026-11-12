using EstateFlow.Application.Contracts.Expenses;
using EstateFlow.Application.Services;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace EstateFlow.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<CreateExpenseRequestValidator>();
        services.AddScoped<IMeterReadingService, MeterReadingService>();

        return services;
    }
}
