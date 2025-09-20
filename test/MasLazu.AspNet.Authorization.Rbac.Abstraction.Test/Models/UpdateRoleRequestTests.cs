using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using Xunit;

namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Test.Models;

public class UpdateRoleRequestTests
{
    [Fact]
    public void CanCreateUpdateRoleRequest()
    {
        var id = Guid.NewGuid();
        string name = "Updated Role";
        string description = "Updated description";

        var request = new UpdateRoleRequest(id, name, description);

        Assert.Equal(id, request.Id);
        Assert.Equal(name, request.Name);
        Assert.Equal(description, request.Description);
    }
}
