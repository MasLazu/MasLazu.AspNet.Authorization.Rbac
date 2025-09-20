using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Endpoints.RolePermissions;

public class UpdateRolePermissionEndpoint : BaseEndpoint<UpdateRolePermissionRequest, RolePermissionDto>
{
    public IRolePermissionService RolePermissionService { get; set; }

    public override void ConfigureEndpoint()
    {
        Put("/");
        Group<RolePermissionsEndpointGroup>();
    }

    public override async Task HandleAsync(UpdateRolePermissionRequest req, CancellationToken ct)
    {
        RolePermissionDto result = await RolePermissionService.UpdateAsync(Guid.Empty, req, ct);
        await SendOkResponseAsync(result, "Role Permission Updated Successfully", ct);
    }
}
