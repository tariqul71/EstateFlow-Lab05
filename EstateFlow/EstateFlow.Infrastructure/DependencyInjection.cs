using EstateFlow.Application.Data;
using EstateFlow.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EstateFlow.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<EstateFlowDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("EstateFlowDbConnection")));

        services.AddScoped<IApplicationDbContext>(
            sp => sp.GetRequiredService<EstateFlowDbContext>());

        return services;
    }
}
