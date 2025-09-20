using Microsoft.Extensions.DependencyInjection;

namespace MasLazu.AspNet.Authorization.Rbac.EfCore.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAuthorizationRbacEntityFrameworkCore(this IServiceCollection services)
    {
        return services;
    }
}
