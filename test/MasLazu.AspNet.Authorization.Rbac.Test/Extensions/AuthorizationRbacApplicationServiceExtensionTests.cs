using Xunit;
using Microsoft.Extensions.DependencyInjection;
using MasLazu.AspNet.Authorization.Rbac.Extensions;

namespace MasLazu.AspNet.Authorization.Rbac.Test.Extensions;

public class AuthorizationRbacApplicationServiceExtensionTests
{
    [Fact]
    public void AddAuthorizationRbacApplicationServices_AddsServices()
    {
        var services = new ServiceCollection();

        IServiceCollection result = services.AddAuthorizationRbacApplicationServices();

        Assert.NotNull(result);
        Assert.Equal(services, result);
    }
}
