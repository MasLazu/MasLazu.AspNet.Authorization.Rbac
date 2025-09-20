using Xunit;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MasLazu.AspNet.Authorization.Rbac.EfCore.Configurations;
using MasLazu.AspNet.Authorization.Rbac.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MasLazu.AspNet.Authorization.Rbac.EfCore.Test.Configurations;

public class RolePermissionConfigurationTests
{
    [Fact]
    public void Configure_SetsUpEntityCorrectly()
    {
        var builder = new ModelBuilder();
        var configuration = new RolePermissionConfiguration();

        configuration.Configure(builder.Entity<RolePermission>());

        IMutableEntityType? entity = builder.Model.FindEntityType(typeof(RolePermission));
        Assert.NotNull(entity);

        IMutableProperty? permissionIdProperty = entity.FindProperty("PermissionId");
        Assert.NotNull(permissionIdProperty);
        Assert.True(permissionIdProperty.IsNullable == false);
    }
}
