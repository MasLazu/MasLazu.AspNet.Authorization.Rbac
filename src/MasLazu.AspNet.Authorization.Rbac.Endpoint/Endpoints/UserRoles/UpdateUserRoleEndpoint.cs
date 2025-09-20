using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Endpoints.UserRoles;

public class UpdateUserRoleEndpoint : BaseEndpoint<UpdateUserRoleRequest, UserRoleDto>
{
    public IUserRoleService UserRoleService { get; set; }

    public override void ConfigureEndpoint()
    {
        Put("/");
        Group<UserRolesEndpointGroup>();
    }

    public override async Task HandleAsync(UpdateUserRoleRequest req, CancellationToken ct)
    {
        UserRoleDto result = await UserRoleService.UpdateAsync(Guid.Empty, req, ct);
        await SendOkResponseAsync(result, "User Role Updated Successfully", ct);
    }
}
