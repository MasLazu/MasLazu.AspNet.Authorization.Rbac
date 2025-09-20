using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using Xunit;

namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Test.Models;

public class CreateRoleRequestTests
{
    [Fact]
    public void CanCreateCreateRoleRequest()
    {
        string name = "User";
        string description = "User role";

        var request = new CreateRoleRequest(name, description);

        Assert.Equal(name, request.Name);
        Assert.Equal(description, request.Description);
    }
}
