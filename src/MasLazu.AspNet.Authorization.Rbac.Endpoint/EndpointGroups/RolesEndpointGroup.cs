using FastEndpoints;
using Microsoft.AspNetCore.Http;
using MasLazu.AspNet.Framework.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;

public class RolesEndpointGroup : SubGroup<V1EndpointGroup>
{
    public RolesEndpointGroup()
    {
        Configure("roles", ep => ep.Description(x => x.WithTags("Roles")));
    }
}
