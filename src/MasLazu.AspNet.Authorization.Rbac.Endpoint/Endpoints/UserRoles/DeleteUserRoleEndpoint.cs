using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Framework.Application.Models;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Endpoints.UserRoles;

public class DeleteUserRoleEndpoint : BaseEndpointWithoutResponse<IdRequest>
{
    public IUserRoleService UserRoleService { get; set; }

    public override void ConfigureEndpoint()
    {
        Delete("/{Id}");
        Group<UserRolesEndpointGroup>();
    }

    public override async Task HandleAsync(IdRequest req, CancellationToken ct)
    {
        await UserRoleService.DeleteAsync(Guid.Empty, req.Id, ct);
        await SendSuccessResponseAsync(204, "User Role Deleted Successfully", ct);
    }
}
