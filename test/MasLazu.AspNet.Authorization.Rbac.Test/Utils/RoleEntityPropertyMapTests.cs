using Xunit;
using MasLazu.AspNet.Authorization.Rbac.Utils;
using System.Linq.Expressions;
using MasLazu.AspNet.Authorization.Rbac.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Rbac.Test.Utils;

public class RoleEntityPropertyMapTests
{
    [Fact]
    public void Get_Id_ReturnsExpression()
    {
        var map = new RoleEntityPropertyMap();

        Expression<Func<Role, object>> expr = map.Get("id");

        Assert.NotNull(expr);
    }

    [Fact]
    public void Get_Name_ReturnsExpression()
    {
        var map = new RoleEntityPropertyMap();

        Expression<Func<Role, object>> expr = map.Get("name");

        Assert.NotNull(expr);
    }

    [Fact]
    public void Get_Description_ReturnsExpression()
    {
        var map = new RoleEntityPropertyMap();

        Expression<Func<Role, object>> expr = map.Get("description");

        Assert.NotNull(expr);
    }

    [Fact]
    public void Get_CreatedAt_ReturnsExpression()
    {
        var map = new RoleEntityPropertyMap();

        Expression<Func<Role, object>> expr = map.Get("createdAt");

        Assert.NotNull(expr);
    }

    [Fact]
    public void Get_UpdatedAt_ReturnsExpression()
    {
        var map = new RoleEntityPropertyMap();

        Expression<Func<Role, object>> expr = map.Get("updatedAt");

        Assert.NotNull(expr);
    }

    [Fact]
    public void Get_InvalidProperty_ThrowsArgumentException()
    {
        var map = new RoleEntityPropertyMap();

        Assert.Throws<ArgumentException>(() => map.Get("invalid"));
    }
}
