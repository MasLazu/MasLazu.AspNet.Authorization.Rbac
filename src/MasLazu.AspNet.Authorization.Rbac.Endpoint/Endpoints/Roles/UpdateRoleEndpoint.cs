using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;
using MasLazu.AspNet.Framework.Application.Exceptions;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Endpoints.Roles;

public class UpdateRoleEndpoint : BaseEndpoint<UpdateRoleRequest, RoleDto>
{
    public IRoleService RoleService { get; set; }

    public override void ConfigureEndpoint()
    {
        Put("/");
        Group<RolesEndpointGroup>();
    }

    public override async Task HandleAsync(UpdateRoleRequest req, CancellationToken ct)
    {
        RoleDto result = await RoleService.UpdateAsync(Guid.Empty, req, ct);
        await SendOkResponseAsync(result, "Role Updated Successfully", ct);
    }
}
