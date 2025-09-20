using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using MasLazu.AspNet.Framework.Application.Models;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;
using MasLazu.AspNet.Framework.Application.Exceptions;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Endpoints.UserRoles;

public class GetUserRoleByIdEndpoint : BaseEndpoint<IdRequest, UserRoleDto>
{
    public IUserRoleService UserRoleService { get; set; }

    public override void ConfigureEndpoint()
    {
        Get("/{Id}");
        Group<UserRolesEndpointGroup>();
    }

    public override async Task HandleAsync(IdRequest req, CancellationToken ct)
    {
        UserRoleDto result = await UserRoleService.GetByIdAsync(Guid.Empty, req.Id, ct) ??
            throw new NotFoundException(nameof(UserRoleDto), req.Id);
        await SendOkResponseAsync(result, "User Role Retrieved Successfully", ct);
    }
}
