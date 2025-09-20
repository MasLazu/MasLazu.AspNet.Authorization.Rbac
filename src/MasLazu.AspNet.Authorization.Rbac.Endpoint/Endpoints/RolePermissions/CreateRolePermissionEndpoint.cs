using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Endpoints.RolePermissions;

public class CreateRolePermissionEndpoint : BaseEndpoint<CreateRolePermissionRequest, RolePermissionDto>
{
    public IRolePermissionService RolePermissionService { get; set; }

    public override void ConfigureEndpoint()
    {
        Post("/");
        Group<RolePermissionsEndpointGroup>();
    }

    public override async Task HandleAsync(CreateRolePermissionRequest req, CancellationToken ct)
    {
        RolePermissionDto result = await RolePermissionService.CreateAsync(Guid.Empty, req, ct);
        await SendSuccessResponseAsync(result, 201, "Role Permission Created Successfully", ct);
    }
}
