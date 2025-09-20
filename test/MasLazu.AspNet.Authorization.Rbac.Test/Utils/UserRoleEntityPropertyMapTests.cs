using Xunit;
using MasLazu.AspNet.Authorization.Rbac.Utils;
using System.Linq.Expressions;
using MasLazu.AspNet.Authorization.Rbac.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Rbac.Test.Utils;

public class UserRoleEntityPropertyMapTests
{
    [Fact]
    public void Get_ValidProperty_ReturnsExpression()
    {
        var map = new UserRoleEntityPropertyMap();

        Expression<Func<UserRole, object>> expr = map.Get("userId");

        Assert.NotNull(expr);
    }

    [Fact]
    public void Get_InvalidProperty_ThrowsArgumentException()
    {
        var map = new UserRoleEntityPropertyMap();

        Assert.Throws<ArgumentException>(() => map.Get("invalid"));
    }
}
