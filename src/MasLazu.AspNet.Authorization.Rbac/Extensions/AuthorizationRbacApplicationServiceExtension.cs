using Microsoft.Extensions.DependencyInjection;
using MasLazu.AspNet.Authorization.Rbac.Services;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;

namespace MasLazu.AspNet.Authorization.Rbac.Extensions;

public static class AuthorizationRbacApplicationServiceExtension
{
    public static IServiceCollection AddAuthorizationRbacApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IRolePermissionService, RolePermissionService>();
        services.AddScoped<IUserRoleService, UserRoleService>();

        return services;
    }
}
