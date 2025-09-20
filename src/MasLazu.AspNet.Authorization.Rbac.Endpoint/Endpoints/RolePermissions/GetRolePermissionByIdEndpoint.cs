using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using MasLazu.AspNet.Framework.Application.Models;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;
using MasLazu.AspNet.Framework.Application.Exceptions;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Endpoints.RolePermissions;

public class GetRolePermissionByIdEndpoint : BaseEndpoint<IdRequest, RolePermissionDto>
{
    public IRolePermissionService RolePermissionService { get; set; }

    public override void ConfigureEndpoint()
    {
        Get("/{Id}");
        Group<RolePermissionsEndpointGroup>();
    }

    public override async Task HandleAsync(IdRequest req, CancellationToken ct)
    {
        RolePermissionDto result = await RolePermissionService.GetByIdAsync(Guid.Empty, req.Id, ct) ??
            throw new NotFoundException(nameof(RolePermissionDto), req.Id);
        await SendOkResponseAsync(result, "Role Permission Retrieved Successfully", ct);
    }
}
