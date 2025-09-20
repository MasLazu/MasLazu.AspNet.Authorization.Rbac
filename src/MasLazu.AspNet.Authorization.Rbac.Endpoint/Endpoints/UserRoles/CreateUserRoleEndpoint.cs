using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Endpoints.UserRoles;

public class CreateUserRoleEndpoint : BaseEndpoint<CreateUserRoleRequest, UserRoleDto>
{
    public IUserRoleService UserRoleService { get; set; }

    public override void ConfigureEndpoint()
    {
        Post("/");
        Group<UserRolesEndpointGroup>();
    }

    public override async Task HandleAsync(CreateUserRoleRequest req, CancellationToken ct)
    {
        UserRoleDto result = await UserRoleService.CreateAsync(Guid.Empty, req, ct);
        await SendSuccessResponseAsync(result, 201, "User Role Created Successfully", ct);
    }
}
