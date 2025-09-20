using Xunit;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MasLazu.AspNet.Authorization.Rbac.EfCore.Configurations;
using MasLazu.AspNet.Authorization.Rbac.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MasLazu.AspNet.Authorization.Rbac.EfCore.Test.Configurations;

public class RoleConfigurationTests
{
    [Fact]
    public void Configure_SetsUpEntityCorrectly()
    {
        var builder = new ModelBuilder();
        var configuration = new RoleConfiguration();

        configuration.Configure(builder.Entity<Role>());

        IMutableEntityType? entity = builder.Model.FindEntityType(typeof(Role));
        Assert.NotNull(entity);

        IMutableProperty? nameProperty = entity.FindProperty("Name");
        Assert.NotNull(nameProperty);
        Assert.False(nameProperty.IsNullable);
        Assert.Equal(100, nameProperty.GetMaxLength());
    }
}
