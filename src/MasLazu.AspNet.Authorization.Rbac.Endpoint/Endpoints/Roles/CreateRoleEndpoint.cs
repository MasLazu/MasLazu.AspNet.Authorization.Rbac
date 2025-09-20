using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Endpoints.Roles;

public class CreateRoleEndpoint : BaseEndpoint<CreateRoleRequest, RoleDto>
{
    public IRoleService RoleService { get; set; }

    public override void ConfigureEndpoint()
    {
        Post("/");
        Group<RolesEndpointGroup>();
    }

    public override async Task HandleAsync(CreateRoleRequest req, CancellationToken ct)
    {
        RoleDto result = await RoleService.CreateAsync(Guid.Empty, req, ct);
        await SendSuccessResponseAsync(result, 201, "Role Created Successfully", ct);
    }
}
