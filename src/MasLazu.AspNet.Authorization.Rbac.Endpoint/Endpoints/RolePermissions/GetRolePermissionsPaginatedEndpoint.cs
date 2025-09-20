using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using MasLazu.AspNet.Framework.Application.Models;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Endpoints.RolePermissions;

public class GetRolePermissionsPaginatedEndpoint : BaseEndpoint<PaginationRequest, PaginatedResult<RolePermissionDto>>
{
    public IRolePermissionService RolePermissionService { get; set; }

    public override void ConfigureEndpoint()
    {
        Post("/paginated");
        Group<RolePermissionsEndpointGroup>();
        AllowAnonymous();
    }

    public override async Task HandleAsync(PaginationRequest req, CancellationToken ct)
    {
        PaginatedResult<RolePermissionDto> result = await RolePermissionService.GetPaginatedAsync(Guid.Empty, req, ct);
        await SendOkResponseAsync(result, "Role Permissions Retrieved Successfully", ct);
    }
}
