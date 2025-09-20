using Microsoft.Extensions.DependencyInjection;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAuthorizationRbacEndpoints(this IServiceCollection services)
    {
        // Register endpoint groups
        services.AddSingleton<EndpointGroups.RolesEndpointGroup>();
        services.AddSingleton<EndpointGroups.RolePermissionsEndpointGroup>();
        services.AddSingleton<EndpointGroups.UserRolesEndpointGroup>();

        // Register Roles endpoints
        services.AddSingleton<Endpoints.Roles.GetRoleByIdEndpoint>();
        services.AddSingleton<Endpoints.Roles.GetRolesPaginatedEndpoint>();
        services.AddSingleton<Endpoints.Roles.CreateRoleEndpoint>();
        services.AddSingleton<Endpoints.Roles.UpdateRoleEndpoint>();
        services.AddSingleton<Endpoints.Roles.DeleteRoleEndpoint>();

        // Register RolePermissions endpoints
        services.AddSingleton<Endpoints.RolePermissions.GetRolePermissionByIdEndpoint>();
        services.AddSingleton<Endpoints.RolePermissions.GetRolePermissionsPaginatedEndpoint>();
        services.AddSingleton<Endpoints.RolePermissions.CreateRolePermissionEndpoint>();
        services.AddSingleton<Endpoints.RolePermissions.UpdateRolePermissionEndpoint>();
        services.AddSingleton<Endpoints.RolePermissions.DeleteRolePermissionEndpoint>();

        // Register UserRoles endpoints
        services.AddSingleton<Endpoints.UserRoles.GetUserRoleByIdEndpoint>();
        services.AddSingleton<Endpoints.UserRoles.GetUserRolesPaginatedEndpoint>();
        services.AddSingleton<Endpoints.UserRoles.CreateUserRoleEndpoint>();
        services.AddSingleton<Endpoints.UserRoles.UpdateUserRoleEndpoint>();
        services.AddSingleton<Endpoints.UserRoles.DeleteUserRoleEndpoint>();

        return services;
    }
}
