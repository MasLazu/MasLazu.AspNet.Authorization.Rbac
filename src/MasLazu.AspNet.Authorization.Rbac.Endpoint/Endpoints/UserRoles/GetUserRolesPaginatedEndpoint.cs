using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using MasLazu.AspNet.Framework.Application.Models;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Endpoints.UserRoles;

public class GetUserRolesPaginatedEndpoint : BaseEndpoint<PaginationRequest, PaginatedResult<UserRoleDto>>
{
    public IUserRoleService UserRoleService { get; set; }

    public override void ConfigureEndpoint()
    {
        Post("/paginated");
        Group<UserRolesEndpointGroup>();
        AllowAnonymous();
    }

    public override async Task HandleAsync(PaginationRequest req, CancellationToken ct)
    {
        PaginatedResult<UserRoleDto> result = await UserRoleService.GetPaginatedAsync(Guid.Empty, req, ct);
        await SendOkResponseAsync(result, "User Roles Retrieved Successfully", ct);
    }
}
