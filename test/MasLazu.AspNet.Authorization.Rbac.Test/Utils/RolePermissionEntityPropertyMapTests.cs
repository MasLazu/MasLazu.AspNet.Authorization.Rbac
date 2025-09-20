using Xunit;
using MasLazu.AspNet.Authorization.Rbac.Utils;
using System.Linq.Expressions;
using MasLazu.AspNet.Authorization.Rbac.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Rbac.Test.Utils;

public class RolePermissionEntityPropertyMapTests
{
    [Fact]
    public void Get_ValidProperty_ReturnsExpression()
    {
        var map = new RolePermissionEntityPropertyMap();

        Expression<Func<RolePermission, object>> expr = map.Get("roleId");

        Assert.NotNull(expr);
    }

    [Fact]
    public void Get_InvalidProperty_ThrowsArgumentException()
    {
        var map = new RolePermissionEntityPropertyMap();

        Assert.Throws<ArgumentException>(() => map.Get("invalid"));
    }
}
