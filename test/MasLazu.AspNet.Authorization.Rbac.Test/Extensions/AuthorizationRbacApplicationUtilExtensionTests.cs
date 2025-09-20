using Xunit;
using Microsoft.Extensions.DependencyInjection;
using MasLazu.AspNet.Authorization.Rbac.Extensions;

namespace MasLazu.AspNet.Authorization.Rbac.Test.Extensions;

public class AuthorizationRbacApplicationUtilExtensionTests
{
    [Fact]
    public void AddAuthorizationRbacApplicationUtils_AddsServices()
    {
        var services = new ServiceCollection();

        IServiceCollection result = services.AddAuthorizationRbacApplicationUtils();

        Assert.NotNull(result);
        Assert.Equal(services, result);
    }
}
