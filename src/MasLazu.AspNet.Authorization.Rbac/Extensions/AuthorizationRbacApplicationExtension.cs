using Microsoft.Extensions.DependencyInjection;

namespace MasLazu.AspNet.Authorization.Rbac.Extensions;

public static class AuthorizationRbacApplicationExtension
{
    public static IServiceCollection AddAuthorizationRbacApplication(this IServiceCollection services)
    {
        services.AddAuthorizationRbacApplicationServices();
        services.AddAuthorizationRbacApplicationUtils();
        services.AddAuthorizationRbacApplicationValidators();

        return services;
    }
}
