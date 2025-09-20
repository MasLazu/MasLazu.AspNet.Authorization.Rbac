using System.Linq.Expressions;
using MasLazu.AspNet.Authorization.Rbac.Domain.Entities;
using MasLazu.AspNet.Framework.Application.Interfaces;

namespace MasLazu.AspNet.Authorization.Rbac.Utils;

public class RolePermissionEntityPropertyMap : IEntityPropertyMap<RolePermission>
{
    private readonly Dictionary<string, Expression<Func<RolePermission, object>>> _map =
        new(StringComparer.OrdinalIgnoreCase)
        {
            { "id", rp => rp.Id },
            { "permissionId", rp => rp.PermissionId },
            { "roleId", rp => rp.RoleId },
            { "createdAt", rp => rp.CreatedAt },
            { "updatedAt", rp => rp.UpdatedAt! }
        };

    public Expression<Func<RolePermission, object>> Get(string property)
    {
        if (_map.TryGetValue(property, out Expression<Func<RolePermission, object>>? expr))
        {
            return expr;
        }

        throw new ArgumentException($"Property '{property}' is not supported for RolePermission. " +
            $"Supported properties: {string.Join(", ", _map.Keys)}");
    }
}
