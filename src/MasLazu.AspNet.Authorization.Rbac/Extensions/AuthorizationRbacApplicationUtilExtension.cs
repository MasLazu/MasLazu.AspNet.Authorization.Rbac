using Microsoft.Extensions.DependencyInjection;
using MasLazu.AspNet.Framework.Application.Interfaces;
using MasLazu.AspNet.Authorization.Rbac.Utils;

namespace MasLazu.AspNet.Authorization.Rbac.Extensions;

public static class AuthorizationRbacApplicationUtilExtension
{
    public static IServiceCollection AddAuthorizationRbacApplicationUtils(this IServiceCollection services)
    {
        services.AddScoped<IEntityPropertyMap<Domain.Entities.Role>, RoleEntityPropertyMap>();
        services.AddScoped<IEntityPropertyMap<Domain.Entities.RolePermission>, RolePermissionEntityPropertyMap>();
        services.AddScoped<IEntityPropertyMap<Domain.Entities.UserRole>, UserRoleEntityPropertyMap>();

        return services;
    }
}
