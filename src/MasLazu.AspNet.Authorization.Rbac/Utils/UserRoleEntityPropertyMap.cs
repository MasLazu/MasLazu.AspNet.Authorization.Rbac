using System.Linq.Expressions;
using MasLazu.AspNet.Authorization.Rbac.Domain.Entities;
using MasLazu.AspNet.Framework.Application.Interfaces;

namespace MasLazu.AspNet.Authorization.Rbac.Utils;

public class UserRoleEntityPropertyMap : IEntityPropertyMap<UserRole>
{
    private readonly Dictionary<string, Expression<Func<UserRole, object>>> _map =
        new(StringComparer.OrdinalIgnoreCase)
        {
            { "id", ur => ur.Id },
            { "roleId", ur => ur.RoleId },
            { "userId", ur => ur.UserId },
            { "createdAt", ur => ur.CreatedAt },
            { "updatedAt", ur => ur.UpdatedAt! }
        };

    public Expression<Func<UserRole, object>> Get(string property)
    {
        if (_map.TryGetValue(property, out Expression<Func<UserRole, object>>? expr))
        {
            return expr;
        }

        throw new ArgumentException($"Property '{property}' is not supported for UserRole. " +
            $"Supported properties: {string.Join(", ", _map.Keys)}");
    }
}
