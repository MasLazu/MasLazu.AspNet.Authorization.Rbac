using FastEndpoints;
using Microsoft.AspNetCore.Http;
using MasLazu.AspNet.Framework.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;

public class UserRolesEndpointGroup : SubGroup<V1EndpointGroup>
{
    public UserRolesEndpointGroup()
    {
        Configure("user-roles", ep => ep.Description(x => x.WithTags("User Roles")));
    }
}
