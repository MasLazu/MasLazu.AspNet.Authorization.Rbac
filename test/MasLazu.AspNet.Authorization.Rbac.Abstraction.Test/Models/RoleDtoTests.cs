using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using Xunit;

namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Test.Models;

public class RoleDtoTests
{
    [Fact]
    public void CanCreateRoleDto()
    {
        var id = Guid.NewGuid();
        string name = "Admin";
        string description = "Administrator role";
        DateTimeOffset createdAt = DateTimeOffset.Now;
        DateTimeOffset updatedAt = DateTimeOffset.Now;

        var dto = new RoleDto(id, name, description, createdAt, updatedAt);

        Assert.Equal(id, dto.Id);
        Assert.Equal(name, dto.Name);
        Assert.Equal(description, dto.Description);
        Assert.Equal(createdAt, dto.CreatedAt);
        Assert.Equal(updatedAt, dto.UpdatedAt);
    }
}
