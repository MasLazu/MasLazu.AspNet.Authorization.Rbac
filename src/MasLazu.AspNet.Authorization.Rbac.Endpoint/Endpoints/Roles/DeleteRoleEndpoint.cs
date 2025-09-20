using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Framework.Application.Models;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Endpoints.Roles;

public class DeleteRoleEndpoint : BaseEndpointWithoutResponse<IdRequest>
{
    public IRoleService RoleService { get; set; }

    public override void ConfigureEndpoint()
    {
        Delete("/{Id}");
        Group<RolesEndpointGroup>();
    }

    public override async Task HandleAsync(IdRequest req, CancellationToken ct)
    {
        await RoleService.DeleteAsync(Guid.Empty, req.Id, ct);
        await SendSuccessResponseAsync(204, "Role Deleted Successfully", ct);
    }
}
