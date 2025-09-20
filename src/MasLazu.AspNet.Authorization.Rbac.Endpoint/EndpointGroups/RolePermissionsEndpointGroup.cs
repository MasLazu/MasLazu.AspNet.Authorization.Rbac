using FastEndpoints;
using Microsoft.AspNetCore.Http;
using MasLazu.AspNet.Framework.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.EndpointGroups;

public class RolePermissionsEndpointGroup : SubGroup<V1EndpointGroup>
{
    public RolePermissionsEndpointGroup()
    {
        Configure("role-permissions", ep => ep.Description(x => x.WithTags("Role Permissions")));
    }
}
