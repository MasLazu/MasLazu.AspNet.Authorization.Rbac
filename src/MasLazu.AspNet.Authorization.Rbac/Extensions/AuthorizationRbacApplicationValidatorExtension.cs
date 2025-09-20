using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using MasLazu.AspNet.Authorization.Rbac.Validators;

namespace MasLazu.AspNet.Authorization.Rbac.Extensions;

public static class AuthorizationRbacApplicationValidatorExtension
{
    public static IServiceCollection AddAuthorizationRbacApplicationValidators(this IServiceCollection services)
    {
        services.AddScoped<IValidator<CreateRoleRequest>, CreateRoleRequestValidator>();
        services.AddScoped<IValidator<UpdateRoleRequest>, UpdateRoleRequestValidator>();
        services.AddScoped<IValidator<CreateRolePermissionRequest>, CreateRolePermissionRequestValidator>();
        services.AddScoped<IValidator<UpdateRolePermissionRequest>, UpdateRolePermissionRequestValidator>();
        services.AddScoped<IValidator<CreateUserRoleRequest>, CreateUserRoleRequestValidator>();
        services.AddScoped<IValidator<UpdateUserRoleRequest>, UpdateUserRoleRequestValidator>();

        return services;
    }
}
