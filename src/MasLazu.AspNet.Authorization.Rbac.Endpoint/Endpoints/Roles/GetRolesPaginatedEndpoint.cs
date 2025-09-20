using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using MasLazu.AspNet.Framework.Application.Models;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Endpoints.Roles;

public class GetRolesPaginatedEndpoint : BaseEndpoint<PaginationRequest, PaginatedResult<RoleDto>>
{
    public IRoleService RoleService { get; set; }

    public override void ConfigureEndpoint()
    {
        Post("/paginated");
        Group<RolesEndpointGroup>();
        AllowAnonymous();
    }

    public override async Task HandleAsync(PaginationRequest req, CancellationToken ct)
    {
        PaginatedResult<RoleDto> result = await RoleService.GetPaginatedAsync(Guid.Empty, req, ct);
        await SendOkResponseAsync(result, "Roles Retrieved Successfully", ct);
    }
}
