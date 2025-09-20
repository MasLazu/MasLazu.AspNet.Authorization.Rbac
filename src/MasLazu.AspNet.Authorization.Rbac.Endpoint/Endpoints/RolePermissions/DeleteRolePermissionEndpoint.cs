using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Framework.Application.Models;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Endpoints.RolePermissions;

public class DeleteRolePermissionEndpoint : BaseEndpointWithoutResponse<IdRequest>
{
    public IRolePermissionService RolePermissionService { get; set; }

    public override void ConfigureEndpoint()
    {
        Delete("/{Id}");
        Group<RolePermissionsEndpointGroup>();
    }

    public override async Task HandleAsync(IdRequest req, CancellationToken ct)
    {
        await RolePermissionService.DeleteAsync(Guid.Empty, req.Id, ct);
        await SendSuccessResponseAsync(204, "Role Permission Deleted Successfully", ct);
    }
}
