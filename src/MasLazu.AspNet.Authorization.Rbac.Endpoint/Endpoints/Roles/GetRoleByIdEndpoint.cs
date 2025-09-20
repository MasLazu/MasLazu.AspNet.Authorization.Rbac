using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using MasLazu.AspNet.Framework.Application.Models;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;
using MasLazu.AspNet.Framework.Application.Exceptions;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Endpoints.Roles;

public class GetRoleByIdEndpoint : BaseEndpoint<IdRequest, RoleDto>
{
    public IRoleService RoleService { get; set; }

    public override void ConfigureEndpoint()
    {
        Get("/{Id}");
        Group<RolesEndpointGroup>();
    }

    public override async Task HandleAsync(IdRequest req, CancellationToken ct)
    {
        RoleDto result = await RoleService.GetByIdAsync(Guid.Empty, req.Id, ct) ??
            throw new NotFoundException(nameof(RoleDto), req.Id);
        await SendOkResponseAsync(result, "Role Retrieved Successfully", ct);
    }
}
