using System.Linq.Expressions;
using MasLazu.AspNet.Authorization.Rbac.Domain.Entities;
using MasLazu.AspNet.Framework.Application.Interfaces;

namespace MasLazu.AspNet.Authorization.Rbac.Utils;

public class RoleEntityPropertyMap : IEntityPropertyMap<Role>
{
    private readonly Dictionary<string, Expression<Func<Role, object>>> _map =
        new(StringComparer.OrdinalIgnoreCase)
        {
            { "id", r => r.Id },
            { "name", r => r.Name },
            { "description", r => r.Description! },
            { "createdAt", r => r.CreatedAt },
            { "updatedAt", r => r.UpdatedAt! }
        };

    public Expression<Func<Role, object>> Get(string property)
    {
        if (_map.TryGetValue(property, out Expression<Func<Role, object>>? expr))
        {
            return expr;
        }

        throw new ArgumentException($"Property '{property}' is not supported for Role. " +
            $"Supported properties: {string.Join(", ", _map.Keys)}");
    }
}
