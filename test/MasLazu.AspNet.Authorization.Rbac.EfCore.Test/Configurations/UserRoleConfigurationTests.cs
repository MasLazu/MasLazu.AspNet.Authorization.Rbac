using Xunit;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MasLazu.AspNet.Authorization.Rbac.EfCore.Configurations;
using MasLazu.AspNet.Authorization.Rbac.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MasLazu.AspNet.Authorization.Rbac.EfCore.Test.Configurations;

public class UserRoleConfigurationTests
{
    [Fact]
    public void Configure_SetsUpEntityCorrectly()
    {
        var builder = new ModelBuilder();
        var configuration = new UserRoleConfiguration();

        configuration.Configure(builder.Entity<UserRole>());

        IMutableEntityType? entity = builder.Model.FindEntityType(typeof(UserRole));
        Assert.NotNull(entity);

        IMutableProperty? userIdProperty = entity.FindProperty("UserId");
        Assert.NotNull(userIdProperty);
        Assert.True(userIdProperty.IsNullable == false);
    }
}
